# MailChimp.NET
.NET Wrapper for the [MailChimp v3.0 API] (http://kb.mailchimp.com/api)

### Before start

Please note this is a simple version made in a rush. It only gets the MailChimp lists and adds subscribers to lists. 

I plan on working more on it to implement more features, but I thought I share it with anyone who wants it. You are welcome to contribute

### Getting Started

You can download the project, build it and reference the dll. Or install the [NuGet package](https://www.nuget.org/packages/MailChimp.dll) from the package manager console:

```powershell
Install-Package MailChimp.dll
```

Then you can use it as following:

```CSharp
// Instantiate MailChimpManager passing your API Key as parameter (make sure you leave the datacenter id - e.g. us5)
MailChimp.MailChimpManager mailChimp = new MailChimp.MailChimpManager("<YourAPIKeyHere>");

// Get the subscriber lists
ListResult lists = mailChimp.GetLists();
```

### Example

##### Getting all the lists and adding one subscriber to the first lists

```CSharp
using MailChimp.Responses;
using MailChimp.Requests;
using System;

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

            Subscriber subscriber = new Subscriber(string.Format("testaddress+{0}@yourdomain.com", DateTime.UtcNow.Ticks), "subscribed");
            // This is a simple class that inherits IMergeFields (populated with custom lists fields from MailChimp)
            // By default all MailChimp lists have first and last name, but you will surely need more columns added to
            // yout list
            subscriber.MergeFields = new MergeFields() { FirstName = "John", LastName = "Doe" }; 

            // Add a customer to first list
            SubscriberResult subsResult = mailChimp.AddCustomer(lists.Lists[0].Id, subscriber);

        }
    }
}
```
