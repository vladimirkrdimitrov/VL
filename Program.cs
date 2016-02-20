using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee georgi = new Employee();
            georgi.YearExperience = 2;
            georgi.Salary = 1000;
            georgi.PlaceOfBirth = "Varna";
            georgi.Age = 30;
            georgi.Name = "Georgi Petrov";
            Console.WriteLine("The Salary of {2}  is {0} and Bonus is {1}", georgi.Salary, georgi.CalculateBonus(), georgi.Name);

            Employee aneta = new Employee();
            aneta.YearExperience = 4;
            aneta.Salary = 1150;
            aneta.PlaceOfBirth = "Plovdiv";
            aneta.Age = 27;
            aneta.Name = "Aneta Antonova";

            Console.WriteLine("The Salary of {2} is {0} and Bonus is {1}", aneta.Salary, aneta.CalculateBonus(), aneta.Name);



            SeniorEmployee dimitar = new SeniorEmployee();
            dimitar.YearExperience = 10;
            dimitar.Salary = 2200;
            dimitar.PlaceOfBirth = "Ruse";
            dimitar.Age = 38;
            dimitar.Name = "Dimitar Georgiev";

            Console.WriteLine("The Salary of {0} is {2} and the bonus is {1}", dimitar.Name, dimitar.CalculateBonus(), dimitar.Salary);
            





        }
    }
}
