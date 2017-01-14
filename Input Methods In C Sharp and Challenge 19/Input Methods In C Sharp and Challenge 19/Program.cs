using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_Methods_In_C_Sharp_and_Challenge_19
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
          * //Q19/ Define 4 variables 
          * 1- First Name
          * 2- Last Name
          * 3- Salary
          * 4- TaxRate =  0.07
          * 5- Enter all these values from the console window and then
          * Find the salary for 12 month and cut the TaxRate for 12 months and print the salary
          * in this form
          * Welcome fName, LName
          * Your Salary for 12 months is #$
          * You paid TaxRate for 12 months  #$
          * Good Bye
          * */

            string fname, lname, mytax, mysalary;
            decimal salary, tax;
            Console.WriteLine("what is your first name?");
            fname = Console.ReadLine();
            Console.WriteLine("what is your last name?");
            lname = Console.ReadLine();
            Console.WriteLine("How much is your salary ?");
            mysalary = Console.ReadLine();
            salary = Convert.ToDecimal(mysalary);
            Console.WriteLine("what is your taxes percentage ?");
            mytax = Console.ReadLine();
            tax = Convert.ToDecimal(mytax);
            Console.WriteLine($"WELCOME {fname},{lname}");
            Console.WriteLine($"your salary for 12 month = {salary * 12} $");
            Console.WriteLine($"your taxes for 12 month = {tax * salary * 12} $");
            Console.WriteLine("good bye");
            Console.ReadKey();

        }
    }
}
