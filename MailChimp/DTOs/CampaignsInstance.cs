using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.DTOs
{
    /// <summary>
    /// Campaign - A summary of an individual campaign's settings and content.
    /// https://api.mailchimp.com/schema/3.0/Campaigns/Instance.json
    /// </summary>
    [DataContract]
    public class CampaignsInstance
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "create_time")]
        public DateTime? CreateTime { get; set; }

        [DataMember(Name = "archive_url")]
        public string ArchiveUrl { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "emails_sent")]
        public int? EmailsSent { get; set; }

        [DataMember(Name = "send_time")]
        public DateTime? SendTime { get; set; }

        [DataMember(Name = "content_type")]
        public string ContentType { get; set; }

        [DataMember(Name = "recipients")]
        public Recipients Recipients { get; set; }

        [DataMember(Name = "settings")]
        public Settings Settings { get; set; }

        [DataMember(Name = "variate_settings")]
        public VariateSettings VariateSettings { get; set; }

        [DataMember(Name = "tracking")]
        public Tracking Tracking { get; set; }

        [DataMember(Name = "rss_opts")]
        public RssOpts RssOpts { get; set; }

        [DataMember(Name = "ab_split_opts")]
        public AbSplitOpts AbSplitOpts { get; set; }

        [DataMember(Name = "social_card")]
        public SocialCard SocialCard { get; set; }

        [DataMember(Name = "report_summary")]
        public ReportSummary ReportSummary { get; set; }

        [DataMember(Name = "delivery_status")]
        public DeliveryStatus DeliveryStatus { get; set; }

        [DataMember(Name = "_links")]
        public List<ResourceLink> Links { get; set; }   
    }
}
