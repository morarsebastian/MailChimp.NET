using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.DTOs
{
    /// <summary>
    /// Information about a specific list.
    /// https://us11.api.mailchimp.com/schema/3.0/Lists/Instance.json
    /// </summary>
    [DataContract]
    public class ListsInstance
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "contact")]
        public Contact Contact { get; set; }

        [DataMember(Name = "permission_reminder")]
        public string PermissionReminder { get; set; }

        [DataMember(Name = "use_archive_bar")]
        public bool? UseArchiveBar { get; set; }

        [DataMember(Name = "campaign_defaults")]
        public CampaignDefaults CampaignDefaults { get; set; }

        [DataMember(Name = "notify_on_subscribe")]
        public string NotifyOnSubscribe { get; set; }

        [DataMember(Name = "date_created")]
        public DateTime? DateCreated { get; set; }

        [DataMember(Name = "list_rating")]
        public int? ListRating { get; set; }

        [DataMember(Name = "email_type_option")]
        public bool EmailTypeOption { get; set; }

        [DataMember(Name = "subscribe_url_short")]
        public string SubscribeUrlShort { get; set; }

        [DataMember(Name = "subscribe_url_long")]
        public string SubscribeUrlLong { get; set; }

        [DataMember(Name = "beamer_address")]
        public string BeamerAddress { get; set; }

        [DataMember(Name = "visibility")]
        public string Visibility { get; set; }

        [DataMember(Name = "modules")]
        public List<Module> Modules { get; set; }

        [DataMember(Name = "stats")]
        public Stats Stats { get; set; }

        [DataMember(Name = "_links")]
        public List<ResourceLink> Links { get; set; }
    }
}
