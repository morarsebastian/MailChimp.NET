using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Responses
{
    [DataContract]
    public class Location
    {
        [DataMember(Name = "latitude")]
        public decimal Latitude { get; set; }

        [DataMember(Name = "longitude")]
        public decimal Longitude { get; set; }

        [DataMember(Name = "gmtoff")]
        public int Gmtoff { get; set; }

        [DataMember(Name = "dstoff")]
        public int Dstoff { get; set; }

        [DataMember(Name = "country_code")]
        public string CountryCode { get; set; }

        [DataMember(Name = "timezone")]
        public string Timezone { get; set; }
    }
}
