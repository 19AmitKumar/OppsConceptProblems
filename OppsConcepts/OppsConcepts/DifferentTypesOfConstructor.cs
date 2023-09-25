using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts
{
    internal class DifferentTypesOfConstructor
    {
    }
    public class Constructor
    {
        public int x, y;
        //public Constructor() //Default Cosrctor
        //{
        //    x = 30;
        //    y = 20;
        //}
        public Constructor(int x, int y) //Parametrised Constructor
        {
            this.x = x;
            this.y = y;
        }
    }
}
