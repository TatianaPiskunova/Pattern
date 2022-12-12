using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class BarbecueB2 : AbstractBarbecue
    {
        public BarbecueB2(string name="Из баранины") : base(name) { }

        public override string ToString()
        {
            return "Шашлык мясной  ! " + GetName + " ! ";
        }
    }
}
