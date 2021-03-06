﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Error
{
    [DataContract]
    public class Error
    {
        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "status")]
        public int Status { get; set; }

        [DataMember(Name = "detail")]
        public string Detail { get; set; }

        [DataMember(Name = "errors")]
        public List<ErrorInfo> ErrorsDetails { get; set; }
    }

    public class ErrorInfo
    {
        [DataMember(Name = "field")]
        public string Field { get; set; }

        [DataMember(Name = "message")]
        public string Message { get; set; }
    }
}
