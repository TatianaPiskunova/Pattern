using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class BarbecueB1: AbstractBarbecue
    {
        public BarbecueB1(string name="Из свинины") : base(name) { }
        
        public override string ToString()
        {
            return "Шашлык мясной  ! " + GetName + " ! ";
        }
    }
}
