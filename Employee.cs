using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    class Employee
    {
        public string Name;
        public int Age;
        public string PlaceOfBirth;
        public double Salary;
        public int YearExperience;


        public double CalculateBonus ()
        {
            double Bonus;
            Bonus = Salary * 0.10 * YearExperience;
            return Bonus;
        }
    }

    class SeniorEmployee 
    {
        public string Name;
        public int Age;
        public string PlaceOfBirth;
        public int YearExperience;
        public double Salary;

        public double CalculateBonus()
        {
            double bonus;
            
            bonus = Salary * 0.1 * Age;
            return bonus; 
            
        }
    }
}
