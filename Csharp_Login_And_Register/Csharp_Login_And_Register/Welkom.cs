using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Csharp_Login_And_Register
{
    public partial class Welkom : Form
    {
        public Welkom()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        
        private void buttonMeterstandenVersturen_Click(object sender, EventArgs e)
        {
            try
            {
             
                DB db = new DB();
                String username = textboxID.Text;
                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command1 = new MySqlCommand("SELECT * FROM `klanten` WHERE `gebruikersnaam` = @gebruiker", db.getConnection());

                

                command1.Parameters.Add("@gebruiker", MySqlDbType.VarChar).Value = username;
                
                adapter.SelectCommand = command1;

                adapter.Fill(table);
                if(table.Rows.Count < 1)
                {
                    MessageBox.Show("Onjuiste gebruikersnaam!");
                }
                if (table.Rows.Count > 0)
                {
                    MySqlCommand command = new MySqlCommand("UPDATE `klanten` SET `meterstand` = '" + textboxMeterstandUpdate.Text + "'" + "WHERE `gebruikersnaam`= '" + textboxID.Text + "';", db.getConnection());
                    MySqlDataReader MyReader;
                    db.openConnection();
                    MyReader = command.ExecuteReader();
                    MessageBox.Show("Bedankt! Uw meterstand is opgeslagen");
                    while (MyReader.Read())
                    {
                    }
                    db.closeConnection();
                }
            
            }
                catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
                }


        }

        private void textboxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxID_Leave(object sender, EventArgs e)
        {
            String gebruikersnaam = textboxID.Text;
            if (gebruikersnaam.ToLower().Trim().Equals("gebruikersnaam") || gebruikersnaam.Trim().Equals(""))
            {
                textboxID.Text = "gebruikersnaam";
                textboxID.ForeColor = Color.Gray;
            }
        }

        private void textboxID_Enter(object sender, EventArgs e)
        {
            String gebruikersnaam = textboxID.Text;
            if (gebruikersnaam.ToLower().Trim().Equals("gebruikersnaam"))
            {
                textboxID.Text = "";
                textboxID.ForeColor = Color.Black;
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

        private void textboxMeterstandUpdate_TextChanged(object sender, EventArgs e)
        {

        }
        private void textboxMeterstandUpdate_Leave(object sender, EventArgs e)
        {
            String meterstandupdate = textboxMeterstandUpdate.Text;
            if (meterstandupdate.ToLower().Trim().Equals("meterstand") || meterstandupdate.Trim().Equals(""))
            {
                textboxMeterstandUpdate.Text = "meterstand";
                textboxMeterstandUpdate.ForeColor = Color.Gray;
            }
        }

        private void textboxMeterstandUpdate_Enter(object sender, EventArgs e)
        {
            String meterstandupdate = textboxMeterstandUpdate.Text;
            if (meterstandupdate.ToLower().Trim().Equals("meterstand"))
            {
                textboxMeterstandUpdate.Text = "";
                textboxMeterstandUpdate.ForeColor = Color.Black;
            }
        }
        
    }
}
