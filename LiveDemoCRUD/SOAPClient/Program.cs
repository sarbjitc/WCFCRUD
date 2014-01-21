using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOAPClient.ServiceReference1;

namespace SOAPClient
{
    class Program
    {
        static void Main(string[] args)
        {

            Service1Client proxy = new Service1Client();
            var result = proxy.GetEmployees();
           
            foreach (var r in result)
            {
                Console.WriteLine(r.Name);
            }
            Console.ReadKey(true);
        }
    }
}
