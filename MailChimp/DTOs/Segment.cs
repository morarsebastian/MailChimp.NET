using System.Runtime.Serialization;

namespace MailChimp.DTOs
{
    /// <summary>
    /// Segment - A segment used to filter subscribers.
    /// https://api.mailchimp.com/schema/3.0/Lists/Segments/Segment.json
    /// </summary>
    [DataContract]
    public class Segment
    {
        [DataMember(Name = "field")]
        public string Field { get; set; }

        [DataMember(Name = "op")]
        public string Op { get; set; }

        [DataMember(Name = "value")]
        public string Value { get; set; }
    }
}
