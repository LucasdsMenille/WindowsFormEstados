namespace WindowsFormEstados
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
            this.todos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.norte = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nordeste = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.centro = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sudeste = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sul = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // todos
            // 
            this.todos.FormattingEnabled = true;
            this.todos.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "MG",
            "ES",
            "RS",
            "PR",
            "SC",
            "GO",
            "MT",
            "MS",
            "AM",
            "AC",
            "RO",
            "RR",
            "PA",
            "TO",
            "AP",
            "AL",
            "BA",
            "CE",
            "MAS",
            "PB",
            "PN",
            "PI",
            "RN",
            "SE"});
            this.todos.Location = new System.Drawing.Point(186, 49);
            this.todos.Name = "todos";
            this.todos.Size = new System.Drawing.Size(443, 21);
            this.todos.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Todos os estados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Região Norte:";
            // 
            // norte
            // 
            this.norte.FormattingEnabled = true;
            this.norte.Location = new System.Drawing.Point(186, 120);
            this.norte.Name = "norte";
            this.norte.Size = new System.Drawing.Size(443, 21);
            this.norte.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Região Centro-Oeste:";
            // 
            // nordeste
            // 
            this.nordeste.FormattingEnabled = true;
            this.nordeste.Location = new System.Drawing.Point(186, 162);
            this.nordeste.Name = "nordeste";
            this.nordeste.Size = new System.Drawing.Size(443, 21);
            this.nordeste.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Região Nordeste:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // centro
            // 
            this.centro.FormattingEnabled = true;
            this.centro.Location = new System.Drawing.Point(186, 208);
            this.centro.Name = "centro";
            this.centro.Size = new System.Drawing.Size(443, 21);
            this.centro.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Região Sudeste:";
            // 
            // sudeste
            // 
            this.sudeste.FormattingEnabled = true;
            this.sudeste.Location = new System.Drawing.Point(186, 253);
            this.sudeste.Name = "sudeste";
            this.sudeste.Size = new System.Drawing.Size(443, 21);
            this.sudeste.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Região Sul:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // sul
            // 
            this.sul.FormattingEnabled = true;
            this.sul.Location = new System.Drawing.Point(186, 300);
            this.sul.Name = "sul";
            this.sul.Size = new System.Drawing.Size(443, 21);
            this.sul.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 21);
            this.button1.TabIndex = 13;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(652, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 21);
            this.button2.TabIndex = 14;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(652, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 21);
            this.button3.TabIndex = 15;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(652, 204);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(29, 21);
            this.button4.TabIndex = 16;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(652, 253);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(29, 21);
            this.button5.TabIndex = 17;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(652, 300);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(29, 21);
            this.button6.TabIndex = 18;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(700, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(694, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "label8";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(694, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "label9";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(694, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "label10";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(694, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "label11";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(694, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "label12";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sul);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sudeste);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.centro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nordeste);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.norte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.todos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox todos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox norte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox nordeste;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox centro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox sudeste;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sul;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

