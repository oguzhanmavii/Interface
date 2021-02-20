using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class SchoolManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("School Manager Added");
        }

        public void Delete()
        {
            Console.WriteLine("School Manager Deleted");
        }

        public void Update()
        {
            Console.WriteLine("School Manager Updated");
        }
    }
}
