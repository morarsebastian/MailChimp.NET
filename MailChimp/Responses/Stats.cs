using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Responses
{
    [DataContract]
    public class Stats
    {
        [DataMember(Name = "member_count")]
        public int MemberCount { get; set; }

        [DataMember(Name = "unsubscribe_count")]
        public int UnsubscribeCount { get; set; }

        [DataMember(Name = "cleaned_count")]
        public int CleanedCount { get; set; }

        [DataMember(Name = "member_count_since_send")]
        public int MemberCountSinceSend { get; set; }

        [DataMember(Name = "unsubscribe_count_since_send")]
        public int UnsubscribeSountSinceSend { get; set; }

        [DataMember(Name = "cleaned_count_since_send")]
        public int CleanedCountSinceSend { get; set; }

        [DataMember(Name = "campaign_count")]
        public int CampaignCount { get; set; }

        [DataMember(Name = "campaign_last_sent")]
        public DateTime? CampaignLastSent { get; set; }

        [DataMember(Name = "merge_field_count")]
        public int MergeFieldCount { get; set; }

        [DataMember(Name = "avg_sub_rate")]
        public int AvgSubRate { get; set; }

        [DataMember(Name = "avg_unsub_rate")]
        public int AvgUnsubRatent { get; set; }

        [DataMember(Name = "target_sub_rate")]
        public int TargetSubRate { get; set; }

        [DataMember(Name = "open_rate")]
        public int OpenRate { get; set; }

        [DataMember(Name = "click_rate")]
        public int ClickRate { get; set; }

        [DataMember(Name = "last_sub_date")]
        public DateTime? LastSubDate { get; set; }

        [DataMember(Name = "last_unsub_date")]
        public DateTime? LastUnsubDate { get; set; }
    }
}
