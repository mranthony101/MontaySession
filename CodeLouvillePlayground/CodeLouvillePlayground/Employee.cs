using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLouvillePlayground
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public DateTime StartDate { get; set; }
        public string Title { get; set; }

        private int _salary;

        public Employee(string firstName, string lastName, DateTime startDate, string title, int salary)
        {
            FirstName = firstName;
            LastName = lastName;
            FullName = $"{FirstName} {LastName}";
            StartDate = startDate;
            Title = title;
            _salary = salary;
        }


        public void DoWork()
        {
            DoWorkInSecret();
        }

        public void DoWork(string task)
        {
            Console.WriteLine($"I am working on {task}");
        }

        private void DoWorkInSecret()
        {
            Console.WriteLine("I am in a private method");
        }

        public void DetermineBonus()
        {
            double bonus = .25 * _salary;
            Console.WriteLine(bonus.ToString());
        }
    }



}
