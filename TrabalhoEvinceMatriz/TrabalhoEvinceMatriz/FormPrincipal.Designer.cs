namespace TrabalhoEvinceMatriz
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.somaDeABToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inversaDeAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.determinanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casoElaExistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formúlasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.somaDeMatrizesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subtraçãoDeMatrizesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicaçãoDeMatrizesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrizInversaAˉToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagonalPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.determinanteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.x1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nxNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dúvidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sIANCentroUniversitárioAutônomoDoBrasilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridMatrizC = new System.Windows.Forms.DataGridView();
            this.bttnCriarMatriz = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatrizC)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operaçõesToolStripMenuItem,
            this.determinanteToolStripMenuItem,
            this.formúlasToolStripMenuItem,
            this.dúvidasToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sIANCentroUniversitárioAutônomoDoBrasilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(547, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStripInicial";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // operaçõesToolStripMenuItem
            // 
            this.operaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.somaDeABToolStripMenuItem,
            this.aBToolStripMenuItem,
            this.aBToolStripMenuItem1,
            this.inversaDeAToolStripMenuItem});
            this.operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            this.operaçõesToolStripMenuItem.Size = new System.Drawing.Size(117, 32);
            this.operaçõesToolStripMenuItem.Text = "Operações";
            // 
            // somaDeABToolStripMenuItem
            // 
            this.somaDeABToolStripMenuItem.Name = "somaDeABToolStripMenuItem";
            this.somaDeABToolStripMenuItem.Size = new System.Drawing.Size(138, 32);
            this.somaDeABToolStripMenuItem.Text = "A + B";
            this.somaDeABToolStripMenuItem.Click += new System.EventHandler(this.somaDeABToolStripMenuItem_Click);
            // 
            // aBToolStripMenuItem
            // 
            this.aBToolStripMenuItem.Name = "aBToolStripMenuItem";
            this.aBToolStripMenuItem.Size = new System.Drawing.Size(138, 32);
            this.aBToolStripMenuItem.Text = "A - B";
            this.aBToolStripMenuItem.Click += new System.EventHandler(this.aBToolStripMenuItem_Click);
            // 
            // aBToolStripMenuItem1
            // 
            this.aBToolStripMenuItem1.Name = "aBToolStripMenuItem1";
            this.aBToolStripMenuItem1.Size = new System.Drawing.Size(138, 32);
            this.aBToolStripMenuItem1.Text = "A * B";
            this.aBToolStripMenuItem1.Click += new System.EventHandler(this.aBToolStripMenuItem1_Click);
            // 
            // inversaDeAToolStripMenuItem
            // 
            this.inversaDeAToolStripMenuItem.Name = "inversaDeAToolStripMenuItem";
            this.inversaDeAToolStripMenuItem.Size = new System.Drawing.Size(138, 32);
            this.inversaDeAToolStripMenuItem.Text = "Aˉ¹";
            // 
            // determinanteToolStripMenuItem
            // 
            this.determinanteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detAToolStripMenuItem,
            this.detBToolStripMenuItem,
            this.detCToolStripMenuItem});
            this.determinanteToolStripMenuItem.Name = "determinanteToolStripMenuItem";
            this.determinanteToolStripMenuItem.Size = new System.Drawing.Size(143, 32);
            this.determinanteToolStripMenuItem.Text = "Determinante";
            // 
            // detAToolStripMenuItem
            // 
            this.detAToolStripMenuItem.Name = "detAToolStripMenuItem";
            this.detAToolStripMenuItem.Size = new System.Drawing.Size(216, 32);
            this.detAToolStripMenuItem.Text = "detA";
            this.detAToolStripMenuItem.Click += new System.EventHandler(this.detAToolStripMenuItem_Click);
            // 
            // detBToolStripMenuItem
            // 
            this.detBToolStripMenuItem.Name = "detBToolStripMenuItem";
            this.detBToolStripMenuItem.Size = new System.Drawing.Size(216, 32);
            this.detBToolStripMenuItem.Text = "detB";
            this.detBToolStripMenuItem.Click += new System.EventHandler(this.detBToolStripMenuItem_Click);
            // 
            // detCToolStripMenuItem
            // 
            this.detCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.casoElaExistaToolStripMenuItem});
            this.detCToolStripMenuItem.Name = "detCToolStripMenuItem";
            this.detCToolStripMenuItem.Size = new System.Drawing.Size(216, 32);
            this.detCToolStripMenuItem.Text = "\"detC\"";
            this.detCToolStripMenuItem.Click += new System.EventHandler(this.detCToolStripMenuItem_Click);
            // 
            // casoElaExistaToolStripMenuItem
            // 
            this.casoElaExistaToolStripMenuItem.Name = "casoElaExistaToolStripMenuItem";
            this.casoElaExistaToolStripMenuItem.Size = new System.Drawing.Size(220, 32);
            this.casoElaExistaToolStripMenuItem.Text = "Caso ela exista.";
            // 
            // formúlasToolStripMenuItem
            // 
            this.formúlasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.somaDeMatrizesToolStripMenuItem,
            this.subtraçãoDeMatrizesToolStripMenuItem,
            this.multiplicaçãoDeMatrizesToolStripMenuItem,
            this.matrizInversaAˉToolStripMenuItem,
            this.diagonalPrincipalToolStripMenuItem,
            this.determinanteToolStripMenuItem1});
            this.formúlasToolStripMenuItem.Name = "formúlasToolStripMenuItem";
            this.formúlasToolStripMenuItem.Size = new System.Drawing.Size(104, 32);
            this.formúlasToolStripMenuItem.Text = "Formúlas";
            // 
            // somaDeMatrizesToolStripMenuItem
            // 
            this.somaDeMatrizesToolStripMenuItem.Name = "somaDeMatrizesToolStripMenuItem";
            this.somaDeMatrizesToolStripMenuItem.Size = new System.Drawing.Size(314, 32);
            this.somaDeMatrizesToolStripMenuItem.Text = "Soma de Matrizes";
            // 
            // subtraçãoDeMatrizesToolStripMenuItem
            // 
            this.subtraçãoDeMatrizesToolStripMenuItem.Name = "subtraçãoDeMatrizesToolStripMenuItem";
            this.subtraçãoDeMatrizesToolStripMenuItem.Size = new System.Drawing.Size(314, 32);
            this.subtraçãoDeMatrizesToolStripMenuItem.Text = "Subtração de Matrizes";
            // 
            // multiplicaçãoDeMatrizesToolStripMenuItem
            // 
            this.multiplicaçãoDeMatrizesToolStripMenuItem.Name = "multiplicaçãoDeMatrizesToolStripMenuItem";
            this.multiplicaçãoDeMatrizesToolStripMenuItem.Size = new System.Drawing.Size(314, 32);
            this.multiplicaçãoDeMatrizesToolStripMenuItem.Text = "Multiplicação de Matrizes";
            // 
            // matrizInversaAˉToolStripMenuItem
            // 
            this.matrizInversaAˉToolStripMenuItem.Name = "matrizInversaAˉToolStripMenuItem";
            this.matrizInversaAˉToolStripMenuItem.Size = new System.Drawing.Size(314, 32);
            this.matrizInversaAˉToolStripMenuItem.Text = "Matriz Inversa Aˉ¹";
            // 
            // diagonalPrincipalToolStripMenuItem
            // 
            this.diagonalPrincipalToolStripMenuItem.Name = "diagonalPrincipalToolStripMenuItem";
            this.diagonalPrincipalToolStripMenuItem.Size = new System.Drawing.Size(314, 32);
            this.diagonalPrincipalToolStripMenuItem.Text = "Diagonais";
            // 
            // determinanteToolStripMenuItem1
            // 
            this.determinanteToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x1ToolStripMenuItem,
            this.x2ToolStripMenuItem,
            this.x3ToolStripMenuItem,
            this.x4ToolStripMenuItem,
            this.nxNToolStripMenuItem});
            this.determinanteToolStripMenuItem1.Name = "determinanteToolStripMenuItem1";
            this.determinanteToolStripMenuItem1.Size = new System.Drawing.Size(314, 32);
            this.determinanteToolStripMenuItem1.Text = "Determinante";
            // 
            // x1ToolStripMenuItem
            // 
            this.x1ToolStripMenuItem.Name = "x1ToolStripMenuItem";
            this.x1ToolStripMenuItem.Size = new System.Drawing.Size(129, 32);
            this.x1ToolStripMenuItem.Text = "1x1";
            // 
            // x2ToolStripMenuItem
            // 
            this.x2ToolStripMenuItem.Name = "x2ToolStripMenuItem";
            this.x2ToolStripMenuItem.Size = new System.Drawing.Size(129, 32);
            this.x2ToolStripMenuItem.Text = "2x2";
            // 
            // x3ToolStripMenuItem
            // 
            this.x3ToolStripMenuItem.Name = "x3ToolStripMenuItem";
            this.x3ToolStripMenuItem.Size = new System.Drawing.Size(129, 32);
            this.x3ToolStripMenuItem.Text = "3x3";
            // 
            // x4ToolStripMenuItem
            // 
            this.x4ToolStripMenuItem.Name = "x4ToolStripMenuItem";
            this.x4ToolStripMenuItem.Size = new System.Drawing.Size(129, 32);
            this.x4ToolStripMenuItem.Text = "4x4";
            // 
            // nxNToolStripMenuItem
            // 
            this.nxNToolStripMenuItem.Name = "nxNToolStripMenuItem";
            this.nxNToolStripMenuItem.Size = new System.Drawing.Size(129, 32);
            this.nxNToolStripMenuItem.Text = "NxN";
            // 
            // dúvidasToolStripMenuItem
            // 
            this.dúvidasToolStripMenuItem.Name = "dúvidasToolStripMenuItem";
            this.dúvidasToolStripMenuItem.Size = new System.Drawing.Size(94, 32);
            this.dúvidasToolStripMenuItem.Text = "Dúvidas";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(76, 32);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // sIANCentroUniversitárioAutônomoDoBrasilToolStripMenuItem
            // 
            this.sIANCentroUniversitárioAutônomoDoBrasilToolStripMenuItem.Name = "sIANCentroUniversitárioAutônomoDoBrasilToolStripMenuItem";
            this.sIANCentroUniversitárioAutônomoDoBrasilToolStripMenuItem.Size = new System.Drawing.Size(498, 32);
            this.sIANCentroUniversitárioAutônomoDoBrasilToolStripMenuItem.Text = "      2SIAN --- Centro Universitário Autônomo do Brasil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(222, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matriz C";
            // 
            // dataGridMatrizC
            // 
            this.dataGridMatrizC.AllowUserToAddRows = false;
            this.dataGridMatrizC.AllowUserToDeleteRows = false;
            this.dataGridMatrizC.BackgroundColor = System.Drawing.Color.White;
            this.dataGridMatrizC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMatrizC.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridMatrizC.Location = new System.Drawing.Point(12, 144);
            this.dataGridMatrizC.Name = "dataGridMatrizC";
            this.dataGridMatrizC.ReadOnly = true;
            this.dataGridMatrizC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridMatrizC.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridMatrizC.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGridMatrizC.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridMatrizC.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridMatrizC.RowTemplate.Height = 24;
            this.dataGridMatrizC.Size = new System.Drawing.Size(519, 290);
            this.dataGridMatrizC.TabIndex = 3;
            // 
            // bttnCriarMatriz
            // 
            this.bttnCriarMatriz.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.bttnCriarMatriz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnCriarMatriz.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnCriarMatriz.FlatAppearance.BorderSize = 2;
            this.bttnCriarMatriz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCriarMatriz.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCriarMatriz.ForeColor = System.Drawing.Color.White;
            this.bttnCriarMatriz.Location = new System.Drawing.Point(12, 50);
            this.bttnCriarMatriz.Name = "bttnCriarMatriz";
            this.bttnCriarMatriz.Size = new System.Drawing.Size(519, 37);
            this.bttnCriarMatriz.TabIndex = 5;
            this.bttnCriarMatriz.Text = "Criar Matrizes";
            this.bttnCriarMatriz.UseVisualStyleBackColor = false;
            this.bttnCriarMatriz.Click += new System.EventHandler(this.bttnCriarMatriz_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(547, 446);
            this.Controls.Add(this.bttnCriarMatriz);
            this.Controls.Add(this.dataGridMatrizC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatrizC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem somaDeABToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inversaDeAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem determinanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formúlasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dúvidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casoElaExistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem somaDeMatrizesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subtraçãoDeMatrizesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicaçãoDeMatrizesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrizInversaAˉToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagonalPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem determinanteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem x1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nxNToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridMatrizC;
        private System.Windows.Forms.Button bttnCriarMatriz;
        private System.Windows.Forms.ToolStripMenuItem sIANCentroUniversitárioAutônomoDoBrasilToolStripMenuItem;
    }
}

