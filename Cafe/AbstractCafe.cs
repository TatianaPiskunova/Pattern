using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    abstract class AbstractCafe
    {
        public abstract AbstractPizza CreatePizza(string type, int[] ingridients);
        public abstract AbstractBarbecue CreateBarbecue(string name);

    }
    
}
