using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts
{
    internal class MultiLevelInheritance
    {
    }
    public class PetAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Every Animal Eat");
        }
    }
    public class Mammal : PetAnimal
    {
        public void Birth()
        {
            Console.WriteLine("Mammal give Birth to Young ones");
        }
    }
    public class Cat : Mammal
    {
        public void Mew()
        {
            Console.WriteLine("Cat Mew");
        }
    }
}
