using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts
{
    internal class MethodOveloading
    {
        public void sum(int a, int b)
        {
            Console.WriteLine("sum of int is: "+(a + b));
            
        }
        public void sum(float a, float b)
        {
            Console.WriteLine("sum of float is: "+(a + b));
        } 
    }
}
