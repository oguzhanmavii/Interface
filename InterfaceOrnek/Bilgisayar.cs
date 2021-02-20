using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceOrnek
{
    class Bilgisayar : IProduct
    {
        public void Add()
        {
            Console.WriteLine("Bilgisayar Eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Bilgisayar Silindi");
        }

        public void Update()
        {
            Console.WriteLine("Bilgisayar Güncellendi");
        }
    }
}
