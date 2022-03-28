using System;
using Task._28._03._2022.Models;

namespace Task._28._03._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Nicat";
            string surname = "Mammadov";
            int age = 0;
            double SalaryOFHour = 8;
            double WorkingHour = 200;
            double IQRank = 45;
            double LanguageRank = 67;
            double DailyWorkingHours = 0;
            double MonthlySalary = 0;
            double FinalScore = 0;

            int choice;
            do
            {
                Start:
                try
                {
                    Console.WriteLine("Choose the command (0:Info)");
                    Console.WriteLine("--------------");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("You can use it to get information!");
                    goto Start;
                }
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("----------------");
                        Console.WriteLine("1:Finding the employee's monthly salary\n" +
                            "2:Checking the student's exam results\n" +
                            "3:Exit the program");
                        Console.WriteLine("----------------");
                        break;
                    case 1:
                        Console.WriteLine("----------------");
                        EnterEmployeeİnformation(name, surname, age, DailyWorkingHours, MonthlySalary);
                        Employee employee = new Employee(name, surname, age, SalaryOFHour, WorkingHour);
                        Console.WriteLine($"Total salary amount:{employee.CalculateSalary()}");
                        Console.WriteLine("----------------");
                        break;
                    case 2:
                        Console.WriteLine("----------------");
                        EnterStudentİnformation(name, surname, age, IQRank, LanguageRank, FinalScore);
                        Student student = new Student(name, surname, age, IQRank, LanguageRank);
                        Console.WriteLine($"Student's exam result {student.ExamResult()}");
                        StudentFinalScore(FinalScore);
                        Console.WriteLine("----------------");
                        break;
                    case 3:
                        Console.WriteLine("----------------");
                        Console.WriteLine("End");
                        Console.WriteLine("----------------");
                        break;
                    default:
                        Console.WriteLine("----------------");
                        Console.WriteLine("Information about this employee or student was entered incorrectly.");
                        Console.WriteLine("----------------");
                        break;
                }
            } while (choice != 3);
        }
        //The method of checking the data of the worker
        static void EnterEmployeeİnformation(string name, string surname, int age, double DailyWorkingHours, double MonthlySalary)
        {
            Name(name);
            Surname(surname);
            AgeLimitOfTheEmployee(age);
            WorkingHoursLimit(DailyWorkingHours);
            EmployeeMonthlySalary(MonthlySalary);
        }
        //The method of checking the student's information
        static void EnterStudentİnformation(string name, string surname, int age, double IQRank, double LanguageRank, double FinalScore)
        {
            Name(name);
            Surname(surname);
            AgeLimitOfStudent(age);
            CheckIQrank(IQRank);
            CheckLanguageRank(LanguageRank);
            StudentFinalScore(FinalScore);

        }
        //Writing Name and Surname
        static void Name(string name)
        {
            Begin:
            try
            {
                Console.WriteLine("Enter the person's name");
                name = Convert.ToString(Console.ReadLine());
                throw new ArgumentNullException("But enter the name.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Begin;
            }
        }
        static void Surname(string surname)
        {
            Initiate:
            try
            {
                Console.WriteLine("Enter the person's last name");
                surname = Convert.ToString(Console.ReadLine());
                throw new ArgumentNullException("But enter the surname");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Initiate;
            }
        }
        //The method of checking the age of the employee
        static void AgeLimitOfTheEmployee(int age)
        {
            Commence:
            try
            {
                Console.WriteLine("Enter age");
                age = Convert.ToInt32(Console.ReadLine());
                if (age < 18 || age > 65)
                {
                    Console.WriteLine("This person cannot work according to the law");
                }
                else if (age > 18 || age <= 65)
                {
                    Console.WriteLine("This person has the right to work.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Commence;
            }
        }
        //The method of checking the employee's working hours
        static void WorkingHoursLimit(double DailyWorkingHours)
        {
            Started:
            try
            {
                Console.WriteLine("Write down the daily working hours");
                DailyWorkingHours = Convert.ToDouble(Console.ReadLine());
                if (DailyWorkingHours > 8)
                {
                    Console.WriteLine("Working hours can not exceed 8 hours");
                }
                else if (DailyWorkingHours <= 8)
                {
                    throw new DllNotFoundException("The working hours provided for the employee are in accordance with the rules.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Started;
            }
        }
        //The method of checking the employee's salary
        static void EmployeeMonthlySalary(double MonthlySalary)
        {
            GetBegining:
            try
            {
                Console.WriteLine("-------------");
                Console.WriteLine("Enter the monthly salary");
                MonthlySalary = Convert.ToDouble(Console.ReadLine());
                if (MonthlySalary < 250)
                {
                    Console.WriteLine("The salary of this employee is less than the minimum wage");
                }
                else if (MonthlySalary >= 250)
                {
                    Console.WriteLine("This employee can receive a minimum wage and more.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto GetBegining;
            }
        }
        //The method of checking the age of the student
        static void AgeLimitOfStudent(int age)
        {
            GetStarted:
            try
            {
                Console.WriteLine("Enter age");
                age = Convert.ToInt32(Console.ReadLine());
                if (age < 6 || age > 20)
                {
                    Console.WriteLine("This person is not a student.");
                }
                else if (age > 6 || age < 20)
                {
                    Console.WriteLine("You can enter information about the student.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto GetStarted;
            }
        }
        //The method of checking the student's exam results
        static void CheckIQrank(double IQRank)
        {
            GetBegin:
            try
            {
                Console.WriteLine("Record the result of the IQ test.");
                IQRank = Convert.ToDouble(Console.ReadLine());
                if (IQRank > 0 || IQRank <= 100)
                {
                    Console.WriteLine("The student scored a certain number of points in the exam.");
                }
                else if (IQRank > 100 || IQRank < 0)
                {
                    Console.WriteLine("There is no such scale.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto GetBegin;
            }
        }
        static void CheckLanguageRank(double LanguageRank)
        {
            GetCommence:
            try
            {
                Console.WriteLine("Record the result of the language exam.");
                LanguageRank = Convert.ToDouble(Console.ReadLine());
                if (LanguageRank > 0 || LanguageRank <= 100)
                {
                    Console.WriteLine("The student scored a certain number of points in the exam.");
                }
                else if (LanguageRank > 100 || LanguageRank < 0)
                {
                    Console.WriteLine("There is no such scale.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto GetCommence;
            }
        }
        //Final exam result method
        static void StudentFinalScore(double FinalScore)
        {
            GetCommenced:
            try
            {
                FinalScore = Convert.ToDouble(Console.ReadLine());
                if (FinalScore >= 120)
                {
                    Console.WriteLine("The student passed the exam, gaining a certain passing score or higher.");
                }
                else if (FinalScore >= 0 && FinalScore < 120)
                {
                    Console.WriteLine("The student failed the exam.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto GetCommenced;
            }
        }
    }
}
