using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeLouvillePlayground
{
    class Program
    {
        static void Main(string[] args)
        {

            Writer.DoSomething();

            Employee employee1 = new Employee("Ross", "Anthony", DateTime.Now, "Mentor", 10);
            Employee employee2 = new Employee("Alexa", "Anthony", Convert.ToDateTime("5/31/2021"), "Boss", 100);

            string employeeTitle = employee1.Title;
            string employeeTitle2 = employee2.Title;

            

            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(employee1);
            employeeList.Add(employee2);


            var tempList = employeeList.Where(x => x.LastName == "Anthony").ToList();

            Vehicle v = new Vehicle();
            v.DriveCar(employee2);


        }      
    }
}
