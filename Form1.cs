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
    

    public partial class Form1 : Form
    {
        AbstractCafe CafeOne = new Cafe1();
        AbstractCafe CafeTwo = new Cafe2();
        Form2 Price = new Form2();

        int[] sum;

        int PriceOpenPizza, PriceClosePizza, PriceOpenPizzaWihtSause, PriceClosePizzaWithVegetables;
        int BarbecuePig, BarbecueMutton;

      

        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            PriceOpenPizza = 0;
            PriceClosePizza = 0;
            PriceOpenPizzaWihtSause = 0;
            PriceClosePizzaWithVegetables = 0;
            BarbecuePig = 0;
            BarbecueMutton=0;


            if (radioButton1.Checked)
            {
                AbstractCafe A = CafeOne;
                int[] ingridients = new int[] { Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown3.Value) };
               
                textBox1.Text=A.CreatePizza(radioButton1.Text, ingridients).ToString();
                PriceOpenPizza = Int32.Parse(Form2.t1.Text);
            }
            if (radioButton1.Checked && checkBox2.Checked)
            {
                AbstractCafe A = CafeOne;
                int[] ingridients = new int[] { Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown3.Value) };
                AbstractPizza P = A.CreatePizza(radioButton1.Text, ingridients);
                DecorPizzaSause PizzaWithSause = new DecorPizzaSause(P);
                textBox1.Text = PizzaWithSause.AddSause();
                PriceOpenPizza = 0;
                PriceOpenPizzaWihtSause = Int32.Parse(Form2.t2.Text);
               

            }
            if (radioButton2.Checked)
            {
                AbstractCafe B = CafeTwo;
                int[] ingridients = new int[] { Convert.ToInt32(numericUpDown4.Value), Convert.ToInt32(numericUpDown5.Value) };
                textBox1.Text = B.CreatePizza(radioButton2.Text, ingridients).ToString();
                PriceClosePizza = Int32.Parse(Form2.t3.Text);
            }
            if (radioButton2.Checked && checkBox1.Checked)
            {
                AbstractCafe B = CafeTwo;
                int[] ingridients = new int[] { Convert.ToInt32(numericUpDown4.Value), Convert.ToInt32(numericUpDown5.Value) };
                AbstractPizza P = B.CreatePizza(radioButton2.Text, ingridients);
                DecorPizzaVegetables PizzaWithVegetables = new DecorPizzaVegetables(P);
                textBox1.Text = PizzaWithVegetables.AddVegetables();
                PriceClosePizza = 0;
                PriceClosePizzaWithVegetables = Int32.Parse(Form2.t4.Text);
            }

            if (checkBox3.Checked)
            {
                Handler contrete1Handler = new Contrete1Handler();
                Handler concrete2Handler = new Concrete2Handler();
                contrete1Handler.NextHandler = concrete2Handler;
                contrete1Handler.BarbecueLamb(textBox1, checkBox3.Text);
                BarbecuePig = Int32.Parse(Form2.t5.Text);
            }
         
             if (checkBox4.Checked)
            {
                Handler contrete1Handler = new Contrete1Handler();
                Handler concrete2Handler = new Concrete2Handler();
                contrete1Handler.NextHandler = concrete2Handler;
                contrete1Handler.BarbecueLamb(textBox1, checkBox4.Text);
                BarbecueMutton = Int32.Parse(Form2.t6.Text);
            }

            sum = new int[] {Convert.ToInt32(PriceOpenPizza*1.10),Convert.ToInt32(PriceClosePizza*1.2),
                             Convert.ToInt32(PriceOpenPizzaWihtSause*1.1),Convert.ToInt32(PriceClosePizzaWithVegetables*1.2),
                             Convert.ToInt32(BarbecuePig*1.1),Convert.ToInt32(BarbecueMutton*1.2) };
            
            textBox1.AppendText(Environment.NewLine + Environment.NewLine +
                                Environment.NewLine + Environment.NewLine +
                                Environment.NewLine + "ИТОГО       "
                                + sum.Sum());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            PriceOpenPizza = 0;
            PriceClosePizza = 0;
            PriceOpenPizzaWihtSause = 0;
            PriceClosePizzaWithVegetables = 0;
            BarbecuePig = 0;
            BarbecueMutton = 0;

            radioButton1.Visible = true;
            radioButton1.Checked = false;
            radioButton2.Visible = false;
            radioButton2.Checked = false;
            panel1.Visible = false;
            panel2.Visible = false;
            checkBox3.Visible = true;
            checkBox3.Checked = false;
            checkBox4.Visible = true;
            checkBox4.Checked = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            PriceOpenPizza = 0;
            PriceClosePizza = 0;
            PriceOpenPizzaWihtSause = 0;
            PriceClosePizzaWithVegetables = 0;
            BarbecuePig = 0;
            BarbecueMutton = 0;

            radioButton1.Visible = false;
            radioButton1.Checked = false;
            radioButton2.Visible = true;
            radioButton2.Checked = false;
            panel1.Visible = false;
            panel2.Visible = false;
            checkBox3.Visible = false;
            checkBox3.Checked = false;
            checkBox4.Visible = true;
            checkBox4.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Price.Show();
        }
    }
}
