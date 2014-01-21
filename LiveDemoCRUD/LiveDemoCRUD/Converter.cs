using DataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOperations
{
   public static class Converter
    {

       public static Employee EmployeeDTOtoEmp(EmployeeDTO d)
       {
           return new Employee
           {
               EmployeeCity = d.city,
               EmployeeId = d.Id,
               EmployeeName = d.Name
           };
       }

       public static List<EmployeeDTO> LstEmpToLstEmpDTO(List<Employee> e)
       {
           List<EmployeeDTO> lstEmpDTO = e.Select(
                   emp => new EmployeeDTO()
                   {
                       city = emp.EmployeeCity,
                       Name = emp.EmployeeName,
                       Id = emp.EmployeeId

                   }
               ).ToList();
           return lstEmpDTO;

       }

    }
}
