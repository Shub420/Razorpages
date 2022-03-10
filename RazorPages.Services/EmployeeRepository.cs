using RazorPages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorPages.Services
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public EmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee()
                {
                    Id=1,Name="Shubham",Department=Dept.HR,Email="Shubham23994@gmail.com",PhotoPath="Shubham.png"
                    
                },
                new Employee()
                {
                    Id=2,Name="rajat",Department=Dept.IT,Email="Rajat23994@gmail.com",PhotoPath="rajat.jpg"
                },
                 new Employee()
                {
                    Id=3,Name="David",Department=Dept.Payroll,Email="David23994@gmail.com"
                }

            };
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
           return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }
    }
}
