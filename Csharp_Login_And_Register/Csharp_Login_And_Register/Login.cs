using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Csharp_Login_And_Register
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();

            this.textBoxPassword.AutoSize = false;
            this.textBoxPassword.Size = new Size(this.textBoxPassword.Size.Width, 50);
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
            labelClose.BackColor = Color.Red;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
            labelClose.BackColor = Color.FromArgb(0, 0, 192);
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {


            DB db = new DB();

            String username = textBoxUsername.Text;
            String password = textBoxPassword.Text;
            if (username == "Admin" && password == "Admin")
            {
                this.Hide();
                Admin AdminForm = new Admin();
                AdminForm.Show();
                return;
            }
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `klanten` WHERE `gebruikersnaam` = @gebr and `wachtwoord` = @ww", db.getConnection());

            command.Parameters.Add("@gebr", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@ww", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            // kijken of de gebruiker bestaat of niet.
            
            if (table.Rows.Count > 0)
            {
                this.Hide();
                Welkom WelkomForm = new Welkom();
                WelkomForm.Show();
            }
            else
            {
                if(username.Trim().Equals(""))
                {
                    MessageBox.Show("Vul alstublieft alle velden in");
                }
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Vul alstublieft alle velden in");
                }
                else
                {
                    MessageBox.Show("Onjuiste combinatie van gebruikersnaam & wachtwoord");
                }
            }

        }

        private void labelRegistreren_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register registerform = new Register();
            registerform.Show();
        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
      
        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
