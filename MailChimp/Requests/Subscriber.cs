using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Requests
{
    [DataContract]
    public class Subscriber
    {
        [DataMember(Name = "email_address")]
        public string EmailAddress { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "merge_fields")]
        public MergeFields MergeFields { get; set; }

        public Subscriber(string emailAddress, string status, string firstName, string lastName)
        {
            this.EmailAddress = emailAddress;
            this.Status = status;
            this.MergeFields = new MergeFields()
            {
                FirstName = firstName,
                LastName = lastName
            };
        }
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
