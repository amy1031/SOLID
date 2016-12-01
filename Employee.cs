using System;
using System.Collections.Generic;

namespace Solid
{
    public abstract class Employee
    {
        // this class violates the 'Interface Segregation' principle
        
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual string GetProjectDetails()
        {
            return "Base Project";
        }
        public virtual string GetEmployeeDetails()
        {
            return "Base Employee";
        }
    }

    public class FulltimeEmployee : Employee
    {
        public override string GetProjectDetails()
        {
            return "Child Project";
        }

        public override string GetEmployeeDetails()
        {
            return "Child Employee";
        }
    }

    public class ContractEmployee : Employee
    {
		// this class violates the 'Liskov Substitution' principle
        public override string GetProjectDetails()
        {
            return "Child Project";
        }
        
        public override string GetEmployeeDetails()
        {
            throw new NotImplementedException();
        }
    }

    public class EmployeeService
    {
        // this class violates the 'Single Responsibility' principle

        public bool SaveEmployee(Employee employee)
        {
            // save the employee
            return true;
        }

        public void PrintEmployeesReport()
        {
            List<Employee> employeeList = new List<Employee>();

            employeeList.Add(new ContractEmployee());
            employeeList.Add(new FulltimeEmployee());

            foreach (Employee e in employeeList)
            {
                e.GetEmployeeDetails();
            }
        }
    }
}