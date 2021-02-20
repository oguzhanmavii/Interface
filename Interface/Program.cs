using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            ProjectManager manager = new ProjectManager();

            manager.Add(new CustomerManager());

            manager.Delete(new EmployeeManager());


            manager.Update(new SchoolManager());

        }
    }
}
