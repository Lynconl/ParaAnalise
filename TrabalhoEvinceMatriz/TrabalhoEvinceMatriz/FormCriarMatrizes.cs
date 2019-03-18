using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoEvinceMatriz
{
    public partial class FormCriarMatrizes : Form
    {        
        public static int LinhasA, LinhasB, ColunasA, ColunasB;

        public FormCriarMatrizes()
        {
            InitializeComponent();
        }

        private bool bttnMontarBClick = false;        

        private void bttnMontarB_Click(object sender, EventArgs e)
        {
            bttnMontarBClick = true;
            LinhasB = (int)numericUDLinhasB.Value;
            ColunasB = (int)numericUDColunasB.Value;
            FormPrincipal.MatrizB = new double[LinhasB, ColunasB];

            preparaGridB();
        }

        private void preparaGridA()
        {
            dataGridViewA.RowCount = FormPrincipal.MatrizA.GetLength(0);
            dataGridViewA.ColumnCount = FormPrincipal.MatrizA.GetLength(1);

            for (int l = 0; l < FormPrincipal.MatrizA.GetLength(0); l++)
            {
                dataGridViewA.Rows[l].HeaderCell.Value = "i " + l.ToString();
            }

            for (int c = 0; c < FormPrincipal.MatrizA.GetLength(1); c++)
            {
                dataGridViewA.Columns[c].Name = "j " + c.ToString();
            }
        }

        private void bttnInserirValores_Click(object sender, EventArgs e)
        {
           for(int i=0; i < FormPrincipal.MatrizA.GetLength(0); i++)
            {
                for(int j=0; j < FormPrincipal.MatrizA.GetLength(1); j++)
                {
                    try
                    {
                        FormPrincipal.MatrizA[i, j] = Convert.ToDouble(dataGridViewA.Rows[i].Cells[j].Value.ToString());
                    } 
                    catch(Exception)
                    {
                        MessageBox.Show("Apenas Números");
                    }
                }
            }
           
            if(bttnMontarBClick == true)
            {               
                for (int i = 0; i < FormPrincipal.MatrizB.GetLength(0); i++)
                {
                    for (int j = 0; j < FormPrincipal.MatrizB.GetLength(1); j++)
                    {
                        try
                        {
                            FormPrincipal.MatrizB[i, j] = Convert.ToDouble(dataGridViewB.Rows[i].Cells[j].Value.ToString());
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Apenas Números");
                        }
                    }
                }

            }
                        

            this.Close();
            
        }        

        private void preparaGridB()
        {
            dataGridViewB.RowCount = FormPrincipal.MatrizB.GetLength(0);
            dataGridViewB.ColumnCount = FormPrincipal.MatrizB.GetLength(1);

            for (int l = 0; l < FormPrincipal.MatrizB.GetLength(0); l++)
            {
                dataGridViewB.Rows[l].HeaderCell.Value = "i " + l.ToString();
            }

            for (int c = 0; c < FormPrincipal.MatrizB.GetLength(1); c++)
            {
                dataGridViewB.Columns[c].Name = "j " + c.ToString();
            }
        }
        private void mostragrid()
        {
            //percorre todas as Linhas
            for (int l = 0; l < FormPrincipal.MatrizA.GetLength(0); l++)
            {
                //Percorre todas as colunas
                for (int c = 0; c < FormPrincipal.MatrizA.GetLength(0); c++)
                {
                    //seta o valor a ser mostrado no grid de dacordo com a posição correspondente da matriz
                    dataGridViewA.Rows[l].Cells[c].Value = FormPrincipal.MatrizA[l, c];
                }
            }
        }

        private void bttnMontarA_Click(object sender, EventArgs e)
        {
            LinhasA = (int)numericUDLinhasA.Value;
            ColunasA = (int)numericUDColunasA.Value;
            FormPrincipal.MatrizA = new double[LinhasA, ColunasA];

            preparaGridA();      
        }
    }
}
