using System.Runtime.Serialization;

namespace MailChimp.DTOs
{
    /// <summary>
    /// Campaign Settings
    /// https://api.mailchimp.com/schema/3.0/Campaigns/Instance.json
    /// </summary>
    [DataContract]
    public class Settings
    {
        [DataMember(Name = "subject_line")]
        public string SubjectLine { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "from_name")]
        public string FromName { get; set; }

        [DataMember(Name = "reply_to")]
        public string ReplyTo { get; set; }

        [DataMember(Name = "use_conversation")]
        public bool? UseConversation { get; set; }

        [DataMember(Name = "to_name")]
        public string ToName { get; set; }

        [DataMember(Name = "folder_id")]
        public int? FolderId { get; set; }

        [DataMember(Name = "authenticate")]
        public bool? Authenticate { get; set; }

        [DataMember(Name = "auto_footer")]
        public bool? AutoFooter { get; set; }

        [DataMember(Name = "inline_css")]
        public bool? InlineCss { get; set; }

        [DataMember(Name = "auto_tweet")]
        public bool? AutoTweet { get; set; }

        [DataMember(Name = "auto_fb_post")]
        public bool? AutoFbPost { get; set; }

        [DataMember(Name = "fb_comments")]
        public bool? FbComments { get; set; }

        [DataMember(Name = "timewarp")]
        public bool? Timewarp { get; set; }

        [DataMember(Name = "template_id")]
        public int? TemplateId { get; set; }

        [DataMember(Name = "drag_and_drop")]
        public bool? DragAndDrop { get; set; }
    }
}
