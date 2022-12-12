using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Cafe1 : AbstractCafe 
    {
        public override AbstractPizza CreatePizza(string type, int[] ingridients)
        {
            if (ingridients[0] == 0 && ingridients[1] == 0 && ingridients[2] == 0)
                return new PizzaA1("Просто основа", type, ingridients);
            if (ingridients[0] == 0 && ingridients[1] == 0)
                return new PizzaA1("Пицца Грибная", type, ingridients);
            if (ingridients[0] == 0 && ingridients[2] == 0)
                return new PizzaA1("Пицца с перцем", type, ingridients);
            if (ingridients[1] == 0 && ingridients[2] == 0)
                return new PizzaA1("Пицца с курицей", type, ingridients);
            if (ingridients[0] == 0)
                return new PizzaA1("Пицца грибы и перец", type, ingridients);
            if (ingridients[1] == 0)
                return new PizzaA1("Пицца с грибы и курица", type, ingridients);
            if (ingridients[2] == 0)
                return new PizzaA1("Пицца с курица и перец", type, ingridients);
            return new PizzaA1("Пицца с Ассорти", type, ingridients);

        }

        public override AbstractBarbecue CreateBarbecue(string name= "Из свинины")
        {
            return new BarbecueB1(name);
        }

    }
}
