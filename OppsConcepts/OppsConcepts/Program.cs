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
                int b=Convert.ToInt32(Console.ReadLine());
                switch (b)
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
                        //VisitingEmployee v = new VisitingEmployee();
                        //v.EmpId = 1;
                        //v.EmpName = "Amit";
                        //v.EmpAge = 30;
                        //v.EmpContactNo = 7070939796;
                        //v.Visitingsalary = 30000;
                        //v.VisitingHour = 50;
                        //Console.WriteLine("Visiting Employee id is: " + v.EmpId);
                        //Console.WriteLine("Visiting Employee name is: " + v.EmpName);
                        //Console.WriteLine("Visiting Emloyee Age is: " + v.EmpAge);
                        //Console.WriteLine("Visiting Employee Contact no is: " + v.EmpContactNo);
                        //Console.WriteLine("Visiting Employee salary is: " + v.Visitingsalary);
                        //Console.WriteLine("Visiting Employee Hour is: " + v.VisitingHour);
                        //Console.WriteLine("----------------------------------");
                        //ParmanentEmployee p = new ParmanentEmployee();
                        //p.EmpId = 2;
                        //p.EmpName = "Satyam";
                        //p.EmpAge = 31;
                        //p.EmpContactNo = 8210813591;
                        //p.ParmanentSalary = 40000;
                        //p.ParmanentHour = 55;
                        //Console.WriteLine("Parmanent Employee id is: " + p.EmpId);
                        //Console.WriteLine("Parmanent Employee name is: " + p.EmpName);
                        //Console.WriteLine("Parmanent Employee Age is: " + p.EmpAge);
                        //Console.WriteLine("Parmanent Employee Contact no is: " + p.EmpContactNo);
                        //Console.WriteLine("Parmanent Employee salary is: " + p.ParmanentSalary);
                        //Console.WriteLine("Parmanent Employee Hour is: " + p.ParmanentHour);
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
                    case 6:
                        Worker e = new Worker(333, "Amit", 35000);
                        e.ShowDetails();
                        break;
                    case 7:
                        //Varibles v = new Varibles();
                        //Global varible
                        //v.EngMarks = 75;
                        //v.MathMarks = 85;
                        //Console.WriteLine("English Marks: "+v.EngMarks);
                        //Console.WriteLine("Math Marks: "+v.MathMarks);
                        //Local Varible
                        //v.Details();
                        //static varible
                        Varibles.name = "Amit";
                        Varibles.salary = 1000000;
                        Console.WriteLine(Varibles.name+" has salary "+ Varibles.salary);
                        break;
                        case 8:
                        Method me = new Method();
                        //Methord Return Type Calling
                        //Console.WriteLine("Sum is: "+ me.MethodReturnType());
                        //Console.WriteLine("MethodWithParameter sum is: "+me.MethodWithParameter(10,15));
                        //me.BuildInMethod();
                        //Method Overloading
                        me.Display(5);
                        me.Display(5, 7);
                        break;
                        case 9:
                        int a = 5;
                        //PassByValue.PassBy(a);
                        //Console.WriteLine(a);
                        PassByReference.Pass(ref a);
                        Console.WriteLine(a);
                        break;
                        case 10:
                        PermananentEmployee employee = new PermananentEmployee();
                        employee.EmpId = 100;
                        employee.EmpName = "Amit";
                        employee.PermanentSalary = 10000;
                        employee.PermanentHour = 30;
                        Console.WriteLine("The Employee Id is: " + employee.EmpId);
                        Console.WriteLine("The Employee Age is: " + employee.EmpName);
                        Console.WriteLine("The Employee permanent salary is: " + employee.PermanentSalary);
                        Console.WriteLine("The working hour of Employee is: "+employee.PermanentHour);
                        break;
                        case 11:
                        Teacher t = new Teacher("Ram", 1234, 33, 1000);
                        t.Teacherdetails();
                        Console.WriteLine("-----------------------");
                        Doctor d = new Doctor("Shyam", 56789, 37, 700);
                        d.Doctordetails();
                        break;










                }
                Console.ReadLine();

            }
        }
    }
}
