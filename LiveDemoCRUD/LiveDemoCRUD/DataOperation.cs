using DataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOperations
{
    public static class DataOperation
    {
        public static List<EmployeeDTO> GetEmployee()
        {
            DataClasses1DataContext context = new DataClasses1DataContext();

            var result = from r in context.Employees select r;
            List<EmployeeDTO> lstEmpDto = Converter.LstEmpToLstEmpDTO( result.ToList());
            return lstEmpDto; 
        
        }
        public static void Add(EmployeeDTO e)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            Employee emp = Converter.EmployeeDTOtoEmp(e);
            context.Employees.InsertOnSubmit(emp);
            context.SubmitChanges();
        
        }
    }
}
