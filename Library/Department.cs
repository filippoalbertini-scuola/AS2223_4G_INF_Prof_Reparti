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
        Employee[] employees;
        Employee headDepartment;

        // department members 
        int nEmployees;

        public Department(string name, int nEmployees, Employee headDepartment)
        {
            this.name = name;

            // creating array to manage employee association (1-n)
            employees = new Employee[nEmployees];

            this.headDepartment = headDepartment;
        }

        /// <summary>
        /// Adding an employee to a department
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>false with an error</returns>
        public bool AddEmployee(Employee employee) 
        {
            if (nEmployees < employees.Length) 
            { 
                employees[nEmployees] = employee;
                nEmployees += 1;
            }
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

            for (int i=0;i<nEmployees;i++)
            {
                if (res.Length>0) res += ",";

                res += $"{employees[i].Description()}";
            }

            return res;
        }

        public string Name { get { return name; } }

        public Employee HeadDepartment { get { return headDepartment; } }   
    }
}
