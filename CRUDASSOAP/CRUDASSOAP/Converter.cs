using DataTransferLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public static class Converter
    {
        public static Employee EmpDTOtoEmp(EmployeeDTO d)
      {
               return new Employee 
               {
                   EmployeeName = d.Name,
                   EmployeeCity = d.City,
                   EmployeeId = d.Id
               };
      }

        public static EmployeeDTO EmptoEmpDTO(Employee e)
      {
               return new EmployeeDTO 
               {
                   Name = e.EmployeeName,
                   City = e.EmployeeCity,
                   Id = e.EmployeeId
               };
      }

     public static List<EmployeeDTO> LEmptoLEmpDTO(List<Employee> e)
        {

            List<EmployeeDTO> lstEmpDTO = e.Select(
                emp => new EmployeeDTO()
                {
                    City = emp.EmployeeCity,
                    Name = emp.EmployeeName,
                    Id = emp.EmployeeId

                } ).ToList();
            return lstEmpDTO; 
        }

     public static List<Employee> LEmptoLEmpDTO(List<EmployeeDTO> e)
     {

         List<Employee> lstEmp = e.Select(
             emp => new Employee()
             {
                 EmployeeCity = emp.City,
                 EmployeeName = emp.Name,
                 EmployeeId = emp.Id

             }).ToList();
         return lstEmp;
     }


    }
}
