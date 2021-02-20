using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    class Masa : IProduct
    {
        public void Add()
        {
            Console.WriteLine("Masa Listeye Eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Masa Listeden Silindi");
        }

        public void Update()
        {
            Console.WriteLine("Masa Listede Güncellendi");
        }
    }
}
