using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.Serialization.Json;
using DataTransferLibrary;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace RESTConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient proxy = new WebClient();
            var result = proxy.DownloadData("http://localhost:62671/Service1.svc/Employee");
            Console.WriteLine(result);
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(List<EmployeeDTO>));
            var lstEmp = (List<EmployeeDTO>) ser.ReadObject(new MemoryStream(result));
            foreach (var r in lstEmp)
            {
                Console.WriteLine(r.Name);
            }

            Console.ReadKey(true);
            var req  = (HttpWebRequest) WebRequest.Create("http://localhost:62671/Service1.svc/Employee");
            req.Method = "POST";
            req.ContentType = @"application/json;charset=utf-8";
            EmployeeDTO emp = new EmployeeDTO {Name="Sachin T",City="Mumbai",Id="rt2"};
            DataContractJsonSerializer ser1 = new DataContractJsonSerializer(typeof(EmployeeDTO));
            MemoryStream mw = new MemoryStream();
            var reader = new StreamReader(mw);
            ser1.WriteObject(mw,emp);
            mw.Position =0; 
            var body = reader.ReadToEnd();
            var strmWriter = new StreamWriter(req.GetRequestStream());
            strmWriter.Write(body);
            var response = req.GetResponse();

            
            
            //proxy.UploadString("",)
            //proxy.UploadData("http://localhost:62671/Service1.svc/Employee", "POST", mw.ToArray());
            Console.WriteLine("Data Created");
            Console.ReadKey(true);

        }
    }
}
