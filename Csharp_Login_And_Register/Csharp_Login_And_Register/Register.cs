using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Csharp_Login_And_Register
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // Dit zorgt ervoor dat je cursor niet op de eerste label gaat staan.
            this.ActiveControl = label1;
        }

        private void textBoxNaam_Enter(object sender, EventArgs e)
        {
            String Naam = textBoxNaam.Text;
            if(Naam.ToLower().Trim().Equals("naam"))
            {
                textBoxNaam.Text = "";
                textBoxNaam.ForeColor = Color.Black;
            }
        }

        private void textBoxNaam_Leave(object sender, EventArgs e)
        {
            String Naam = textBoxNaam.Text;
            if (Naam.ToLower().Trim().Equals("naam") || Naam.Trim().Equals(""))
            {
                textBoxNaam.Text = "naam";
                textBoxNaam.ForeColor = Color.Gray;
            }
        }

        private void textBoxAchternaam_Enter(object sender, EventArgs e)
        {
            String Achternaam = textBoxAchternaam.Text;
            if (Achternaam.ToLower().Trim().Equals("achternaam"))
            {
                textBoxAchternaam.Text = "";
                textBoxAchternaam.ForeColor = Color.Black;
            }
        }

        private void textBoxAchternaam_Leave(object sender, EventArgs e)
        {
            String Achternaam = textBoxAchternaam.Text;
            if (Achternaam.ToLower().Trim().Equals("achternaam") || Achternaam.Trim().Equals(""))
            {
                textBoxAchternaam.Text = "achternaam";
                textBoxAchternaam.ForeColor = Color.Gray;
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            String email = textBoxEmail.Text;
            if (email.ToLower().Trim().Equals("email"))
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            String email = textBoxEmail.Text;
            if (email.ToLower().Trim().Equals("email") || email.Trim().Equals(""))
            {
                textBoxEmail.Text = "email";
                textBoxEmail.ForeColor = Color.Gray;
            }
        }

        private void textBoxGebruikersnaam_Enter(object sender, EventArgs e)
        {
            String username = textBoxGebruikersnaam.Text;
            if (username.ToLower().Trim().Equals("gebruikersnaam"))
            {
                textBoxGebruikersnaam.Text = "";
                textBoxGebruikersnaam.ForeColor = Color.Black;
            }
        }

        private void textBoxGebruikersnaam_Leave(object sender, EventArgs e)
        {
            String username = textBoxGebruikersnaam.Text;
            if (username.ToLower().Trim().Equals("gebruikersnaam") || username.Trim().Equals(""))
            {
                textBoxGebruikersnaam.Text = "gebruikersnaam";
                textBoxGebruikersnaam.ForeColor = Color.Gray;
            }
        }

        private void textBoxWachtwoord_Enter(object sender, EventArgs e)
        {
            String wachtwoord = textBoxWachtwoord.Text;
            if (wachtwoord.ToLower().Trim().Equals("wachtwoord"))
            {
                textBoxWachtwoord.Text = "";
                textBoxWachtwoord.UseSystemPasswordChar = true;
                textBoxWachtwoord.ForeColor = Color.Black;
            }
        }

        private void textBoxWachtwoord_Leave(object sender, EventArgs e)
        {
            String wachtwoord = textBoxWachtwoord.Text;
            if (wachtwoord.ToLower().Trim().Equals("wachtwoord") || wachtwoord.Trim().Equals(""))
            {
                textBoxWachtwoord.Text = "wachtwoord";
                textBoxWachtwoord.UseSystemPasswordChar = false;
                textBoxWachtwoord.ForeColor = Color.Gray;
            }
        }

        private void textBoxHerhaalWachtwoord_Enter(object sender, EventArgs e)
        {
            String cpassword = textBoxHerhaalWachtwoord.Text;
            if (cpassword.ToLower().Trim().Equals("herhaal wachtwoord"))
            {
                textBoxHerhaalWachtwoord.Text = "";
                textBoxHerhaalWachtwoord.UseSystemPasswordChar = true;
                textBoxHerhaalWachtwoord.ForeColor = Color.Black;
            }
        }

        private void textBoxHerhaalWachtwoord_Leave(object sender, EventArgs e)
        {
            String cpassword = textBoxHerhaalWachtwoord.Text;
            if (cpassword.ToLower().Trim().Equals("herhaal wachtwoord") ||
                cpassword.ToLower().Trim().Equals("wachtwoord") ||
                cpassword.Trim().Equals(""))
            {
                textBoxHerhaalWachtwoord.Text = "herhaal wachtwoord";
                textBoxHerhaalWachtwoord.UseSystemPasswordChar = false;
                textBoxHerhaalWachtwoord.ForeColor = Color.Gray;
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
           // sluit de applicatie af zodra er op de label wordt gedrukt
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




        private void buttonAccountAanmaken_Click(object sender, EventArgs e)
        {
            // Het toevoegen van een nieuwe gebruiker

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `klanten`(`naam`, `achternaam`, `email`, `gebruikersnaam`, `wachtwoord`) VALUES (@vn, @an, @em, @gebr, @ww)", db.getConnection());

            command.Parameters.Add("@vn", MySqlDbType.VarChar).Value = textBoxNaam.Text;
            command.Parameters.Add("@an", MySqlDbType.VarChar).Value = textBoxAchternaam.Text;
            command.Parameters.Add("@em", MySqlDbType.VarChar).Value = textBoxEmail.Text;
            command.Parameters.Add("@gebr", MySqlDbType.VarChar).Value = textBoxGebruikersnaam.Text;
            command.Parameters.Add("@ww", MySqlDbType.VarChar).Value = textBoxWachtwoord.Text;

            // De connectie naar de database openen
            db.openConnection();

            // Controleren of de boxen de normale al ingevulde gegevens bevatten.
            if (!checkTextBoxesValues())
            {
                // controleren of het ingevoerde wachtwoord hetzelfde is als het herhaalde wachtwoord
                if(textBoxWachtwoord.Text.Equals(textBoxHerhaalWachtwoord.Text))
                {
                    // controleren of de gebruikersnaam al bestaat of niet.
                    if (checkUsername())
                    {
                        // als de gebruiker al bestaat, onderstaande pop-up weergeven met de tekst.
                        MessageBox.Show("Deze gebruikersnaam bestaat al, bedenk iets anders");
                    }
                    else
                    {
                        
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Uw account is aangemaakt. U kunt nu inloggen in het inlogenscherm");
                            this.Hide();
                            Login loginform = new Login();
                            loginform.Show();
                        }
                        else
                        {
                            MessageBox.Show("Er is iets foutgegaan, contacteer de administrator van dit systeem");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("U heeft niet hetzelfde wachtwoord ingevoerd bij 'herhaal wachtwoord'");
                }
                
            }
            else
            {
                MessageBox.Show("Vul alstublieft alle velden in");
            }
            
            

            // de connectie met de database afsluiten.
            db.closeConnection();

        }

        
        // controleren of een gebruikersnaam al bestaat.
        public Boolean checkUsername()
        {
            // hier haal je de informatie op om zometeen op te laten zoeken in de database
            DB db = new DB();

            String username = textBoxGebruikersnaam.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `klanten` WHERE `Gebruikersnaam` = @gebr", db.getConnection());

            command.Parameters.Add("@gebr", MySqlDbType.VarChar).Value = username;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            // hier wordt gecontroleerd of de gebruiker al bestaat of niet
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Boolean checkTextBoxesValues()
        {
            String Naam = textBoxNaam.Text;
            String Achternaam = textBoxAchternaam.Text;
            String email = textBoxEmail.Text;
            String Gebruikersnaam = textBoxGebruikersnaam.Text;
            String Wachtwoord = textBoxWachtwoord.Text;

            if(Naam.Equals("naam") || Achternaam.Equals("Achternaam") || 
                email.Equals("email") || Gebruikersnaam.Equals("Gebruikersnaam")
                || Wachtwoord.Equals("Wachtwoord"))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        

        private void labelLoginscherm_Click(object sender, EventArgs e)
        {
            // als er wordt gedrukt op de label voor het login scherm, laat dan het loginform zien.
            this.Hide();
            Login loginform = new Login();
            loginform.Show();
        }

        private void textBoxNaam_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxWachtwoord_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Voor het maken van deze windows form heb ik een tutorial gebruikt. het kan zijn dat sommige code in het engels is hierdoor. 
    }
}
