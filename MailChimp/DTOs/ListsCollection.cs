using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.DTOs
{
    /// <summary>
    /// Result of the 'lists' operation:
    /// Subscriber Lists - A collection of subscriber lists associated with this account. Lists contain subscribers who have opted-in to receive correspondence from you or your organization.
    /// https://api.mailchimp.com/schema/3.0/Lists/Collection.json
    /// </summary>
    [DataContract]
    public class ListsCollection
    {
        [DataMember(Name = "lists")]
        public List<ListsInstance> Lists { get; set; }

        [DataMember(Name = "total_items")]
        public int TotalItems { get; set; }

        [DataMember(Name = "_links")]
        public List<ResourceLink> Links { get; set; }
    }
}
