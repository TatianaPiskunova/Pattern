using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Cafe2 : AbstractCafe
    {
        public override AbstractPizza CreatePizza(string type, int[] ingridients)
        {
            if (ingridients[0] == 0 && ingridients[1] == 0)
                return new PizzaA2("Просто основа", type, ingridients);
            if (ingridients[1] == 0)
                return new PizzaA2("Пицца Морская", type, ingridients);
            if (ingridients[0] == 0)
                return new PizzaA2("Пицца 4 сыра", type, ingridients);
            return new PizzaA2("Пицца Мешанина", type, ingridients);

        }

        public override AbstractBarbecue CreateBarbecue(string name="Из баранины")
        {
            return new BarbecueB1(name);
        }
    }
}
