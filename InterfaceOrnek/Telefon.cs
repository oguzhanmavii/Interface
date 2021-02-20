using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceOrnek
{
    class Telefon : IProduct
    {
        public void Add()
        {
            Console.WriteLine("Telefon Eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Telefon Silindi");
        }

        public void Update()
        {
            Console.WriteLine("Telefon Güncellendi");
        }
    }
}
