using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            int ID;
            string EmpName;
            char EmpGEnder;
            double salary;
            DateTime doj;
            Console.WriteLine("Enter ID");
            ID = int.Parse(Console.ReadLine());
            Console.WriteLine("enter  Employee name");
            EmpName = Console.ReadLine();
            Console.WriteLine("Enter Gender");
            EmpGEnder = char.Parse(Console.ReadLine());
            Console.WriteLine("ENTER SALARY");
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("enter date of joining");
            doj = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("ID:\t EmpName:  EmpGEnder:\t  salary:\t Date of Joining: \t");
            Console.WriteLine("-----------------------------------------------------------------------------------\n"+ ID + "\t" + EmpName + "\t" + EmpGEnder + "\t" + salary + " \t" + doj);

            Console.ReadKey();
        }
    }
}
