using MailChimp.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;


namespace MailChimpTest
{
    [DataContract]
    public class MergeFields : IMergeFields
    {
        [DataMember(Name = "FNAME")]
        public string FirstName { get; set; }

        [DataMember(Name = "LNAME")]
        public string LastName { get; set; }
    }
}
