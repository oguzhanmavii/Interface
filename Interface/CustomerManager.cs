using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Customder Manager Added");
        }

        public void Delete()
        {
            Console.WriteLine("Customer Manager Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Customer Manager Updated");
        }
    }
}
