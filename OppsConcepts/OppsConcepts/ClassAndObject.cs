using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts
{
    public class ClassAndObject
    {
        public int num1;
        public int num2;
       
        public void Add()
        {
            int sum=num1 + num2;
            Console.WriteLine("Sum is: "+sum);
        }
        public void Subtract() 
        {
            int sub=num1 - num2;
            Console.WriteLine("The subtraction is: "+sub);
        }
        public void Multiply()
        {
            int mul=num1 * num2;
            Console.WriteLine("The Multiplication is: "+mul);
        }
        public void Divide()
        {
            int div=num1 / num2;
            Console.WriteLine("The division is: " + div);
        }
        
    }
}
