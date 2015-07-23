using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Responses
{
    [DataContract]
    public class SubscriberStats
    {
        [DataMember(Name = "avg_open_rate")]
        public int AvgOpenRate { get; set; }

        [DataMember(Name = "avg_click_rate")]
        public int AvgClickRate { get; set; }
    }
}
