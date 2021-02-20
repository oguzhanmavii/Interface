using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Employee Manager Added");
        }

        public void Delete()
        {
            Console.WriteLine("Employee Manager Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Employee Manager Updated");
        }
    }
}
