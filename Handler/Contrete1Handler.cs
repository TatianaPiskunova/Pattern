using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    class Contrete1Handler : Handler
    {
        public override void BarbecueLamb(TextBox tb, string text)
        {

            if (text == "Из свинины")
            {
                AbstractCafe A = new Cafe1();
                tb.AppendText(Environment.NewLine + A.CreateBarbecue(text).ToString());
            }

            else if (NextHandler != null)
            {
                tb.AppendText(Environment.NewLine + Environment.NewLine + "Шашлык готовит кафе !Первее первого!");
                NextHandler.BarbecueLamb(tb, text);
            }     
                

        }
    }
}
