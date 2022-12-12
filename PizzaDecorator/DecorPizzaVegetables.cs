using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class DecorPizzaVegetables : PizzaDecorator
    {
        public DecorPizzaVegetables(AbstractPizza p) : base( p)
        { }
        public string AddVegetables() => p.ToString() + Environment.NewLine + "Дополнительно украшение цветами из овощей";
    }
}
