using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts
{
    internal class Hierarchicalnheritance
    {
    }
    public class Personss
    {
        public string name;
        public long adhar_id;
        public int age;
        public Personss(string name, long adhar_id, int age)
        {
            this.name = name;
            this.adhar_id = adhar_id;
            this.age = age;
        }
    }
    public class Teacher : Personss
    {
        public int teachersalary;
        public Teacher(string name, long adhar_id, int age, int teachersalary)
            : base(name, adhar_id, age)

        {
            this.teachersalary = teachersalary;

        }
        public void Teacherdetails()
        {
            Console.WriteLine("Teacher Id: " + adhar_id);
            Console.WriteLine("Teacher Name: " + name);
            Console.WriteLine("Teacher salary: " + teachersalary);
            Console.WriteLine("Teacher Age: " + age);
        }

    }
    public class Doctor : Personss
    {
        public int doctorFee;
        public Doctor(string name, long adhar_id, int age, int doctorFee)
            : base(name, adhar_id, age)

        {
            this.doctorFee = doctorFee;

        }
        public void Doctordetails()
        {
            Console.WriteLine("Doctor Id: " + adhar_id);
            Console.WriteLine("Doctor Name: " + name);
            Console.WriteLine("Doctor Fee: " + doctorFee);
            Console.WriteLine("Doctor Age: " + age);
        }

    }
}
