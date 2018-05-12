using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CocoServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICocoService" in both code and config file together.
    [ServiceContract]
    public interface ICocoService
    {
        [OperationContract]
        [WebInvoke(Method = "GET",UriTemplate ="/bakisa/{mutu}", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        String lakisaMutu(String mutu);
    }
}
