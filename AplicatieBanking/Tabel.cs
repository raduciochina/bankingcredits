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
using System.IO;
using System.Drawing.Printing;
using System.Drawing;
using System.Drawing.Imaging;

namespace AplicatieBanking
{
    public partial class Tabel : Form
    {
        string connString;
        Clienti clienti;

        public Tabel(Clienti clienti)
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Clienti.accdb";
            this.clienti = clienti;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            OleDbConnection connection = new OleDbConnection(connString);
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

            foreach (Client client in clienti.clienti.Values)
            {
                ListViewItem itm = new ListViewItem(client.Id.ToString());
                itm.SubItems.Add(client.Nume.ToString());
                itm.SubItems.Add(client.StareCivila.ToString());
                itm.SubItems.Add(client.Salariu.ToString());
                itm.SubItems.Add(client.Sex.ToString());
                itm.SubItems.Add(client.DataNasterii.ToString());

                this.listView1.Items.Add(itm);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1(clienti);
            frm.Show();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents | *.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                    {
                        foreach (ListViewItem itm in listView1.Items)
                        {
                            await tw.WriteLineAsync(itm.SubItems[0].Text + "\t" + itm.SubItems[1].Text + "\t" + itm.SubItems[2].Text + "\t" + itm.SubItems[3].Text+ "\t"
                               + itm.SubItems[4].Text + "\t" + itm.SubItems[5].Text);

                        }
                        MessageBox.Show("Date salvate.");
                    }
                }


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connString);
            try
            {
                connection.Open();
                //  MessageBox.Show("works");
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                foreach(ListViewItem itm in listView1.Items)
                {
                    if (itm.Checked)
                    {
                        int id = Convert.ToInt32(itm.SubItems[0].Text);
                        command.CommandText = "DELETE FROM clienti WHERE id = " + id ;
                        command.ExecuteNonQuery();
                    }
                }
 
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
           button1_Click(sender, e);
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
            {
                if (itm.Selected)
                {
                    itm.Remove();
                }
            }

        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
               e.Item.BackColor = Color.Green;
            }
        }
        void printing(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(listView1.Width, listView1.Height);
            listView1.DrawToBitmap(bitmap, listView1.ClientRectangle);
            e.Graphics.DrawImage(bitmap, new Point(50, 50));

        }
        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(printing);

            pd.Print();
        }
        
    }
}