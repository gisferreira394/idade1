namespace idade1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxmeses = new System.Windows.Forms.TextBox();
            this.textBoxdias = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(239, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxidade
            // 
            this.textBoxidade.Location = new System.Drawing.Point(28, 61);
            this.textBoxidade.Name = "textBoxidade";
            this.textBoxidade.Size = new System.Drawing.Size(100, 20);
            this.textBoxidade.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Indique sua idade";
            // 
            // textBoxmeses
            // 
            this.textBoxmeses.Location = new System.Drawing.Point(415, 61);
            this.textBoxmeses.Name = "textBoxmeses";
            this.textBoxmeses.Size = new System.Drawing.Size(100, 20);
            this.textBoxmeses.TabIndex = 3;
            // 
            // textBoxdias
            // 
            this.textBoxdias.Location = new System.Drawing.Point(212, 61);
            this.textBoxdias.Name = "textBoxdias";
            this.textBoxdias.Size = new System.Drawing.Size(100, 20);
            this.textBoxdias.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(410, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "idade expressa em meses.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(206, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "idade expressa em dias.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxdias);
            this.Controls.Add(this.textBoxmeses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxidade);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxmeses;
        private System.Windows.Forms.TextBox textBoxdias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

