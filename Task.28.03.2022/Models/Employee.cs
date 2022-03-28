using System;
using System.Collections.Generic;
using System.Text;

namespace Task._28._03._2022.Models
{
    class Employee : Person
    {
        public double SalaryOFHour { get; set; }
        public double WorkingHour { get; set; }

        public Employee(string name, string surname, int age, double salaryofhour, double workinghour)
        {
            Name = name;
            Surname = surname;
            Age = age;
            SalaryOFHour = salaryofhour;
            WorkingHour = workinghour;
        }
        //Calculation of the employee's monthly salary
        public double CalculateSalary()
        {
            return SalaryOFHour * WorkingHour;
        }
    }
}

