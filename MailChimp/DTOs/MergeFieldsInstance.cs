using System.Runtime.Serialization;

namespace MailChimp.DTOs
{
    /// <summary>
    /// Merge Field - A merge field (formerly merge vars) for a specific list. These correspond to merge fields in MailChimp's lists and subscriber profiles.
    /// https://us9.api.mailchimp.com/schema/3.0/Lists/MergeFields/Instance.json
    /// </summary>
    [DataContract]
    public class MergeFieldsInstance
    {
        [DataMember(Name = "merge_id")]
        public int? MergeId { get; set; }
        
        [DataMember(Name = "tag")]
        public string Tag { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Any of: text, number, address, phone, email, date, url, imageurl, radio, dropdown, checkboxes, birthday, zip
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; set; }
    
        [DataMember(Name = "required")]
        public bool? Required { get; set; }

        [DataMember(Name = "default_value")]
        public string DefaultValue { get; set; }
    
        [DataMember(Name = "public")]
        public bool? Public { get; set; }

        [DataMember(Name = "display_order")]
        public int? DisplayOrder { get; set; }

        [DataMember(Name = "options")]
        public object Options { get; set; }
      
        [DataMember(Name = "help_text")]
        public string HelpText { get; set; }

        [DataMember(Name = "list_id")]
        public string ListId { get; set; }

        /// <summary>
        /// Address object useable as a member merge field
        /// </summary>
        [DataContract]
        public class Address
        {
            /// <summary>
            /// Address1 - required
            /// </summary>
            [DataMember(Name = "addr1")]
            public string Address1 { get; set; }

            /// <summary>
            /// Address2 - optional
            /// </summary>
            [DataMember(Name = "addr2")]
            public string Address2 { get; set; }

            /// <summary>
            /// City - required
            /// </summary>
            [DataMember(Name = "city")]
            public string City { get; set; }

            /// <summary>
            /// State - required
            /// </summary>
            [DataMember(Name = "state")]
            public string State { get; set; }

            /// <summary>
            /// Zip - required
            /// </summary>
            [DataMember(Name = "zip")]
            public string Zip { get; set; }

            /// <summary>
            /// Country - required
            /// </summary>
            [DataMember(Name = "country")]
            public string Country { get; set; }

            /// <summary>
            /// Phone - optional
            /// </summary>
            [DataMember(Name = "phone")]
            public string Phone { get; set; }
        }
    }
}
