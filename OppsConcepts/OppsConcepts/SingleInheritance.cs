


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts
{
    internal class SingleInheritance
    {
    }   
    class Employee
    {
        public int EmpId;
        public string EmpName;
        public long EmpContactNo;
        public void show()
        {
            Console.WriteLine("This is a method of Bae class!!");
        }
    }
    class PermananentEmployee : Employee
    {
        public int PermanentSalary;
        public int PermanentHour;
    }
}
