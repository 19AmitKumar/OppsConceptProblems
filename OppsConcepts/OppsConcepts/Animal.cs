using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts
{
    public class Animal
    {
        public void Eat() 
        {
            Console.WriteLine("Animal is Eating");
        }
    }
    public class Dog : Animal 
    {
        public void Bark() 
        {
            Console.WriteLine("Dog is Barking");
        }

    }
}
