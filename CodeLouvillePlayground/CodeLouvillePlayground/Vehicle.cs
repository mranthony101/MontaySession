using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLouvillePlayground
{
    class Vehicle
    {
        public int NumberofWheels { get; set; }
        public string Make { get; set; }
        public string  Model { get; set; }

        public void DriveCar(Employee employeeObj)
        {
            Console.WriteLine($"{employeeObj.FullName} is driving the car!");
        }
    }
}
