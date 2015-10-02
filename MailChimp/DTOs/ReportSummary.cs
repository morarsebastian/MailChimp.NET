using System.Runtime.Serialization;

namespace MailChimp.DTOs
{
    /// <summary>
    /// Campaign Report Summary - For sent campaigns, a summary of opens, clicks, and unsubscribes.
    /// https://api.mailchimp.com/schema/3.0/Campaigns/Report.json
    /// </summary>
    [DataContract]
    public class ReportSummary
    {
        [DataMember(Name = "opens")]
        public int? Opens { get; set; }

        [DataMember(Name = "unique_opens")]
        public int? UniqueOpens { get; set; }

        [DataMember(Name = "open_rate")]
        public decimal? OpenRate { get; set; }

        [DataMember(Name = "clicks")]
        public int? Clicks { get; set; }

        [DataMember(Name = "subscriber_clicks")]
        public int? SubscriberClicks { get; set; }

        [DataMember(Name = "click_rate")]
        public decimal? ClickRate { get; set; }
    }
}
