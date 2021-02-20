using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceOrnek
{
    class Camera : IProduct
    {
        public void Add()
        {
            Console.WriteLine("Camera Eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Camera Silindi");
        }

        public void Update()
        {
            Console.WriteLine("Camera Güncellendi");
        }
    }
}
