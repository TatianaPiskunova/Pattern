using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class DecorPizzaSause:PizzaDecorator
    {
        public DecorPizzaSause(AbstractPizza p) : base(p)
        { }
       public string AddSause() => p.ToString() + Environment.NewLine + "С соусом";
              
    }
}
