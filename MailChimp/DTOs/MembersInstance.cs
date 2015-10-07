using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.DTOs
{
    /// <summary>
    /// List Members - Individuals who are currently or have been previously suscribed to this list, including members who have bounced or unsubscribed.
    /// https://api.mailchimp.com/schema/3.0/Lists/Members/Instance.json
    /// </summary>
    [DataContract]
    public class MembersInstance
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "email_address")]
        public string EmailAddress { get; set; }

        [DataMember(Name = "unique_email_id")]
        public string unique_email_id { get; set; }

        [DataMember(Name = "email_type")]
        public string EmailType { get; set; }

        public enum StatusEnum
        {
            Subscribed,
            Unsubscribed,
            Cleaned,
            Pending
        }

        [DataMember(Name = "status")]
        public StatusEnum? Status { get; set; }

        [DataMember(Name = "merge_fields")]
        public MergeFields MergeFields { get; set; }

        [DataMember(Name = "stats")]
        public SubscriberStats Stats { get; set; }

        [DataMember(Name = "ip_signup")]
        public string IpSignup { get; set; }

        [DataMember(Name = "timestamp_signup")]
        public DateTime? TimestampSignup { get; set; }

        [DataMember(Name = "ip_opt")]
        public string IpOpt { get; set; }

        [DataMember(Name = "timestamp_opt")]
        public DateTime TimestampOpt { get; set; }

        [DataMember(Name = "member_rating")]
        public int? MemberRating { get; set; }

        [DataMember(Name = "last_changed")]
        public DateTime LastChanged { get; set; }

        [DataMember(Name = "language")]
        public string Language { get; set; }

        [DataMember(Name = "vip")]
        public bool Vip { get; set; }

        [DataMember(Name = "email_client")]
        public string EmailClient { get; set; }

        [DataMember(Name = "location")]
        public Location Location { get; set; }

        [DataMember(Name = "list_id")]
        public string ListId { get; set; }

        [DataMember(Name = "_links")]
        public List<ResourceLink> Links { get; set; }

        public MembersInstance()
        {
        }

        public MembersInstance(string emailAddress): this(emailAddress, StatusEnum.Subscribed)
        {
        }

        public MembersInstance(string emailAddress, StatusEnum status)
        {
            EmailAddress = emailAddress.ToLowerInvariant();
            Status = status;
        }

        public MembersInstance(string emailAddress, StatusEnum status, string firstName, string lastName)
            : this(emailAddress, status)
        {
            MergeFields = new MergeFields() {FirstName = firstName, LastName = lastName};
        }
    }
}
