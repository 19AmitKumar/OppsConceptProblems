using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts
{
    public class Inheritance
    {
        public int EmpId;
        public string EmpName;
        public int EmpAge;
        public long EmpContactNo;
    }
    public class VisitingEmployee : Inheritance
    {
        public int Visitingsalary;
        public int VisitingHour;

    }
    public class ParmanentEmployee :Inheritance
    {
        public int ParmanentSalary;
        public int ParmanentHour;
    }
}
