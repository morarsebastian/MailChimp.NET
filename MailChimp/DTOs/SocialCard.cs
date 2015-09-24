using System.Runtime.Serialization;

namespace MailChimp.DTOs
{
    /// <summary>
    /// Campaign Social Card - "The preview for the campaign as rendered by social networks like Facebook and Twitter.
    /// https://api.mailchimp.com/schema/3.0/Campaigns/Instance.json
    /// </summary>
    [DataContract]
    public class SocialCard
    {
        [DataMember(Name = "image_url")]
        public string ImageUrl { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }
    }
}
