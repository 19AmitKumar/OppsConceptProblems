using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassAndObject obj = new ClassAndObject();
            obj.num1 = 20;
            obj.num2 = 10;
            obj.Add();
            obj.Subtract();
            obj.Multiply();
            obj.Divide();
            Console.ReadLine();
        }
    }
}
