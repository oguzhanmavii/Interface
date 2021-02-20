using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceOrnek
{
    class ProductManager
    {
        public void Add(IProduct product)
        {
            product.Add();
        }

        public void Delete(IProduct product)
        {
            product.Delete();
        }

        public void Update(IProduct product)
        {
            product.Update();
        }

    }
}
