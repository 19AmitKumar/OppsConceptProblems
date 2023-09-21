using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OppsConcepts
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your choice: ");
                int a=Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                        case 0:
                        flag = false;
                        break;
                        case 1:
                        ClassAndObject obj = new ClassAndObject();
                        obj.num1 = 20;
                        obj.num2 = 10;
                        obj.Add();
                        obj.Subtract();
                        obj.Multiply();
                        obj.Divide();
                        break;
                        case 2:
                        VisitingEmployee v = new VisitingEmployee();
                        v.EmpId = 1;
                        v.EmpName = "Amit";
                        v.EmpAge = 30;
                        v.EmpContactNo = 7070939796;
                        v.Visitingsalary = 30000;
                        v.VisitingHour = 50;
                        Console.WriteLine("Visiting Employee id is: " + v.EmpId);
                        Console.WriteLine("Visiting Employee name is: " + v.EmpName);
                        Console.WriteLine("Visiting Emloyee Age is: " + v.EmpAge);
                        Console.WriteLine("Visiting Employee Contact no is: " + v.EmpContactNo);
                        Console.WriteLine("Visiting Employee salary is: " + v.Visitingsalary);
                        Console.WriteLine("Visiting Employee Hour is: " + v.VisitingHour);
                        Console.WriteLine("----------------------------------");
                        ParmanentEmployee p = new ParmanentEmployee();
                        p.EmpId = 2;
                        p.EmpName = "Satyam";
                        p.EmpAge = 31;
                        p.EmpContactNo = 8210813591;
                        p.ParmanentSalary = 40000;
                        p.ParmanentHour = 55;
                        Console.WriteLine("Parmanent Employee id is: " + p.EmpId);
                        Console.WriteLine("Parmanent Employee name is: " + p.EmpName);
                        Console.WriteLine("Parmanent Employee Age is: " + p.EmpAge);
                        Console.WriteLine("Parmanent Employee Contact no is: " + p.EmpContactNo);
                        Console.WriteLine("Parmanent Employee salary is: " + p.ParmanentSalary);
                        Console.WriteLine("Parmanent Employee Hour is: " + p.ParmanentHour);
                        break;
                    case 3:
                        MethodOveloading m = new MethodOveloading();
                        m.sum(10, 20);
                        m.sum(20.5f, 30.5f);
                        break;
                    case 4:
                        Dog dog = new Dog();
                        dog.Eat();
                        dog.Bark();
                        break;
                    case 5:
                        Account account = new Account();
                        account.SetBalance(10000);
                        account.GetBalance();
                        break;




                        Console.ReadLine();
                }
            }
        }
    }
}
