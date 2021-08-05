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
    public partial class Login : Form
    {
        string user = "admin";
        string password = "admin";
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Username: admin ; Password: admin");

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbUsername.Text == "" && tbPassword.Text == "")
                {
                    MessageBox.Show("Introduceti user-ul si parola!");
                }
                if (tbUsername.Text == user && tbPassword.Text == password)
                {
                    //Meniu meniu = new Meniu();
                    //meniu.ShowDialog();
                    //this.Dispose();
                    Loading loading = new Loading();
                    this.Hide();
                    loading.Show();
                }
                else
                {
                    MessageBox.Show("User-ul sau parola sunt incorecte!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
