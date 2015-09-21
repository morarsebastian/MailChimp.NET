﻿using System;
using System.Collections.Generic;
using MailChimp.DTOs;
using MailChimp.Error;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RestSharp;

namespace MailChimp
{
    public class MailChimpManager
    {
        #region Constants

        const string BaseAPIUrl = "api.mailchimp.com";
        const string APIVersion = "3.0";
        const string APIProtocol = "https";
        const string DatacenterSuffixSplitter = "-";

        #endregion

        #region Properties

        private string apiKey;
        /// <summary>
        /// A mailchimp API-Key containing the datacenter suffix, or an OAuth key
        /// </summary>
        public string APIKey
        {
            get { return apiKey; }
            set
            {
                apiKey = value;
                var indexOfSplitter = value.IndexOf(DatacenterSuffixSplitter, StringComparison.Ordinal);
                if (indexOfSplitter > -1)
                {
                    Datacenter = value.Substring(indexOfSplitter + 1, value.Length - indexOfSplitter - 1);
                }
            }
        }

        /// <summary>
        /// To check if the given APIKey is a plain API Key or an OAuth access token which does not contain a datacenter suffix
        /// </summary>
        private bool IsPlainAPIKey
        {
            get { return APIKey.IndexOf(DatacenterSuffixSplitter) > -1; }
        }

        /// <summary>
        /// The mailchimp datacenter to operate with, this may be automatically set through defining a mailchimp API key.
        /// When using an OAuth key, the Datacenter must be specified separately (the correct datacenter is determined by querying the metadata OAuth URI of mailchimp)
        /// </summary>
        public string Datacenter { get; set; }

        #endregion

        #region Contructors

        public MailChimpManager(string apiKey)
        {
            APIKey = apiKey;
            if (string.IsNullOrEmpty(Datacenter))
            {
                throw new ArgumentException("Datacenter suffix not available in supplied api key");
            }
        }

        /// <summary>
        /// Create an instance of the wrapper, used for access token retrieved via OAuth
        /// </summary>
        /// <param name="accessToken">Access token obtained via OAuth application connection</param>
        /// <param name="datacenter">Datacenter obtained via OAuth metadata call</param>
        public MailChimpManager(string accessToken, string datacenter)
        {
            APIKey = accessToken;
            Datacenter = datacenter;
        }

        #endregion

        #region Public Methods

        public ListsCollection GetLists()
        {
            try
            {
                return MakeAPICall<ListsCollection>("lists", Method.GET, null);
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public ListsInstance AddList(ListsInstance list)
        {
            string body = SerializeAPIRequestBody(list);

            return MakeAPICall<ListsInstance>("lists", Method.POST, body);
        }

        public MembersInstance AddMember(string listId, MembersInstance member)
        {
            string body = SerializeAPIRequestBody(member);

            return MakeAPICall<MembersInstance>(string.Format("lists/{0}/members", listId), Method.POST, body);
        }

        public MergeFieldsInstance AddMergeField(string listId, MergeFieldsInstance mergeField)
        {
            string body = SerializeAPIRequestBody(mergeField);

            return MakeAPICall<MergeFieldsInstance>(string.Format("lists/{0}/merge-fields", listId), Method.POST, body);
        }

        public TemplatesCollection GetTemplates()
        {
            try
            {
                return MakeAPICall<TemplatesCollection>("templates", Method.GET, null);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private static string SerializeAPIRequestBody(object toSerialize)
        {
            return JsonConvert.SerializeObject(toSerialize, Formatting.None,
                new JsonSerializerSettings()
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    Converters = new List<JsonConverter>() {new StringEnumConverter() {CamelCaseText = true}}
                });
        }

        public MembersInstance UpdateMember(string listId, MembersInstance member)
        {
            string body = SerializeAPIRequestBody(member);

            return MakeAPICall<MembersInstance>(string.Format("lists/{0}/members/{1}", listId, Utility.GetMd5Hash(member.EmailAddress)), Method.PATCH, body);
        }

        #endregion

        #region Generic API calling method

        private T MakeAPICall<T>(string action, Method method, string body)
        {
            var client = new RestClient(GetBaseUrl());
            if (IsPlainAPIKey)
            {
                client.Authenticator = new HttpBasicAuthenticator("APIKey", APIKey);
            }
            else
            {
                client.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(APIKey); // standard tokenType "OAuth" suffices
            }

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
            return string.Format("{0}://{1}.{2}/{3}/", APIProtocol, Datacenter, BaseAPIUrl, APIVersion);
        }
        #endregion
    }
}
