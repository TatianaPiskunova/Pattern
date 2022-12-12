using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    abstract class AbstractBarbecue
    {
        string Name;
        protected AbstractBarbecue(string name)
        {
            Name = name;
        }
        public string GetName => Name;
    }
}
