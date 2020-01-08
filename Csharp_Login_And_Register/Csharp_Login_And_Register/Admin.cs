using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Csharp_Login_And_Register
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            try
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("select `klantid`,`naam`,`achternaam`,`email`,`gebruikersnaam`,`meterstand` from `klanten`;", db.getConnection());
       

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = command;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; // Datagridview selecteren als venster om de 'dtable' oftewel datatable weer te geven. 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        



        private void textboxVerwijderMeterstand_Leave(object sender, EventArgs e)
        {
            String klantid = textboxVerwijderMeterstand.Text;
            if (klantid.ToLower().Trim().Equals("klantid") || klantid.Trim().Equals(""))
            {
                textboxVerwijderMeterstand.Text = "klantid";
                textboxVerwijderMeterstand.ForeColor = Color.Gray;
            }
        }

        private void textboxVerwijderMeterstand_Enter(object sender, EventArgs e)
        {
            String klantid = textboxVerwijderMeterstand.Text;
            if (klantid.ToLower().Trim().Equals("klantid"))
            {
                textboxVerwijderMeterstand.Text = "";
                textboxVerwijderMeterstand.ForeColor = Color.Black;
            }
        }

        private void textboxRemoveID_Leave(object sender, EventArgs e)
        {
            String klantid = textboxRemoveID.Text;
            if (klantid.ToLower().Trim().Equals("klantid") || klantid.Trim().Equals(""))
            {
                textboxRemoveID.Text = "klantid";
                textboxRemoveID.ForeColor = Color.Gray;
            }
        }

        private void textboxRemoveID_Enter(object sender, EventArgs e)
        {
            String klantid = textboxRemoveID.Text;
            if (klantid.ToLower().Trim().Equals("klantid"))
            {
                textboxRemoveID.Text = "";
                textboxRemoveID.ForeColor = Color.Black;
            }
        }

        private void labelAfsluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void labelAfsluiten_MouseEnter(object sender, EventArgs e)
        {
            labelAfsluiten.ForeColor = Color.White;
            labelAfsluiten.BackColor = Color.Red;
        }

        private void labelAfsluiten_MouseLeave(object sender, EventArgs e)
        {
            labelAfsluiten.ForeColor = Color.White;
            labelAfsluiten.BackColor = Color.FromArgb(0, 0, 192);
        }

        private void buttonVerwijderData_Click_1(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
               
                MySqlCommand command = new MySqlCommand("delete from `klanten` where `klantid`='" + this.textboxRemoveID.Text + "';", db.getConnection());
                
                MySqlDataReader MyReader;
                db.openConnection();
                MyReader = command.ExecuteReader();
                MessageBox.Show("Informatie is verwijderd");
                while (MyReader.Read())
                {
                }
               db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonKlanten_Click_1(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                

                MySqlCommand command = new MySqlCommand("select `klantid`,`gebruikersnaam`,`naam`,`achternaam`,`email`,`meterstand` from `klanten`;", db.getConnection());
             
                
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = command;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; // Datagridview selecteren als venster om de 'dtable' oftewel datatable weer te geven. 
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textboxRemoveID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void buttonVerwijderMeterstand_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                
                MySqlCommand command = new MySqlCommand("UPDATE `klanten` SET `meterstand` = '0'" + "WHERE `klantid`= '" + textboxVerwijderMeterstand.Text + "';", db.getConnection());
               
                MySqlDataReader MyReader;
                db.openConnection();
                MyReader = command.ExecuteReader();
                MessageBox.Show("Data Deleted");
                while (MyReader.Read())
                {
                }
                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login LoginForm = new Login();
            LoginForm.Show();
            return;
        }
    }
}
