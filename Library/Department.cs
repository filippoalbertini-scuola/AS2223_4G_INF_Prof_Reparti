using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Department
    {
        string name;
        List<Employee> employees;
        Employee headDepartment;

        // department members 
        int nMaxEmployees;

        public Department(string name, int nMaxEmployees, Employee headDepartment)
        {
            this.name = name;

            // creating list to manage employee association (1-n)
            employees = new List<Employee>();
            this.nMaxEmployees = nMaxEmployees;

            this.headDepartment = headDepartment;
        }

        /// <summary>
        /// Adding an employee to a department
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>false with an error</returns>
        public bool AddEmployee(Employee employee) 
        {
            if ( employees.Count < nMaxEmployees) 
                employees.Add(employee);
            else
                return false;

            return true;
        }

        /// <summary>
        /// Get a list of employees of the department
        /// </summary>
        /// <returns></returns>
        public string GetEmployees()
        {
            string res = "";

            foreach (Employee e in employees)
            {
                if (res.Length>0) res += ",";

                res += $"{e.Description()}";
            }

            return res;
        }

        public string Name { get { return name; } }

        public Employee HeadDepartment { get { return headDepartment; } }   
    }
}
