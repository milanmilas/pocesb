using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SubscriberClient.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISubscriberService" in both code and config file together.
    [ServiceContract(Namespace="http://allocatesoftware.uk")]
    public interface ISubscriberService
    {
        [OperationContract]
        void DispalyInformation(string message);
    }
}
