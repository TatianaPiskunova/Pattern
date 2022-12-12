using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4    
{
    class PizzaA1 : AbstractPizza  
    {
        string Type;
        int[] Ingridients;

        public PizzaA1(string name, string type, int[] ingridients): base(name)
        {
            Type = type;
            Ingridients= ingridients;
        }
        public override string ToString()
        {
            return GetName+ Environment.NewLine + Type + Environment.NewLine + "Курица   "
                 + Ingridients[0] + Environment.NewLine + "Перец   "
                 + Ingridients[1] + Environment.NewLine + "Грибы   " + Ingridients[2];
        }
       
    }
}
