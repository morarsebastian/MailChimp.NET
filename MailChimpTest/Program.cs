using System;
using MailChimp;
using MailChimp.DTOs;
using MailChimp.Error;

namespace MailChimpTest
{
    class Program
    {
        static void GetLists(MailChimpManager mailChimp)
        {
            // Get the subscriber lists
            ListsCollection lists = mailChimp.GetLists();
            Console.WriteLine("Got {0} out of {1} lists", lists.Lists.Count, lists.TotalItems);
        }

        static void CreateListAddMember(MailChimpManager mailChimp)
        {
            var list = mailChimp.AddList(new ListsInstance()
            {
                Name = "Test list " + DateTime.Now,
                Contact = new Contact()
                {
                    Company = "Test company",
                    Address1 = "675 Ponce de Leon Ave NE",
                    City = "Atlanta",
                    Country = "US",
                    State = "Georgia",
                    Zip = "GA 30308"
                },
                PermissionReminder = "You subscribed to our newsletter.",
                CampaignDefaults = new CampaignDefaults()
                {
                    FromEmail = "testsender@yourdomain.com",
                    FromName = "Freddie",
                    Subject = "Test subject",
                    Language = "en"
                },
                EmailTypeOption = false
            });
            Console.WriteLine("Created list \"{0}\", id {1}", list.Name, list.Id);

            var subscriber = new MembersInstance(string.Format("testaddress+{0}@yourdomain.com", "test"), MembersInstance.StatusEnum.Subscribed, "John", "Doe");

            // Add a customer to list
            subscriber = mailChimp.AddMember(list.Id, subscriber);

            Console.WriteLine("Member {0} added to list, id {1}", subscriber.EmailAddress, subscriber.Id);

            subscriber.MergeFields.FirstName = subscriber.MergeFields.FirstName + " F.";
            subscriber = mailChimp.UpdateMember(list.Id, subscriber);

            Console.WriteLine("Member {0} updated, \"{1} {2}\" @{3}", subscriber.EmailAddress, subscriber.MergeFields.FirstName, subscriber.MergeFields.LastName, subscriber.LastChanged);
        }

        static void CreateListAddMemberCustomMergefields(MailChimpManager mailChimp)
        {
            var list = mailChimp.AddList(new ListsInstance()
            {
                Name = "Test list (custom merge fields) " + DateTime.Now,
                Contact = new Contact()
                {
                    Company = "Test company",
                    Address1 = "675 Ponce de Leon Ave NE",
                    City = "Atlanta",
                    Country = "US",
                    State = "Georgia",
                    Zip = "GA 30308"
                },
                PermissionReminder = "You subscribed to our newsletter.",
                CampaignDefaults = new CampaignDefaults()
                {
                    FromEmail = "testsender@yourdomain.com",
                    FromName = "Freddie",
                    Subject = "Test subject",
                    Language = "en"
                },
                EmailTypeOption = false
            });
            Console.WriteLine("Created list \"{0}\", id {1}", list.Name, list.Id);

            var mergeFieldSalutation = mailChimp.AddMergeField(list.Id, new MergeFieldsInstance()
            {
                Name = "Salutation",
                Tag = "SALUTATION",
                Type = "text"
            });
            Console.WriteLine("Added merge field for salutation, id {0}", mergeFieldSalutation.MergeId);

            var mergeFieldAddress = mailChimp.AddMergeField(list.Id, new MergeFieldsInstance()
            {
                Name = "Address",
                Tag = "ADDRESS",
                Type = "address"
            });
            Console.WriteLine("Added merge field for address, id {0}", mergeFieldAddress.MergeId);

            var subscriber = new MembersInstance(string.Format("testaddress+{0}@yourdomain.com", "test"), MembersInstance.StatusEnum.Subscribed, "John", "Doe");
            subscriber.MergeFields.AddOrUpdateVar(mergeFieldSalutation.Tag, "Mr.");
            subscriber.MergeFields.AddOrUpdateVar(mergeFieldAddress.Tag, new MergeFieldsInstance.Address()
            {
                Address1 = "675 Ponce de Leon Ave NE",
                City = "Atlanta",
                Country = "US",
                State = "Georgia",
                Zip = "GA 30308"
            });
            
            // Add a customer to list
            subscriber = mailChimp.AddMember(list.Id, subscriber);

            Console.WriteLine("Member {0} added to list, id {1}", subscriber.EmailAddress, subscriber.Id);
        }

        static void GetTemplates(MailChimpManager mailChimp)
        {
            // just get the 5th template which matches the given filter
            var result = mailChimp.GetTemplates(offset: 5, count: 1, filter: new TemplatesInstance() { Active = true, Type = "base"});

            // get all templates which match the same given filter
            var fullResult = mailChimp.GetTemplates(count: result.TotalItems,
                filter: new TemplatesInstance() {Active = true, Type = "base"});
        }

        static void Main(string[] args)
        {
            try
            {
                // Instantiate MailChimpManager passing your API Key as parameter (make sure you leave the datacenter id - e.g. us5)
                MailChimpManager mailChimp = new MailChimpManager("<YourAPIKeyHere>");
                // Alternatively you can use an OAuth token with the corresponding data center id as well: MailChimp.MailChimpManager mailChimp = new MailChimp.MailChimpManager("<YourOAuthTokenHere>", "dcid");
                    
                GetLists(mailChimp);
                CreateListAddMember(mailChimp);
                CreateListAddMemberCustomMergefields(mailChimp);
                GetTemplates(mailChimp);
                // see CustomMailChimpManager how to limit requested data to certain fields
            }
            catch (MailChimpException ex)
            {
                Console.WriteLine(ex.MailChimpError.Detail);
            }

            Console.ReadKey();
        }
    }
}
