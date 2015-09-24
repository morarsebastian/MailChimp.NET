using System.Runtime.Serialization;

namespace MailChimp.DTOs
{
    // <summary>
    /// Combinations - Combinations of possible variables that were used to build emails
    /// https://api.mailchimp.com/schema/3.0/Campaigns/Instance.json
    /// </summary>
    [DataContract]
    public class Combinations
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "subject_line")]
        public int? SubjectLine { get; set; }

        [DataMember(Name = "send_time")]
        public int? SendTime { get; set; }

        [DataMember(Name = "from_name")]
        public int? FromName { get; set; }

        [DataMember(Name = "reply_to")]
        public int? ReplyTo { get; set; }

        [DataMember(Name = "content_description")]
        public int? ContentDescription { get; set; }

        [DataMember(Name = "recipients")]
        public int? Recipients { get; set; }
    }
}
