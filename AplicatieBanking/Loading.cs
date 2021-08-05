using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieBanking
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Loading 
            progressBar1.Value = progressBar1.Value + 1;
            if (progressBar1.Value >= 49)
            {
                Meniu meniu = new Meniu();
                this.Hide();
                meniu.Show();


                timer1.Enabled = false;

                progressBar1.Value = progressBar1.Value - 1;
            }

           
        }

        private void Loading_Load(object sender, EventArgs e)
        {

        }
    }
}
