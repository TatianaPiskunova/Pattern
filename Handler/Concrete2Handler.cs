using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    class Concrete2Handler : Handler
    {
        public override void BarbecueLamb(TextBox tb, string text)
        {

            if (text == "Из баранины")
            {
                AbstractCafe B = new Cafe2();
                tb.AppendText(Environment.NewLine + B.CreateBarbecue(text).ToString());

            }

            else if (NextHandler != null)
                NextHandler.BarbecueLamb(tb, text);

        }
    }
}
