using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOAPConsoleClient.ServiceReference1;

namespace SOAPConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {

            Service1Client proxy = new Service1Client();
            
            EmployeeDTO emp = new EmployeeDTO
            {
                Name = "dj",
                City = "Delhi",
                Id = "E99"

            };

            proxy.AddEmployee(emp);
            var result = proxy.GetEmployee();
            foreach (var r in result)
            {
                Console.WriteLine(r.Name);
            }

            Console.ReadKey(true);
        }
    }
}
