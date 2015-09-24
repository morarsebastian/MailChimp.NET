using System.Runtime.Serialization;

namespace MailChimp.DTOs
{
    /// <summary>
    /// List - List settings for the campaign.
    /// https://api.mailchimp.com/schema/3.0/Campaigns/Instance.json
    /// </summary>
    [DataContract]
    public class Recipients
    {
        [DataMember(Name = "list_id")]
        public string ListId { get; set; }

        [DataMember(Name = "segment_text")]
        public string SegmentText { get; set; }

        [DataMember(Name = "segment_opts")]
        public SegmentOpts SegmentOpts { get; set; }
    }
}
