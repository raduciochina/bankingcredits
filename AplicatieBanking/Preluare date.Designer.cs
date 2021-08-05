
namespace AplicatieBanking
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbSalariu = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbStare = new System.Windows.Forms.GroupBox();
            this.rbCasatorit = new System.Windows.Forms.RadioButton();
            this.rbNecasatorit = new System.Windows.Forms.RadioButton();
            this.gbSex = new System.Windows.Forms.GroupBox();
            this.rbFeminin = new System.Windows.Forms.RadioButton();
            this.rbMasculin = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.gbStare.SuspendLayout();
            this.gbSex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data nastere :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Venit lunar :";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(159, 34);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(251, 26);
            this.tbNume.TabIndex = 4;
            this.tbNume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNume_KeyPress);
            // 
            // tbSalariu
            // 
            this.tbSalariu.Location = new System.Drawing.Point(159, 84);
            this.tbSalariu.Name = "tbSalariu";
            this.tbSalariu.Size = new System.Drawing.Size(251, 26);
            this.tbSalariu.TabIndex = 5;
            this.tbSalariu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSalariu_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(147, 142);
            this.dateTimePicker1.MaxDate = new System.DateTime(2003, 5, 24, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(308, 26);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2003, 5, 24, 0, 0, 0, 0);
            // 
            // gbStare
            // 
            this.gbStare.Controls.Add(this.rbCasatorit);
            this.gbStare.Controls.Add(this.rbNecasatorit);
            this.gbStare.Location = new System.Drawing.Point(59, 204);
            this.gbStare.Name = "gbStare";
            this.gbStare.Size = new System.Drawing.Size(396, 100);
            this.gbStare.TabIndex = 8;
            this.gbStare.TabStop = false;
            this.gbStare.Text = "Stare civila";
            // 
            // rbCasatorit
            // 
            this.rbCasatorit.AutoSize = true;
            this.rbCasatorit.Location = new System.Drawing.Point(20, 38);
            this.rbCasatorit.Name = "rbCasatorit";
            this.rbCasatorit.Size = new System.Drawing.Size(98, 24);
            this.rbCasatorit.TabIndex = 2;
            this.rbCasatorit.TabStop = true;
            this.rbCasatorit.Text = "Casatorit";
            this.rbCasatorit.UseVisualStyleBackColor = true;
            // 
            // rbNecasatorit
            // 
            this.rbNecasatorit.AutoSize = true;
            this.rbNecasatorit.Location = new System.Drawing.Point(224, 38);
            this.rbNecasatorit.Name = "rbNecasatorit";
            this.rbNecasatorit.Size = new System.Drawing.Size(115, 24);
            this.rbNecasatorit.TabIndex = 1;
            this.rbNecasatorit.TabStop = true;
            this.rbNecasatorit.Text = "Necasatorit";
            this.rbNecasatorit.UseVisualStyleBackColor = true;
            // 
            // gbSex
            // 
            this.gbSex.Controls.Add(this.rbFeminin);
            this.gbSex.Controls.Add(this.rbMasculin);
            this.gbSex.Location = new System.Drawing.Point(59, 310);
            this.gbSex.Name = "gbSex";
            this.gbSex.Size = new System.Drawing.Size(396, 100);
            this.gbSex.TabIndex = 9;
            this.gbSex.TabStop = false;
            this.gbSex.Text = "Sex";
            // 
            // rbFeminin
            // 
            this.rbFeminin.AutoSize = true;
            this.rbFeminin.Location = new System.Drawing.Point(224, 40);
            this.rbFeminin.Name = "rbFeminin";
            this.rbFeminin.Size = new System.Drawing.Size(90, 24);
            this.rbFeminin.TabIndex = 1;
            this.rbFeminin.TabStop = true;
            this.rbFeminin.Text = "Feminin";
            this.rbFeminin.UseVisualStyleBackColor = true;
            // 
            // rbMasculin
            // 
            this.rbMasculin.AutoSize = true;
            this.rbMasculin.Location = new System.Drawing.Point(20, 40);
            this.rbMasculin.Name = "rbMasculin";
            this.rbMasculin.Size = new System.Drawing.Size(96, 24);
            this.rbMasculin.TabIndex = 0;
            this.rbMasculin.TabStop = true;
            this.rbMasculin.Text = "Masculin";
            this.rbMasculin.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(159, 446);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(203, 68);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(536, 560);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbSex);
            this.Controls.Add(this.gbStare);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbSalariu);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gbStare.ResumeLayout(false);
            this.gbStare.PerformLayout();
            this.gbSex.ResumeLayout(false);
            this.gbSex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbSalariu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gbStare;
        private System.Windows.Forms.RadioButton rbCasatorit;
        private System.Windows.Forms.RadioButton rbNecasatorit;
        private System.Windows.Forms.GroupBox gbSex;
        private System.Windows.Forms.RadioButton rbFeminin;
        private System.Windows.Forms.RadioButton rbMasculin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSave;
    }
}

