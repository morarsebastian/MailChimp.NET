using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.Responses
{
    /// <summary>
    /// Result of the 'lists' operation
    /// </summary>
    [DataContract]
    public class ListResult
    {
        [DataMember(Name = "lists")]
        public List<ListInfo> Lists { get; set; }

        [DataMember(Name = "total_items")]
        public int TotalItems { get; set; }

        [DataMember(Name = "_links")]
        public List<Link> Links { get; set; }
    }
}
