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
    public partial class Preluare_credit : Form
    {
        Credite credite;
        Clienti clienti;

        public Preluare_credit(Credite credite, Clienti clienti)
        {
            InitializeComponent();

            this.credite = credite;
            this.clienti = clienti;

            //OleDbConnection connection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Clienti.accdb");
            //OleDbCommand command = new OleDbCommand();
            //command.Connection = connection;

            comboBox1.Items.AddRange(clienti.clienti.Values.ToArray());
        }

        private void btnCalcul_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbPerioada.Text) > 15)
                tbRata.Text = "10";//de modif
            else if (Convert.ToInt32(tbPerioada.Text) <= 15)
                tbRata.Text = "15";
            double sumaLunara = 0;
            double dobanda = Convert.ToDouble(tbRata.Text) / 10;
            double suma = Convert.ToDouble(tbSuma.Text);
            sumaLunara = suma * dobanda * 30 / 360;
            textBox2.Text = sumaLunara.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            OleDbConnection connection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Clienti.accdb");
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            try
            {
                connection.Open();
                
                command.CommandText = "SELECT MAX(id) FROM credite";
                int valoare = (int)command.ExecuteScalar();
                Credit.contor = valoare;

                Credit aux = new Credit(((Client)comboBox1.SelectedItem).Id, Convert.ToDouble(tbSuma.Text), Convert.ToInt32(tbPerioada.Text), Convert.ToDouble(tbRata.Text), cbTip.SelectedItem.ToString());
                credite.addCredit(aux.IdClient, aux);

                command.CommandText = "";

                command.CommandText = "INSERT INTO credite VALUES('" + aux.Id + "','" + aux.IdClient + "','" +
                    aux.Suma + "','" + aux.Durata + "','" + aux.RataDobanda + "','" + aux.TipCredit + "')";
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

                this.tbRata.Clear();
                this.tbSuma.Clear();
                this.textBox2.Clear();
                //this.tbPerioada.Clear();
                connection.Close();
            }
        }
  
        private void tbSuma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void hScrollBar1_Scroll(object sender, EventArgs e)
        {
            tbPerioada.Text = hScrollBar1.Value.ToString();
        }

        private void tbPerioada_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbPerioada.Text) >= 30)
                MessageBox.Show("Perioada maxima de creditare este de 30 de ani!");
            try
            {
                hScrollBar1.Value = Convert.ToInt32(tbPerioada.Text);
            }
            catch
            {
                hScrollBar1.Value = 1;
            }
        }
    }
}
