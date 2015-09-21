using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.DTOs
{
    /// <summary>
    /// Template Instance - Information about a specific template.
    /// https://api.mailchimp.com/schema/3.0/Templates/Instance.json
    /// </summary>
    [DataContract]
    public class TemplatesInstance
    {
        [DataMember(Name = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Template Type - The type of template (user, base, or gallery).
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "drag_and_drop")]
        public bool? DragAndDrop { get; set; }

        [DataMember(Name = "responsive")]
        public bool? Responsive { get; set; }

        [DataMember(Name = "category")]
        public string Category { get; set; }
        
        [DataMember(Name = "date_created")]
        public DateTime? DateCreated { get; set; }

        [DataMember(Name = "created_by")]
        public string CreatedBy { get; set; }

        [DataMember(Name = "active")]
        public bool? Active { get; set; }

        [DataMember(Name = "folder_id")]
        public int? FolderId { get; set; }

        [DataMember(Name = "thumbnail")]
        public string Thumbnail { get; set; }

        [DataMember(Name = "share_url")]
        public string ShareUrl { get; set; }
        
        [DataMember(Name = "_links")]
        public List<ResourceLink> Links { get; set; }
    }
}
