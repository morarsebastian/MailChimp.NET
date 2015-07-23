using MailChimp.Responses;
using MailChimp.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate MailChimpManager passing your API Key as parameter (make sure you leave the datacenter id - e.g. us5)
            MailChimp.MailChimpManager mailChimp = new MailChimp.MailChimpManager("<YourAPIKeyHere>");
            
            // Get the subscriber lists
            ListResult lists = mailChimp.GetLists();

            // Add a customer to first list
            SubscriberResult subsResult =  mailChimp.AddCustomer(lists.Lists[0].Id, new Subscriber(string.Format("testaddress+{0}@yourdomain.com", DateTime.UtcNow.Ticks), "subscribed", "Firstname", "Lastname"));

        }
    }
}
