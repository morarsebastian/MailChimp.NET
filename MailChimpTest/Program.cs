using MailChimp.Responses;
using MailChimp.Requests;
using System;
using MailChimp.Error;

namespace MailChimpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Instantiate MailChimpManager passing your API Key as parameter (make sure you leave the datacenter id - e.g. us5)
                MailChimp.MailChimpManager mailChimp = new MailChimp.MailChimpManager("<YourAPIKeyHere>");

                // Get the subscriber lists
                ListResult lists = mailChimp.GetLists();

                Subscriber subscriber = new Subscriber(string.Format("testaddress+{0}@yourdomain.com", DateTime.UtcNow.Ticks), "subscribed");
                subscriber.MergeFields = new MergeFields() { FirstName = "John", LastName = "Doe" };

                // Add a customer to first list
                SubscriberResult subsResult = mailChimp.AddCustomer(lists.Lists[0].Id, subscriber);

                Console.WriteLine(subsResult.Id);
            }
            catch (MailChimpException ex)
            {
                Console.WriteLine(ex.MailChimpError.Detail);
            }

            Console.ReadKey();
        }
    }
}
