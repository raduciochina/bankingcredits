
namespace AplicatieBanking
{
    partial class Preluare_credit
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
            this.btnCalcul = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbRata = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPerioada = new System.Windows.Forms.TextBox();
            this.tbSuma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hScrollBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcul
            // 
            this.btnCalcul.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcul.Location = new System.Drawing.Point(51, 510);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(166, 55);
            this.btnCalcul.TabIndex = 32;
            this.btnCalcul.Text = "Calculeaza";
            this.btnCalcul.UseVisualStyleBackColor = true;
            this.btnCalcul.Click += new System.EventHandler(this.btnCalcul_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(172, 399);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(179, 26);
            this.textBox2.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Suma de plata/luna :";
            // 
            // tbRata
            // 
            this.tbRata.Location = new System.Drawing.Point(172, 327);
            this.tbRata.Name = "tbRata";
            this.tbRata.ReadOnly = true;
            this.tbRata.Size = new System.Drawing.Size(179, 26);
            this.tbRata.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Rata dobanda :";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(146, 214);
            this.hScrollBar1.Maximum = 30;
            this.hScrollBar1.Minimum = 1;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(232, 69);
            this.hScrollBar1.TabIndex = 1;
            this.hScrollBar1.Value = 1;
            this.hScrollBar1.Scroll += new System.EventHandler(this.hScrollBar1_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "ani";
            // 
            // tbPerioada
            // 
            this.tbPerioada.Location = new System.Drawing.Point(384, 218);
            this.tbPerioada.Name = "tbPerioada";
            this.tbPerioada.Size = new System.Drawing.Size(46, 26);
            this.tbPerioada.TabIndex = 26;
            this.tbPerioada.TextChanged += new System.EventHandler(this.tbPerioada_TextChanged);
            // 
            // tbSuma
            // 
            this.tbSuma.Location = new System.Drawing.Point(146, 142);
            this.tbSuma.Name = "tbSuma";
            this.tbSuma.Size = new System.Drawing.Size(227, 26);
            this.tbSuma.TabIndex = 25;
            this.tbSuma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSuma_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Durata credit :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Suma credit :";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(268, 510);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(162, 54);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(146, 27);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 28);
            this.comboBox1.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Client:";
            // 
            // cbTip
            // 
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Items.AddRange(new object[] {
            "NEVOI PERSONALE",
            "LEASING",
            "IMOBILIARE",
            "STUDII",
            "MEDICAL"});
            this.cbTip.Location = new System.Drawing.Point(146, 83);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(227, 28);
            this.cbTip.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Tip credit :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 30);
            this.label3.TabIndex = 37;
            this.label3.Text = "% / an";
            // 
            // Preluare_credit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 602);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnCalcul);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbRata);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPerioada);
            this.Controls.Add(this.tbSuma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Name = "Preluare_credit";
            this.Text = "Preluare_credit";
            ((System.ComponentModel.ISupportInitialize)(this.hScrollBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcul;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbRata;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar hScrollBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPerioada;
        private System.Windows.Forms.TextBox tbSuma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}