namespace Tabuada
{
    partial class FormTabuada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTxtBxTabuada = new System.Windows.Forms.RichTextBox();
            this.bttnCalcular = new System.Windows.Forms.Button();
            this.lblInformeNumero = new System.Windows.Forms.Label();
            this.numericUDNumero = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // richTxtBxTabuada
            // 
            this.richTxtBxTabuada.BackColor = System.Drawing.SystemColors.WindowText;
            this.richTxtBxTabuada.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBxTabuada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTxtBxTabuada.Location = new System.Drawing.Point(12, 54);
            this.richTxtBxTabuada.Name = "richTxtBxTabuada";
            this.richTxtBxTabuada.Size = new System.Drawing.Size(483, 370);
            this.richTxtBxTabuada.TabIndex = 0;
            this.richTxtBxTabuada.Text = "";
            // 
            // bttnCalcular
            // 
            this.bttnCalcular.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnCalcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bttnCalcular.Location = new System.Drawing.Point(393, 9);
            this.bttnCalcular.Name = "bttnCalcular";
            this.bttnCalcular.Size = new System.Drawing.Size(102, 39);
            this.bttnCalcular.TabIndex = 1;
            this.bttnCalcular.Text = "Calcular";
            this.bttnCalcular.UseVisualStyleBackColor = false;
            this.bttnCalcular.Click += new System.EventHandler(this.bttnCalcular_Click);
            // 
            // lblInformeNumero
            // 
            this.lblInformeNumero.AutoSize = true;
            this.lblInformeNumero.Location = new System.Drawing.Point(12, 9);
            this.lblInformeNumero.Name = "lblInformeNumero";
            this.lblInformeNumero.Size = new System.Drawing.Size(144, 23);
            this.lblInformeNumero.TabIndex = 2;
            this.lblInformeNumero.Text = "Informe Número:";
            // 
            // numericUDNumero
            // 
            this.numericUDNumero.Location = new System.Drawing.Point(175, 12);
            this.numericUDNumero.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUDNumero.Name = "numericUDNumero";
            this.numericUDNumero.Size = new System.Drawing.Size(188, 30);
            this.numericUDNumero.TabIndex = 3;
            this.numericUDNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUDNumero.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // FormTabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(508, 436);
            this.Controls.Add(this.numericUDNumero);
            this.Controls.Add(this.lblInformeNumero);
            this.Controls.Add(this.bttnCalcular);
            this.Controls.Add(this.richTxtBxTabuada);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormTabuada";
            this.Text = "Tabuada";
            ((System.ComponentModel.ISupportInitialize)(this.numericUDNumero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxtBxTabuada;
        private System.Windows.Forms.Button bttnCalcular;
        private System.Windows.Forms.Label lblInformeNumero;
        private System.Windows.Forms.NumericUpDown numericUDNumero;
    }
}

