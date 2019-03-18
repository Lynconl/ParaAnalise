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
    public partial class FormPrincipal : Form
    {
        public static double[,] MatrizA;
        public static double[,] MatrizB;
        public static double[,] MatrizC;
        public static double Determinante;

        public FormPrincipal()
        {
            InitializeComponent();
        }        

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bttnCriarMatriz_Click(object sender, EventArgs e)
        {
            FormCriarMatrizes View = new FormCriarMatrizes();
            View.ShowDialog();
        }

        private void preparaGridC()
        {
            dataGridMatrizC.RowCount = MatrizC.GetLength(0);
            dataGridMatrizC.ColumnCount = MatrizC.GetLength(1);

            for (int l = 0; l < MatrizC.GetLength(0); l++)
            {
                dataGridMatrizC.Rows[l].HeaderCell.Value = "i " + l.ToString();
            }

            for (int c = 0; c < MatrizC.GetLength(1); c++)
            {
                dataGridMatrizC.Columns[c].Name = "j " + c.ToString();
            }
        }

        private void somaDeABToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MatrizA.Length == MatrizB.Length)
            {
                MatrizC = new double[MatrizB.GetLength(0), MatrizA.GetLength(1)];
                preparaGridC();

                // A + B
                for (int g = 0; g < MatrizA.GetLength(0); g++)
                {
                    for (int k = 0; k < MatrizA.GetLength(1); k++)
                    {
                        MatrizC[g, k] = MatrizA[g, k] + MatrizB[g, k];
                        dataGridMatrizC.Rows[g].Cells[k].Value = MatrizC[g, k];
                    }
                }
            }
            else
            {
                MessageBox.Show("Apenas Matrizes de mesma ordem", "Atenção");
            }
            
        }

        private void aBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MatrizA.Length == MatrizB.Length)
            {
                MatrizC = new double[MatrizB.GetLength(0), MatrizA.GetLength(1)];
                preparaGridC();

                // A - B
                for (int g = 0; g < MatrizA.GetLength(0); g++)
                {
                    for (int k = 0; k < MatrizA.GetLength(1); k++)
                    {
                        MatrizC[g, k] = MatrizA[g, k] - MatrizB[g, k];
                        dataGridMatrizC.Rows[g].Cells[k].Value = MatrizC[g, k];
                    }
                }
            }
            else
            {
                MessageBox.Show("Apenas Matrizes de mesma ordem", "Atenção");
            }

        }

        private void aBToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Definir tamanho MatrizC!
            if (MatrizA.GetLength(1) != MatrizB.GetLength(0))
            {
                MessageBox.Show("Não é foi possível calcular, mais informações na aba formúlas.", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MatrizC = new double[MatrizA.GetLength(0), MatrizB.GetLength(1)];
                preparaGridC();
                for (int i = 0; i < MatrizA.GetLength(0); i++)
                {
                    for (int j = 0; j < MatrizB.GetLength(1); j++)
                    {
                        for (int k = 0; k < MatrizB.GetLength(0); k++)
                        {
                            MatrizC[i, j] += MatrizA[i, k] * MatrizB[k, j];
                            dataGridMatrizC.Rows[i].Cells[j].Value = MatrizC[i, j];
                        }
                    }
                }
            }

            

        }

        private void detAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(FormCriarMatrizes.ColunasA == FormCriarMatrizes.LinhasA)
            {
                if(FormCriarMatrizes.LinhasA == 2)
                {
                    Determinante = (MatrizA[0, 0] * MatrizA[1, 1]) - (MatrizA[1, 0] * MatrizA[0, 1]);
                }
                else
                if(FormCriarMatrizes.LinhasA == 3)
                {                    
                    for(int j=0; j <= 3; j++)
                    {
                        Determinante = (MatrizA[0, 0] * MatrizA[1, 1] * MatrizA[2, 2]) + (MatrizA[0, 1] * MatrizA[1, 2]
                            * MatrizA[2, 0]) + (MatrizA[0, 2] * MatrizA[1, 0] * MatrizA[2, 1]) - (MatrizA[0, 1] *
                            MatrizA[1, 0] * MatrizA[2, 2]) - (MatrizA[0, 0] * MatrizA[1, 2] * MatrizA[2, 1]) -
                            (MatrizA[0, 2] * MatrizA[1, 1] * MatrizA[2, 0]);
                    }                    
                }
                else
                {
                    MessageBox.Show("Em construção", "Atenção");
                }
            }
            else
            {
                MessageBox.Show("Está Matriz não é quadrada!", "Apenas Matrizes Quadradas");
            }

            MessageBox.Show("Valor do detA = " + Determinante.ToString());
        }

        private void detBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormCriarMatrizes.ColunasB == FormCriarMatrizes.LinhasB)
            {
                if (FormCriarMatrizes.LinhasB == 2)
                {
                    Determinante = (MatrizB[0, 0] * MatrizB[1, 1]) - (MatrizB[1, 0] * MatrizB[0, 1]);
                }
                else
                if (FormCriarMatrizes.LinhasB == 3)
                {
                    for (int j = 0; j <= 3; j++)
                    {
                        Determinante = (MatrizB[0, 0] * MatrizB[1, 1] * MatrizB[2, 2]) + (MatrizB[0, 1] * MatrizB[1, 2]
                            * MatrizB[2, 0]) + (MatrizB[0, 2] * MatrizB[1, 0] * MatrizB[2, 1]) - (MatrizB[0, 1] *
                           MatrizB[1, 0] * MatrizB[2, 2]) - (MatrizB[0, 0] * MatrizB[1, 2] * MatrizB[2, 1]) -
                            (MatrizB[0, 2] * MatrizB[1, 1] * MatrizB[2, 0]);
                    }
                }
                else
                {
                    MessageBox.Show("Em construção", "Atenção");
                }
            }
            else
            {
                MessageBox.Show("Está Matriz não é quadrada!", "Apenas Matrizes Quadradas");
            }

            MessageBox.Show("Valor do detB = " + Determinante.ToString());
        }

        private void detCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MatrizC.GetLength(0) == MatrizC.GetLength(1))
            {
                if (MatrizC.GetLength(0) == 2)
                {
                    Determinante = (MatrizC[0, 0] * MatrizC[1, 1]) - (MatrizC[1, 0] * MatrizC[0, 1]);
                }
                else
                if (MatrizC.GetLength(0) == 3)
                {
                    for (int j = 0; j <= 3; j++)
                    {
                        Determinante = (MatrizC[0, 0] * MatrizC[1, 1] * MatrizC[2, 2]) + (MatrizC[0, 1] * MatrizC[1, 2]
                            * MatrizC[2, 0]) + (MatrizC[0, 2] * MatrizC[1, 0] * MatrizC[2, 1]) - (MatrizC[0, 1] *
                           MatrizC[1, 0] * MatrizC[2, 2]) - (MatrizC[0, 0] * MatrizC[1, 2] * MatrizC[2, 1]) -
                            (MatrizC[0, 2] * MatrizC[1, 1] * MatrizC[2, 0]);
                    }
                }
                else
                {
                    MessageBox.Show("Em construção", "Atenção");
                }
            }
            else
            {
                MessageBox.Show("Está Matriz não é quadrada!", "Apenas Matrizes Quadradas");
            }

            MessageBox.Show("Valor do detC = " + Determinante.ToString());

        }
    }
}
