using System.Runtime.Serialization;

namespace MailChimp.DTOs
{
    /// <summary>
    /// Sending Schedule - The schedule for sending the RSS campaign.
    /// https://api.mailchimp.com/schema/3.0/Campaigns/Instance.json
    /// </summary>
    [DataContract]
    public class DailySend
    {
        [DataMember(Name = "sunday")]
        public bool? Sunday { get; set; }

        [DataMember(Name = "monday")]
        public bool? Monday { get; set; }

        [DataMember(Name = "tuesday")]
        public bool? Tuesday { get; set; }

        [DataMember(Name = "wednesday")]
        public bool? Wednesday { get; set; }

        [DataMember(Name = "thursday")]
        public bool? Thursday { get; set; }

        [DataMember(Name = "friday")]
        public bool? Friday { get; set; }

        [DataMember(Name = "saturday")]
        public bool? Saturday { get; set; }
    }
}
