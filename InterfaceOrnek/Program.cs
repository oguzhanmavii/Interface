using System;

namespace InterfaceOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager manager = new ProductManager();

            manager.Add(new Telefon());
            manager.Delete(new Telefon());
            manager.Update(new Telefon());



        }
    }
}
