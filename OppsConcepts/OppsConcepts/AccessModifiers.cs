using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts
{
    internal class AccessModifiers
    {
    }
    public class AccessModifier
    {
        //public string name = "Amit";
        //internal double d = 109.6;
        //protected int i = 19;
        private char c = 'c';

        public void Modifier()
        {
            Console.WriteLine(c);

        }
    }
}
