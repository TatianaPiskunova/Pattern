using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.Text = 100.ToString();
            textBox2.Text = 120.ToString();
            textBox3.Text = 110.ToString();
            textBox4.Text = 130.ToString();
            textBox5.Text = 200.ToString();
            textBox6.Text = 300.ToString();
            t1 = textBox1;
            t2 = textBox2;
            t3 = textBox3;
            t4 = textBox4;
            t5 = textBox5;
            t6 = textBox6;
        }
        public static TextBox t1 = new TextBox();
        public static TextBox t2 = new TextBox();
        public static TextBox t3 = new TextBox();
        public static TextBox t4 = new TextBox();
        public static TextBox t5 = new TextBox();
        public static TextBox t6 = new TextBox();
       
    }
}
