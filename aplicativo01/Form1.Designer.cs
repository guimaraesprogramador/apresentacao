namespace aplicativo01
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
			this.texto = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(92, 90);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "criar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.test);
			// 
			// texto
			// 
			this.texto.Location = new System.Drawing.Point(123, 12);
			this.texto.Name = "texto";
			this.texto.Size = new System.Drawing.Size(288, 20);
			this.texto.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(68, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "texto:";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(189, 90);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "lancar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "thread[0]";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(290, 90);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 5;
			this.button3.Text = "parar";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.parando);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(401, 90);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 6;
			this.button4.Text = "excluir";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.excluir0);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 157);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Thread[1]";
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(92, 152);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 8;
			this.button5.Text = "criar";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.criar0);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(189, 147);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 9;
			this.button6.Text = "lancar";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.lancar0);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(290, 152);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 23);
			this.button7.TabIndex = 10;
			this.button7.Text = "parar";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.parar0);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(401, 157);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(75, 23);
			this.button8.TabIndex = 11;
			this.button8.Text = "excluir";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.excluir1);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(92, 208);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(75, 23);
			this.button9.TabIndex = 12;
			this.button9.Text = "criar";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.criar2);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(26, 218);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "Thread[2]";
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(189, 208);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(75, 23);
			this.button10.TabIndex = 14;
			this.button10.Text = "lancar";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.lancar2);
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(290, 208);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(75, 23);
			this.button11.TabIndex = 15;
			this.button11.Text = "parar";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.parar);
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(401, 208);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(75, 23);
			this.button12.TabIndex = 16;
			this.button12.Text = "excluir";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.excluir2);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(646, 292);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.texto);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		public System.Windows.Forms.TextBox texto;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button12;
	}
}

