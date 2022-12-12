using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    abstract class AbstractPizza
    {
        string Name;

       public AbstractPizza(string name)
        {
            Name = name;
        }

        public string GetName => Name;

       // public abstract string Add();

    }
}
