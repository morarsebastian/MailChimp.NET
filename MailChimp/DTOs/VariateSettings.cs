using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.DTOs
{
    /// <summary>
    /// A/B Test Options - The settings specific to A/B test campaigns
    /// https://api.mailchimp.com/schema/3.0/Campaigns/Instance.json
    /// </summary>
    [DataContract]
    public class VariateSettings
    {
        [DataMember(Name = "winning_combination_id")]
        public string WinningCombinationId { get; set; }

        [DataMember(Name = "winning_campaign_id")]
        public string WinningCampaignId { get; set; }

        [DataMember(Name = "subject_lines")]
        public List<string> SubjectLines { get; set; }

        [DataMember(Name = "send_times")]
        public List<DateTime> SendTimes { get; set; }

        [DataMember(Name = "from_names")]
        public List<string> FromNames { get; set; }

        [DataMember(Name = "reply_to_addresses")]
        public List<string> ReplyToAddresses { get; set; }

        [DataMember(Name = "contents")]
        public List<string> Contents { get; set; }

        [DataMember(Name = "combinations")]
        public List<Combinations> Combinations { get; set; }


    }
}
