using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.OleDb;

namespace AplicatieBanking
{
    public partial class Meniu : Form
    {
        Clienti clienti=new Clienti();
        Credite credite=new Credite();

        public Meniu()
        {
            InitializeComponent();
            OleDbConnection connection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Clienti.accdb");
            try
            {
                connection.Open();
                //  MessageBox.Show("works");
                OleDbCommand command = new OleDbCommand("SELECT * FROM clienti", connection);

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string[] dataNastere = reader["dataNastere"].ToString().Split('/');
                    string[] an = dataNastere[2].Split(' ');

                    DateTime dataNasterii = new DateTime(Convert.ToInt32(an[0]), Convert.ToInt32(dataNastere[0]), Convert.ToInt32(dataNastere[1]));

                    Client aux = new Client(reader["nume"].ToString(), dataNasterii, Convert.ToChar(reader["sex"].ToString()), reader["stareCivila"].ToString(), Convert.ToDouble(reader["salariu"].ToString()));
                    aux.Id = Convert.ToInt32(reader["ID"].ToString());



                    clienti.addClient(aux);

                }

                reader.Close();

                command.CommandText = "SELECT * FROM credite";

                OleDbDataReader reader1 = command.ExecuteReader();
                while (reader1.Read())
                {
                    Credit aux = new Credit(Convert.ToInt32(reader1["id_client"].ToString()),Convert.ToDouble(reader1["suma"].ToString()),Convert.ToInt32(reader1["durata"].ToString()), 
                        Convert.ToDouble(reader1["rataDobanda"].ToString()), reader1["tipCredit"].ToString());
                    aux.Id = Convert.ToInt32(reader1["ID"].ToString());
                    credite.addCredit(aux.IdClient, aux);
                }

                reader1.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }



        }

        private void btnCreare_Click(object sender, EventArgs e)
        {
            Form1 preluare = new Form1(clienti);
            preluare.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tabel tabel = new Tabel(clienti);
            tabel.ShowDialog();

        }

        private void cursValutarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Curs curs = new Curs();
            curs.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cautare cautare = new Cautare(clienti,credite);
            cautare.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Preluare_credit preluare_credit = new Preluare_credit(credite, clienti);
            preluare_credit.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://acs.ase.ro/paw");
        }
    }
}
