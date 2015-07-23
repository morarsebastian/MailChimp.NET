using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Responses
{
    [DataContract]
    public class SubscriberResult
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "email_address")]
        public string EmailAddress { get; set; }

        [DataMember(Name = "unique_email_id")]
        public string unique_email_id { get; set; }

        [DataMember(Name = "email_type")]
        public string EmailType { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

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
        public int MemberRating { get; set; }

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
        public List<Link> Links { get; set; }
    }

    [DataContract]
    public class MergeFields
    {
        [DataMember(Name = "FNAME")]
        public string FirstName { get; set; }

        [DataMember(Name = "LNAME")]
        public string LastName { get; set; }
    }
}
