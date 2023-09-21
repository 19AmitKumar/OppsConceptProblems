using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts
{
    internal class Abstraction
    {
    }
    public class Employee
    {
        public int EmpId;
        public string EmpName;
        public double GrossPay;
        double TaxDeduction = 0.1;
        double NetSalary;
        public Employee(int Eid, string Ename, double EgrossPay)
        {
            this.EmpId = Eid;
            this.EmpName = Ename;
            this.GrossPay = EgrossPay;
        }
        public void Calculatesalary()
        {
            if (GrossPay > 30000)
            {
                NetSalary = GrossPay - (TaxDeduction * GrossPay);
                Console.WriteLine("Your salary is: " + NetSalary);
            }
            else
            {
                Console.WriteLine("Your salary: " + GrossPay);
            }
        }
        public void ShowDetails()
        {
            Console.WriteLine("Employee ID: " + EmpId);
            Console.WriteLine("Employee Name: " + EmpName);
            this.Calculatesalary();
        }
    }
}
