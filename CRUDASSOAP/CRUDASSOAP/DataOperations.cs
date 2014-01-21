using DataTransferLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
  public static class DataOperations
  {
              public static void AddEmployee(EmployeeDTO e)
              {

                  DataClasses1DataContext context = new DataClasses1DataContext();
                  Employee emp = Converter.EmpDTOtoEmp(e);
                  context.Employees.InsertOnSubmit(emp);
                  context.SubmitChanges();
              }

              public static List<EmployeeDTO> FetchEmployee()
              {
                  DataClasses1DataContext context = new DataClasses1DataContext();
                  var lstEmp = from r in context.Employees select r;
                  List<EmployeeDTO> lstEmpDTO = new List<EmployeeDTO>();
                   lstEmpDTO = Converter.LEmptoLEmpDTO(lstEmp.ToList());
                   
                       return lstEmpDTO;
                 

              }        

        
    }
}
