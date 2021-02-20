using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class ProjectManager
    {

        public void Add(IPersonManager manager)
        {
            manager.Add();

        }
        
        public void Delete(IPersonManager manager)
        {
            manager.Delete();
        }
       
        public void Update(IPersonManager manager)
        {
            manager.Update();
        }

    }
}
