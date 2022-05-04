using CoreApiCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiCRUD.EmployeeData
{
    public class MockEmployeeData : IEmployeeData
    {
        private List<Employee> employees = new List<Employee>()
        { 
            new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Sakda Intarat",
                Position = "Java Developer",
                Salary = 35000,
                Address = "Nontaburi",
                PhoneNumber = "0111111111"
            },
            new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Aushisa Arnut",
                Position = "C++ Developer",
                Salary = 32000,
                Address = "Pathumtani",
                PhoneNumber = "0222222222"
            }
        };
        public Employee AddEmployee(Employee employee)
        {
            employee.Id = Guid.NewGuid();
            employees.Add(employee);
            return employee;
        }
        public void DeleteEmployee(Employee employee)
        {
            employees.Remove(employee);
        }
        public Employee EditEmployee(Employee employee)
        {
            var existingEmployee = GetEmployee(employee.Id);
            existingEmployee.Name = employee.Name;
            return existingEmployee;
        }

        public Employee GetEmployee(Guid id)
        {
            return employees.SingleOrDefault(x => x.Id == id);
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
