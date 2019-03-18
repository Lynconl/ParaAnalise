using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class FormTabuada : Form
    {
        public FormTabuada()
        {
            InitializeComponent();
        }

        private void bttnCalcular_Click(object sender, EventArgs e)
        {
            int Valor;
            Valor = (int)numericUDNumero.Value;            
                        
            for (int x = 0; x <= 50; x++)
            {   
                richTxtBxTabuada.AppendText(Valor + " x " + x + " = " + Valor * x);     
                richTxtBxTabuada.AppendText(Environment.NewLine);
            }

            richTxtBxTabuada.AppendText(Environment.NewLine);



























            /*int Tabuada1, Tabuada2, Tabuada3, Tabuada4, Tabuada5, Tabuada6, Tabuada7, Tabuada8, Tabuada9, Tabuada10;
            

            Valor = (int)numericUDNumero.Value;

            Tabuada1 = Valor * 1;
            Tabuada2 = Valor * 2;
            Tabuada3 = Valor * 3;
            Tabuada4 = Valor * 4;
            Tabuada5 = Valor * 5;
            Tabuada6 = Valor * 6;
            Tabuada7 = Valor * 7;
            Tabuada8 = Valor * 8;
            Tabuada9 = Valor * 9;
            Tabuada10 = Valor * 10;

            Final = ((Valor + " x " + 1 + " = ") + Tabuada1 + Environment.NewLine + "" + (Valor + " x " + 2 + " = ") + Tabuada2 + Environment.NewLine + "" + (Valor + " x " + 3 + " = ") + Tabuada3 + Environment.NewLine + "" + (Valor + " x " + 4 + " = ") + Tabuada4 + Environment.NewLine + "" + (Valor + " x " + 5 + " = ") + Tabuada5 + Environment.NewLine + "" + (Valor + " x " + 6 + " = ") + Tabuada6 + Environment.NewLine + "" + (Valor + " x " + 7 + " = ") + Tabuada7 + Environment.NewLine + "" + (Valor + " x " + 8 + " = ") + Tabuada8 + Environment.NewLine + "" + (Valor + " x " + 9 + " = ") + Tabuada9 + Environment.NewLine + "" + (Valor + " x " + 10 + " = ") +  Tabuada10);
            //richTxtBxTabuada.Clear();
            richTxtBxTabuada.AppendText(Environment.NewLine);
            richTxtBxTabuada.AppendText(Final);
            richTxtBxTabuada.AppendText(Environment.NewLine);
            */
        }
    }
}
