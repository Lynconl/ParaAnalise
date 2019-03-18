using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBoxDigite.Text == "0")|| (operation_pressed))
                textBoxDigite.Clear();

            operation_pressed = false;
            Button b = (Button)sender;
            textBoxDigite.Text = textBoxDigite.Text + b.Text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxDigite.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(textBoxDigite.Text);
            operation_pressed = true;
            labelName.Text = value + " " + operation;
        }

        private void buttonResultado_Click(object sender, EventArgs e)
        {
            labelName.Text = "";
            switch (operation)
            {
                case "+":
                    textBoxDigite.Text = (value + Double.Parse(textBoxDigite.Text)).ToString();
                    break;
                case "-":
                    textBoxDigite.Text = (value - Double.Parse(textBoxDigite.Text)).ToString();
                    break;
                case "x":
                    textBoxDigite.Text = (value * Double.Parse(textBoxDigite.Text)).ToString();
                    break;
                case "/":
                    textBoxDigite.Text = (value / Double.Parse(textBoxDigite.Text)).ToString();
                    break;              
                default:
                    break;
            }//end switch
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
