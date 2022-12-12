using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
   abstract class Handler
   // interface IHandler
    {
        public Handler NextHandler { get; set; }//Successor
        public abstract void BarbecueLamb(TextBox tb, string text);//HandleRequest

    }
    //{
    // Handler NextHandler { get; set; }//Successor
    //    void BarbecueLamb(string text);//HandleRequest


    //}
}