using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts
{
    internal class PassByValueAndReference
    {
    }
    //internal class PassByValue
    //{
    //    public static void PassBy(int a)
    //    {
    //        a = a + 10;
    //        Console.WriteLine("Value is: "+a);
    //    }
    //}
    internal class PassByReference
    {
        public static void Pass(ref int a)
        {
            a = a + 10;
            Console.WriteLine("value is: " + a);
        }
    }
}
