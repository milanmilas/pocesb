using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;

namespace SubscriberClient.Services

{
    using SubscriberClient.Controllers;

    [ServiceBehavior(Namespace = "http://allocatesoftware.uk")]
    public class SubscriberService : ISubscriberService
    {
        public void DispalyInformation(string message)
        {
           HomeController.AddMessage(message);
           Console.WriteLine(message);
        }
    }
}