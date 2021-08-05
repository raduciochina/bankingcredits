
namespace AplicatieBanking
{
    partial class Curs
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbData = new System.Windows.Forms.TextBox();
            this.tbUSD = new System.Windows.Forms.TextBox();
            this.tbEUR = new System.Windows.Forms.TextBox();
            this.tbGBP = new System.Windows.Forms.TextBox();
            this.tbXAU = new System.Windows.Forms.TextBox();
            this.btnParsare = new System.Windows.Forms.Button();
            this.btnGenerare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data curs :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "EUR :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "USD :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "GBP :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "XAU :";
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(182, 79);
            this.tbData.Name = "tbData";
            this.tbData.ReadOnly = true;
            this.tbData.Size = new System.Drawing.Size(100, 26);
            this.tbData.TabIndex = 6;
            // 
            // tbUSD
            // 
            this.tbUSD.Location = new System.Drawing.Point(182, 235);
            this.tbUSD.Name = "tbUSD";
            this.tbUSD.ReadOnly = true;
            this.tbUSD.Size = new System.Drawing.Size(100, 26);
            this.tbUSD.TabIndex = 7;
            // 
            // tbEUR
            // 
            this.tbEUR.Location = new System.Drawing.Point(182, 157);
            this.tbEUR.Name = "tbEUR";
            this.tbEUR.ReadOnly = true;
            this.tbEUR.Size = new System.Drawing.Size(100, 26);
            this.tbEUR.TabIndex = 8;
            // 
            // tbGBP
            // 
            this.tbGBP.Location = new System.Drawing.Point(182, 316);
            this.tbGBP.Name = "tbGBP";
            this.tbGBP.ReadOnly = true;
            this.tbGBP.Size = new System.Drawing.Size(100, 26);
            this.tbGBP.TabIndex = 9;
            // 
            // tbXAU
            // 
            this.tbXAU.Location = new System.Drawing.Point(182, 392);
            this.tbXAU.Name = "tbXAU";
            this.tbXAU.ReadOnly = true;
            this.tbXAU.Size = new System.Drawing.Size(100, 26);
            this.tbXAU.TabIndex = 10;
            // 
            // btnParsare
            // 
            this.btnParsare.Location = new System.Drawing.Point(69, 458);
            this.btnParsare.Name = "btnParsare";
            this.btnParsare.Size = new System.Drawing.Size(122, 62);
            this.btnParsare.TabIndex = 11;
            this.btnParsare.Text = "PARSARE";
            this.btnParsare.UseVisualStyleBackColor = true;
            this.btnParsare.Click += new System.EventHandler(this.btnParsare_Click);
            // 
            // btnGenerare
            // 
            this.btnGenerare.Location = new System.Drawing.Point(208, 458);
            this.btnGenerare.Name = "btnGenerare";
            this.btnGenerare.Size = new System.Drawing.Size(122, 62);
            this.btnGenerare.TabIndex = 12;
            this.btnGenerare.Text = "GENERARE";
            this.btnGenerare.UseVisualStyleBackColor = true;
            this.btnGenerare.Click += new System.EventHandler(this.btnGenerare_Click);
            // 
            // Curs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(433, 553);
            this.Controls.Add(this.btnGenerare);
            this.Controls.Add(this.btnParsare);
            this.Controls.Add(this.tbXAU);
            this.Controls.Add(this.tbGBP);
            this.Controls.Add(this.tbEUR);
            this.Controls.Add(this.tbUSD);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Curs";
            this.Text = "Curs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.TextBox tbUSD;
        private System.Windows.Forms.TextBox tbEUR;
        private System.Windows.Forms.TextBox tbGBP;
        private System.Windows.Forms.TextBox tbXAU;
        private System.Windows.Forms.Button btnParsare;
        private System.Windows.Forms.Button btnGenerare;
    }
}