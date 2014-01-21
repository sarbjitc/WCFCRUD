using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DataTransfer;

namespace RestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebGet(UriTemplate="/Employee",RequestFormat=WebMessageFormat.Json,ResponseFormat=WebMessageFormat.Json)]
        List<EmployeeDTO> GetEmployee();
       

        [OperationContract]
        [WebInvoke(UriTemplate="/Employee",Method="POST",RequestFormat=WebMessageFormat.Json,ResponseFormat=WebMessageFormat.Json)]
        void  AddEmployee(EmployeeDTO emp);

        // TODO: Add your service operations here
    }


}
