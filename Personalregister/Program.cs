using System;

namespace Personalregister
{
    class Program
    {
        public static string EmployeeName;
        public static string EmployeeSalary;
        static void Main(string[] args)
        {       
            bool displayMenu = true;
            while(displayMenu==true)
            {
                displayMenu = Menu();
            } 
        }                    
            private static bool Menu()
            {
                string input;
                Console.Clear();
                Console.WriteLine("1.Employee Registry Entry");
                Console.WriteLine("2.Display Personal Register");
                Console.WriteLine("3.Exit");
                Console.WriteLine("Enter your Option");
                input = Console.ReadLine();
            if (input == "1")
            {
                Entry();
                return true;
            }
            else if (input == "2")
            {
                Display();
                return true;
            }

            else if (input == "3")
                return false;
            else
                return false;
                  
            }
            private static void Entry()
            {
                Console.WriteLine("Enter Employees Name and Salary");
                EmployeeName = Console.ReadLine();
                EmployeeSalary = Console.ReadLine();

            }
            private static void Display()
            {
                Console.WriteLine("Employee Name : {0} \n " +
                    "Employee Salary : {1}",
                    EmployeeName,EmployeeSalary);
            Console.ReadLine();
            }
        }
    }
//Vilka klasser bör ingå i programmet?
//Program()

//Vilka attribut och metoder bör ingå i dessa klasser?
//Attribut : EmployeeName,EmployeeSalary
// metoder : Menu(),Entry(),Display()

