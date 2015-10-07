using System.Runtime.Serialization;

namespace MailChimp.DTOs
{
    /// <summary>
    /// Location - Subscriber location information.
    /// https://api.mailchimp.com/schema/3.0/Lists/Members/Instance.json
    /// </summary>
    [DataContract]
    public class Location
    {
        [DataMember(Name = "latitude")]
        public decimal? Latitude { get; set; }

        [DataMember(Name = "longitude")]
        public decimal? Longitude { get; set; }

        [DataMember(Name = "gmtoff")]
        public int? Gmtoff { get; set; }

        [DataMember(Name = "dstoff")]
        public int? Dstoff { get; set; }

        [DataMember(Name = "country_code")]
        public string CountryCode { get; set; }

        [DataMember(Name = "timezone")]
        public string Timezone { get; set; }
    }
}
