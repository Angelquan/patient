using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace patient
{
    class Program
    {
        static void Main(string[] args)
        {
            int numEmp;
            WriteLine("How many emps would you like to enter?");
            numEmp = Convert.ToInt32(ReadLine());

            Employee[] empArray = new Employee[numEmp];

            for (int x = 0; x < empArray.Length; x++)
            {
                populateEmployee(ref empArray[x]);
            }

            WriteLine("{0,15}{1,20}{2,20}{3,15}{4,20}", "employee #", "First", "last", "Salary", "position");

            for (int y = 0; y < empArray.Length; y++)
            {
                WriteLine("{0,15}{1,20}{2,20}{3,15}{4,20}", empArray[y].EmployeeNumber, empArray[y].FirstName, empArray[y].LastName, empArray[y].Salary, empArray[y].Position);
            }

            WriteLine("which emp would you like to modify, enter a number please");

            for (int z = 0; z < empArray.Length; z++)
            {
                WriteLine("{0,3}{1,15}{2,20}{3,20}", z + 1, empArray[1].EmployeeNumber, empArray[z].LastName, empArray[z].FirstName);
            }

            int selectedEmployee = Convert.ToInt32(ReadLine());
            modifyEmployee(ref empArray[selectedEmployee - 1]);

            ReadKey();



        }//closes main


        //method
        static void populateEmployee(ref Employee e)
        {
            WriteLine("please enter Employee Number");
            int empnum = Convert.ToInt32(ReadLine());
            Write("please enter the Employee salary");
            double salar = Convert.ToDouble(ReadLine());
            Write(" PLease enter employee last name");
            string lastName = ReadLine();
            Write(" PLease enter employee first name");
            string firstName = ReadLine();
            Write(" PLease enter employee position");
            string posit = ReadLine();

            //this is the constructor

            e = new Employee(empnum, salar, lastName, firstName, posit);
        }
        
        static void modifyEmployee(ref Employee a)
        {
            WriteLine(" would you like to update \n1. Employee Number\n2. Last Name\n3.First Name\n4. Position\n5. Salary");
            int userInput = Convert.ToInt32(ReadLine());

            if (userInput == 1)
            {
                Write("What is the corrected employee number?");
                int newNum = Convert.ToInt32(ReadLine());
                a.EmployeeNumber = newNum;
            }
            else if (userInput == 2)
            {
           
                Write("What is the corrected lastname?");
                string lname = ReadLine();
                a.LastName = lname;
            }
            else if (userInput == 3)
            {
                Write("What is the corrected first name?");
                string fname = ReadLine();
                a.FirstName = fname;
            }
            else if (userInput == 4)
            {
                Write("What is the corrected first position?");
                string posit = ReadLine();
                a.Position = posit;
            }
            if (userInput == 5)
            {
                Write("What is the corrected salary");
                double sal = Convert.ToDouble(ReadLine());
                a.Salary = sal;

            }
        }
    }
}