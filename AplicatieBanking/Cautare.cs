using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AplicatieBanking
{
    public partial class Cautare : Form
    {
        Clienti clienti;
        Credite credite;
        public Cautare(Clienti clienti,Credite credite)
        {
            InitializeComponent();
            this.clienti = clienti;
            this.credite = credite;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OleDbConnection connection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Clienti.accdb");
            //OleDbCommand command = new OleDbCommand();
            //command.Connection = connection;


            if (tbCautare.Text == "")
                errorProvider1.SetError(tbCautare, "Introduceti un id sau un nume!");
            else
                try
                {
                    //connection.Open();
                    if (radioButton1.Checked) 
                    {
                        //command.CommandText = "SELECT * FROM credite WHERE id_client = " + tbCautare.Text;
                        //OleDbDataReader rezultat = command.ExecuteReader();
                        //command.CommandText = "SELECT * FROM clienti WHERE id = " + tbCautare.Text;
                        //OleDbDataReader client = command.ExecuteReader();
                        //while (rezultat.Read())
                        //{

                        //}
                        //listBox1.Text =client+Environment.NewLine+rezultat ;

                        var rezultat = clienti.clienti.Where(x => x.Key.Equals(Convert.ToInt32(tbCautare.Text))).Select(x => x.Value).ToList();
                        listBox1.Items.Add(rezultat[0]);
                        Console.WriteLine(rezultat[0]);

                        var rezultat1 = credite.credite.Where(x => x.Key.Equals(Convert.ToInt32(tbCautare.Text))).Select(x => x.Value).ToList();
                        foreach (var item in rezultat1)
                        { listBox1.Items.Add(item);
                            Console.WriteLine(item);
                        }
                    }
                    else
                    if (radioButton2.Checked) 
                    {
                        var rezultat = clienti.clienti.Where(x => x.Value.Nume.Equals(tbCautare.Text)).Select(x => x.Value).ToList();
                        listBox1.Items.Add(rezultat[0]);
                        Console.WriteLine(rezultat[0]);

                        int idaux = rezultat[0].Id;
                        var rezultat1 = credite.credite.Where(x => x.Key.Equals(idaux)).Select(x => x.Value).ToList();
                        foreach (var item in rezultat1)
                        {
                            listBox1.Items.Add(item);
                            Console.WriteLine(item);
                        }
                    }
                    else
                        MessageBox.Show("Va rog sa selectati criteriul de cautare!");


                }
                catch (KeyNotFoundException ex)
                {
                    MessageBox.Show("Clientul cu id-ul " + tbCautare.Text + " nu exista.");

                }
                finally
                {
                    tbCautare.Clear();
                    //connection.Close();
                }
        }
    }
}
