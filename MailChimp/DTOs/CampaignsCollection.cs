using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.DTOs
{
    /// <summary>
    /// Campaign Reports - A summary of the campaigns within an account.
    /// https://api.mailchimp.com/schema/3.0/Campaigns/Collection.json
    /// </summary>
    [DataContract]
    public class CampaignsCollection
    {
        [DataMember(Name = "campaigns")]
        public List<CampaignsInstance> Campaigns { get; set; }

        [DataMember(Name = "total_items")]
        public int TotalItems { get; set; }

        [DataMember(Name = "_links")]
        public List<ResourceLink> Links { get; set; }
    }
}
