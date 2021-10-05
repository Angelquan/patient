using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patient
{
    public class Employee
    {
        int employeeNum;
        double salary;
        string lname, fname, position;

        public Employee( int empNum, double sala, string ln, string fn, string pot)
        {
            employeeNum = empNum;
            salary = sala;
            lname = ln;
            fname = fn;
            position = pot;
                }

        public int EmployeeNumber
        {
            get { return employeeNum; }
            set { employeeNum = value; }
                
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }

        }

        public string LastName
        {
            get { return lname; }
            set { lname = value; }
        }

        

        public string FirstName
        {
            get { return fname; }
            set { fname = value; }
        }
    }// =closes main

}
