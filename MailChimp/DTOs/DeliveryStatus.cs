using System.Runtime.Serialization;

namespace MailChimp.DTOs
{
    /// <summary>
    /// Campaign Delivery Status - Updates on campaigns in the process of sending.
    /// https://api.mailchimp.com/schema/3.0/Campaigns/Delivery.json
    /// </summary>
    [DataContract]
    public class DeliveryStatus
    {
        [DataMember(Name = "enabled")]
        public bool? Enabled { get; set; }

        [DataMember(Name = "can_cancel")]
        public bool? CanCancel { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "emails_sent")]
        public int? EmailsSent { get; set; }

        [DataMember(Name = "emails_canceled")]
        public int? EmailsCanceled { get; set; }
    }
}
