using System;
using System.Runtime.Serialization;

namespace MailChimp.DTOs
{
    /// <summary>
    /// RSS Options - RSS-specific options for a campaign.
    /// https://api.mailchimp.com/schema/3.0/Campaigns/Instance.json
    /// </summary>
    [DataContract]
    public class RssOpts
    {
        [DataMember(Name = "feed_url")]
        public string FeedUrl { get; set; }

        [DataMember(Name = "frequency")]
        public string Frequency { get; set; }

        [DataMember(Name = "schedule")]
        public Schedule Schedule { get; set; }

        [DataMember(Name = "last_sent")]
        public DateTime? LastSent { get; set; }
    }
}
