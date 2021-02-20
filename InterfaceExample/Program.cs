using System;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager manager = new ProductManager();

            manager.Add(new Bilgisayar());

            manager.Delete(new Telefon());

            manager.Update(new Masa());


        }
    }
}
