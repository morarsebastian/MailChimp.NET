using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.DTOs
{
    /// <summary>
    /// Segment Options - Segment options.
    /// https://api.mailchimp.com/schema/3.0/Campaigns/Instance.json
    /// </summary>
    [DataContract]
    public class SegmentOpts
    {
        [DataMember(Name = "saved_segment_id")]
        public int? SavedSegmentId { get; set; }

        [DataMember(Name = "match")]
        public string Match { get; set; }

        [DataMember(Name = "conditions")]
        public List<Segment> Conditions { get; set; }
    }
}
