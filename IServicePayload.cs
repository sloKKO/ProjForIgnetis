using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace ProjectForIgentics
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicePayload" in both code and config file together.
    [ServiceContract]
    public interface IServicePayload
    {
        [OperationContract]
        [WebInvoke (Method="GET", UriTemplate ="findall",ResponseFormat = WebMessageFormat.Json)]
        List<Payload> findAll();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "create", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool create(Payload payload);      
    }
}
