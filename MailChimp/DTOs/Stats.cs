using System;
using System.Runtime.Serialization;

namespace MailChimp.DTOs
{
    /// <summary>
    /// Statistics - Various stats and counts for a list. Many of these are cached for at least five minutes.
    /// https://api.mailchimp.com/schema/3.0/Lists/Instance.json
    /// </summary>
    [DataContract]
    public class Stats
    {
        [DataMember(Name = "member_count")]
        public int? MemberCount { get; set; }

        [DataMember(Name = "unsubscribe_count")]
        public int? UnsubscribeCount { get; set; }

        [DataMember(Name = "cleaned_count")]
        public int? CleanedCount { get; set; }

        [DataMember(Name = "member_count_since_send")]
        public int? MemberCountSinceSend { get; set; }

        [DataMember(Name = "unsubscribe_count_since_send")]
        public int? UnsubscribeSountSinceSend { get; set; }

        [DataMember(Name = "cleaned_count_since_send")]
        public int? CleanedCountSinceSend { get; set; }

        [DataMember(Name = "campaign_count")]
        public int? CampaignCount { get; set; }

        [DataMember(Name = "campaign_last_sent")]
        public DateTime? CampaignLastSent { get; set; }

        [DataMember(Name = "merge_field_count")]
        public int? MergeFieldCount { get; set; }

        [DataMember(Name = "avg_sub_rate")]
        public decimal? AvgSubRate { get; set; }

        [DataMember(Name = "avg_unsub_rate")]
        public decimal? AvgUnsubRate { get; set; }

        [DataMember(Name = "target_sub_rate")]
        public decimal? TargetSubRate { get; set; }

        [DataMember(Name = "open_rate")]
        public decimal? OpenRate { get; set; }

        [DataMember(Name = "click_rate")]
        public decimal? ClickRate { get; set; }

        [DataMember(Name = "last_sub_date")]
        public DateTime? LastSubDate { get; set; }

        [DataMember(Name = "last_unsub_date")]
        public DateTime? LastUnsubDate { get; set; }
    }
}
