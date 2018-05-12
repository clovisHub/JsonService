using CocoServiceApp.Models;
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
        [WebInvoke(Method = "POST",UriTemplate ="/bakisa/{people}", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        String bakisaMutu(ICocoPeople people);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/bakisa/{mutu}", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        String lukaMutu(Int16 mutu);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/bakisa", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        List<ICocoPeople> zuaMutu();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/bakisa/{longola}", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        String longolaMutu(Int16 longola);
    }
}






