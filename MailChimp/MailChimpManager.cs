using MailChimp.Responses;
using MailChimp.Error;
using MailChimp.Requests;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp
{
    public class MailChimpManager
    {
        #region Constants

        const string BaseAPIUrl = "api.mailchimp.com";
        const string APIVersion = "3.0";
        const string APIProtocol = "https";

        #endregion

        #region Properties

        public string APIKey { get; set; }

        #endregion

        #region Contructors

        public MailChimpManager(string apiKey)
        {
            APIKey = apiKey;
        }

        #endregion

        #region Public Methods

        public ListResult GetLists()
        {
            try
            {
                return MakeAPICall<ListResult>("lists", Method.GET, null);
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public SubscriberResult AddCustomer(string listId, Subscriber subscriber)
        {
            string body = JsonConvert.SerializeObject(subscriber);

            return MakeAPICall<SubscriberResult>(string.Format("lists/{0}/members", listId), Method.POST, body);
        }

        #endregion

        #region Generic API calling method

        private T MakeAPICall<T>(string action, Method method, string body)
        {
            var client = new RestClient(GetBaseUrl());
            client.Authenticator = new HttpBasicAuthenticator("APIKey", APIKey);

            var request = new RestRequest(action, method) { RequestFormat = DataFormat.Json };

            request.AddParameter("application/json; charset=utf-8", body, ParameterType.RequestBody);
            
            var response = client.Execute(request);

            if (response.Content == null)
            {
                throw new MailChimpException(response.ErrorMessage, null, null);
            }
            else
            {
                if(response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    throw new MailChimpException(response.ErrorMessage, null, JsonConvert.DeserializeObject<Error.Error>(response.Content));
                }
            }

            var returnedObject = JsonConvert.DeserializeObject<T>(response.Content);

            return (T)Convert.ChangeType(returnedObject, typeof(T));
        }

        #endregion

        #region Private Methods
        private string GetBaseUrl()
        {
            if (APIKey.LastIndexOf("-") > 0)
            {
                string dc = APIKey.Substring(APIKey.LastIndexOf("-") + 1, APIKey.Length - APIKey.LastIndexOf("-") - 1);
                return string.Format("{0}://{1}.{2}/{3}/", APIProtocol, dc, BaseAPIUrl, APIVersion);
            }
            return "";
        }
        #endregion
    }
}
