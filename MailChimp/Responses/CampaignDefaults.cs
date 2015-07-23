using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Responses
{
    [DataContract]
    public class CampaignDefaults
    {
        [DataMember(Name = "from_name")]
        public string FromName { get; set; }

        [DataMember(Name = "from_email")]
        public string FromEmail { get; set; }

        [DataMember(Name = "subject")]
        public string Subject { get; set; }

        [DataMember(Name = "language")]
        public string Language { get; set; }
    }
}
