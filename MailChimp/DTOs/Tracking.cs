using System.Runtime.Serialization;

namespace MailChimp.DTOs
{
    /// <summary>
    /// Campiagn Tracking Options - The tracking options for a campaign.
    /// https://api.mailchimp.com/schema/3.0/Campaigns/Instance.json
    /// </summary>
    [DataContract]
    public class Tracking
    {
        [DataMember(Name = "opens")]
        public bool? Opens { get; set; }

        [DataMember(Name = "html_clicks")]
        public bool? HtmlClicks { get; set; }

        [DataMember(Name = "text_clicks")]
        public bool? TextClicks { get; set; }

        [DataMember(Name = "goal_tracking")]
        public bool? GoalTracking { get; set; }

        [DataMember(Name = "ecomm360")]
        public bool? Ecomm360 { get; set; }

        [DataMember(Name = "google_analytics")]
        public bool? GoogleAnalytics { get; set; }

        [DataMember(Name = "clicktale")]
        public bool? Clicktale { get; set; }

        [DataMember(Name = "salesforce")]
        public Salesforce Salesforce { get; set; }

        [DataMember(Name = "highrise")]
        public Highrise Highrise { get; set; }

        [DataMember(Name = "capsule")]
        public Capsule Capsule { get; set; }
    }
}
