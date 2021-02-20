using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    class Telefon : IProduct
    {
        public void Add()
        {
            Console.WriteLine("Telefon Listeye Eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Telefon Listeden Silindi");
        }

        public void Update()
        {
            Console.WriteLine("Telefon Listede Güncellendi");
        }
    }
}
