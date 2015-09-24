using System;
using System.Runtime.Serialization;

namespace MailChimp.DTOs
{
    /// <summary>
    /// "AB Split Options - AB Split-specific options for a campaign.
    /// https://api.mailchimp.com/schema/3.0/Campaigns/Instance.json
    /// </summary>
    [DataContract]
    public class AbSplitOpts
    {
        [DataMember(Name = "split_test")]
        public string SplitTest { get; set; }

        [DataMember(Name = "pick_winner")]
        public string PickWinner { get; set; }

        [DataMember(Name = "wait_units")]
        public string WaitUnits { get; set; }

        [DataMember(Name = "wait_time")]
        public int? WaitTime { get; set; }

        [DataMember(Name = "split_size")]
        public int? SplitSize { get; set; }

        [DataMember(Name = "from_name_a")]
        public string FromNameA { get; set; }

        [DataMember(Name = "from_name_b")]
        public string FromNameB { get; set; }

        [DataMember(Name = "reply_email_a")]
        public string ReplyEmailA { get; set; }

        [DataMember(Name = "reply_email_b")]
        public string ReplyEmailB { get; set; }

        [DataMember(Name = "subject_a")]
        public string SubjectA { get; set; }

        [DataMember(Name = "subject_b")]
        public string SubjectB { get; set; }

        [DataMember(Name = "send_time_a")]
        public DateTime? SendTimeA { get; set; }

        [DataMember(Name = "send_time_b")]
        public DateTime? SendTimeB { get; set; }

        [DataMember(Name = "send_time_winner")]
        public DateTime? SendTimeWinner { get; set; }
    }
}
