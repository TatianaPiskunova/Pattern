using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class PizzaA2 : AbstractPizza   
    {
        string Type;
        int[] Ingridients;

        public PizzaA2(string name, string type, int[] ingridients) : base(name)
        {
            Type = type;
            Ingridients = ingridients;
        }

        public override string ToString()
        {
            return GetName + Environment.NewLine + Type + Environment.NewLine + "Морепродукты   "
                 + Ingridients[0] + Environment.NewLine + "Сыр   " + Ingridients[1];
        }

    }
}
