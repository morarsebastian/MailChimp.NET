using System.Runtime.Serialization;

namespace MailChimp.DTOs
{
    /// <summary>
    /// List Contact - displayed in campaign footers to comply with international spam laws
    /// https://api.mailchimp.com/schema/3.0/Lists/Instance.json
    /// </summary>
    [DataContract]
    public class Contact
    {
        [DataMember(Name = "company")]
        public string Company { get; set; }

        [DataMember(Name = "address1")]
        public string Address1 { get; set; }

        [DataMember(Name = "address2")]
        public string Address2 { get; set; }

        [DataMember(Name = "city")]
        public string City { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }

        [DataMember(Name = "zip")]
        public string Zip { get; set; }

        [DataMember(Name = "country")]
        public string Country { get; set; }

        [DataMember(Name = "phone")]
        public string Phone { get; set; }
    }
}
