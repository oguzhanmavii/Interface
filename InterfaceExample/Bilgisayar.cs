using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    class Bilgisayar : IProduct
    {
        public void Add()
        {
            Console.WriteLine("Bilgisayar Listeye Eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Bilgisayar Listeden Silindi");
        }

        public void Update()
        {
            Console.WriteLine("Bilgisayar Listede Güncellendi");
        }
    }
}
