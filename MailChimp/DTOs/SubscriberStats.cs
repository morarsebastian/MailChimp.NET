using System.Runtime.Serialization;

namespace MailChimp.DTOs
{
    /// <summary>
    /// Subscriber Stats - General open rates for a subscriber.
    /// https://us11.api.mailchimp.com/schema/3.0/Lists/Members/Instance.json
    /// </summary>
    [DataContract]
    public class SubscriberStats
    {
        [DataMember(Name = "avg_open_rate")]
        public int AvgOpenRate { get; set; }

        [DataMember(Name = "avg_click_rate")]
        public int AvgClickRate { get; set; }
    }
}
