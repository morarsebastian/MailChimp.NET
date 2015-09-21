using System;
using System.Collections.Generic;
using MailChimp;
using MailChimp.DTOs;
using RestSharp;

namespace MailChimpTest
{
    class CustomMailChimpManager: MailChimpManager
    {
        public CustomMailChimpManager(string accessToken, string datacenter) : base(accessToken, datacenter)
        {
        }
        public CustomMailChimpManager(string apiKey)
            : base(apiKey)
        {
        }

        /// <summary>
        /// Get templates with just the id and name properties filled
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="count"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public TemplatesCollection GetTemplatesLight(int? offset = null, int? count = null, TemplatesInstance filter = null)
        {
            try
            {
                return MakeAPICall<TemplatesCollection>("templates", Method.GET, null, offset, count, filter, new List<string>
                {
                    "templates.id", "templates.name"
                });
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
