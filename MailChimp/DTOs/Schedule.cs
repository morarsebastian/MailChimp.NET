using System.Runtime.Serialization;

namespace MailChimp.DTOs
{
    /// <summary>
    /// Sending Schedule - The schedule for sending the RSS campaign.
    /// https://api.mailchimp.com/schema/3.0/Campaigns/Instance.json
    /// </summary>
    [DataContract]
    public class Schedule
    {
        [DataMember(Name = "hour")]
        public int? Hour { get; set; }

        [DataMember(Name = "daily_send")]
        public DailySend DailySend { get; set; }

        [DataMember(Name = "weekly_send_day")]
        public string WeeklySendDay { get; set; }

        [DataMember(Name = "monthly_send_date")]
        public int? MonthlySendDate { get; set; }
    }
}
