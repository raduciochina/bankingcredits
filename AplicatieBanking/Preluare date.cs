using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace AplicatieBanking
{
    public partial class Form1 : Form
    {
        Clienti clienti;

        public Form1(Clienti clienti)
        {
            InitializeComponent();
            this.clienti = clienti;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Clienti.accdb");
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
         
            if (tbNume.Text == "")
                errorProvider1.SetError(tbNume, "Va rugam sa introduceti numele!");
            else if (tbSalariu.Text == "")
                errorProvider1.SetError(tbSalariu, "Va rugam sa introduceti venitul lunar!");
            else if (!rbFeminin.Checked && !rbMasculin.Checked)
                errorProvider1.SetError(gbSex, "Va rugam sa selectati sexul!");
            else if (!rbCasatorit.Checked && !rbNecasatorit.Checked)
                errorProvider1.SetError(gbStare, "Va rugam sa selectati starea civila!");
            else
            {
                try
                {
                    connection.Open();
                    char sex = 'F';
                    if (rbMasculin.Checked)
                        sex = 'M';
                    string stare = "Necasatorit";
                    if (rbCasatorit.Checked)
                        stare = "Casatorit";

                    command.CommandText = "SELECT MAX(id) FROM clienti";
                    int valoare = (int)command.ExecuteScalar();
                    Client.contor = valoare + 1;

                    Client aux = new Client(tbNume.Text, dateTimePicker1.Value.Date, sex, stare, Convert.ToDouble(tbSalariu.Text));

                    clienti.addClient(aux);

                    string[] formats = aux.DataNasterii.GetDateTimeFormats();

                    string dataNastere = formats[3];

 
                    command.CommandText = "INSERT INTO clienti VALUES('" + aux.Id + "','" + aux.Nume + "','" +
                        aux.StareCivila + "','" + aux.Salariu + "','" + aux.Sex + "',DateValue('" + dataNastere +"'));";
                    command.ExecuteNonQuery();


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
                MessageBox.Show(clienti.ToString());
            }

        }

        private void tbNume_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tbSalariu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }

 }

