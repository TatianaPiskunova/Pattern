using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    abstract class PizzaDecorator :AbstractPizza
    {
        protected AbstractPizza p;
        public PizzaDecorator(AbstractPizza p) : base(p.GetName)
        {
            this.p = p;
        }
    }
}
