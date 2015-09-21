using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Web.UI;

namespace MailChimp.DTOs
{
    /// <summary>
    /// Result of the 'templates' operation:
    /// Templates - A list an account's available templates.
    /// https://api.mailchimp.com/schema/3.0/Templates/Collection.json
    /// </summary>
    [DataContract]
    public class TemplatesCollection
    {
        [DataMember(Name = "templates")]
        public List<TemplatesInstance> Templates { get; set; }

        [DataMember(Name = "total_items")]
        public int TotalItems { get; set; }

        [DataMember(Name = "_links")]
        public List<ResourceLink> Links { get; set; }
    }
}
