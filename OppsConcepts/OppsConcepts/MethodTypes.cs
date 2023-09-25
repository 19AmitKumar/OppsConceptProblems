using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts
{
    internal class MethodTypes
    {
    }
    public class Method
    {
        //public int MethodReturnType() 
        //{
        //    int sum =5 + 12;
        //    return sum;
        //}
        //public int MethodWithParameter(int a,int b)
        //{
        //    int sum = a + b;
        //    return sum;
        //} 
        //public void BuildInMethod()
        //{
        //    double a = Math.Sqrt(9);
        //    Console.WriteLine(a);
        //}

        //Method Overloading

        //Method with one Parameter
        public void Display(int a)
        {
            Console.WriteLine("Argument: " + a);
        }
        //Method with two Parameter
        public void Display(int a, int b)
        {
            Console.WriteLine("Argument: " + a + " and " + b);
        }
    }
}
