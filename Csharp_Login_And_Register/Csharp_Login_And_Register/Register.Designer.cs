namespace Csharp_Login_And_Register
{
    partial class Register
    {
        
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        
        
        private void InitializeComponent()
        {
            this.q = new System.Windows.Forms.Panel();
            this.labelInlogscherm = new System.Windows.Forms.Label();
            this.textBoxHerhaalWachtwoord = new System.Windows.Forms.TextBox();
            this.textBoxGebruikersnaam = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxAchternaam = new System.Windows.Forms.TextBox();
            this.buttonAccountAanmaken = new System.Windows.Forms.Button();
            this.textBoxWachtwoord = new System.Windows.Forms.TextBox();
            this.textBoxNaam = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelAfsluiten = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.q.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // q
            // 
            this.q.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.q.Controls.Add(this.labelInlogscherm);
            this.q.Controls.Add(this.textBoxHerhaalWachtwoord);
            this.q.Controls.Add(this.textBoxGebruikersnaam);
            this.q.Controls.Add(this.textBoxEmail);
            this.q.Controls.Add(this.textBoxAchternaam);
            this.q.Controls.Add(this.buttonAccountAanmaken);
            this.q.Controls.Add(this.textBoxWachtwoord);
            this.q.Controls.Add(this.textBoxNaam);
            this.q.Controls.Add(this.panel2);
            this.q.Dock = System.Windows.Forms.DockStyle.Fill;
            this.q.Location = new System.Drawing.Point(0, 0);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(635, 624);
            this.q.TabIndex = 1;
            this.q.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelInlogscherm
            // 
            this.labelInlogscherm.AutoSize = true;
            this.labelInlogscherm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelInlogscherm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInlogscherm.ForeColor = System.Drawing.Color.White;
            this.labelInlogscherm.Location = new System.Drawing.Point(239, 578);
            this.labelInlogscherm.Name = "labelInlogscherm";
            this.labelInlogscherm.Size = new System.Drawing.Size(166, 13);
            this.labelInlogscherm.TabIndex = 201;
            this.labelInlogscherm.Text = "Heeft u al een account? Inloggen";
            this.labelInlogscherm.Click += new System.EventHandler(this.labelLoginscherm_Click);
            // 
            // textBoxHerhaalWachtwoord
            // 
            this.textBoxHerhaalWachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHerhaalWachtwoord.ForeColor = System.Drawing.Color.Gray;
            this.textBoxHerhaalWachtwoord.Location = new System.Drawing.Point(52, 428);
            this.textBoxHerhaalWachtwoord.Name = "textBoxHerhaalWachtwoord";
            this.textBoxHerhaalWachtwoord.Size = new System.Drawing.Size(537, 40);
            this.textBoxHerhaalWachtwoord.TabIndex = 9;
            this.textBoxHerhaalWachtwoord.Text = "Herhaal Wachtwoord";
            this.textBoxHerhaalWachtwoord.Enter += new System.EventHandler(this.textBoxHerhaalWachtwoord_Enter);
            this.textBoxHerhaalWachtwoord.Leave += new System.EventHandler(this.textBoxHerhaalWachtwoord_Leave);
            // 
            // textBoxGebruikersnaam
            // 
            this.textBoxGebruikersnaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGebruikersnaam.ForeColor = System.Drawing.Color.Gray;
            this.textBoxGebruikersnaam.Location = new System.Drawing.Point(52, 312);
            this.textBoxGebruikersnaam.Multiline = true;
            this.textBoxGebruikersnaam.Name = "textBoxGebruikersnaam";
            this.textBoxGebruikersnaam.Size = new System.Drawing.Size(537, 40);
            this.textBoxGebruikersnaam.TabIndex = 8;
            this.textBoxGebruikersnaam.Text = "Gebruikersnaam";
            this.textBoxGebruikersnaam.Enter += new System.EventHandler(this.textBoxGebruikersnaam_Enter);
            this.textBoxGebruikersnaam.Leave += new System.EventHandler(this.textBoxGebruikersnaam_Leave);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.Gray;
            this.textBoxEmail.Location = new System.Drawing.Point(52, 257);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(537, 40);
            this.textBoxEmail.TabIndex = 7;
            this.textBoxEmail.Text = "email";
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // textBoxAchternaam
            // 
            this.textBoxAchternaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAchternaam.ForeColor = System.Drawing.Color.Gray;
            this.textBoxAchternaam.Location = new System.Drawing.Point(52, 200);
            this.textBoxAchternaam.Multiline = true;
            this.textBoxAchternaam.Name = "textBoxAchternaam";
            this.textBoxAchternaam.Size = new System.Drawing.Size(537, 40);
            this.textBoxAchternaam.TabIndex = 6;
            this.textBoxAchternaam.Text = "achternaam";
            this.textBoxAchternaam.Enter += new System.EventHandler(this.textBoxAchternaam_Enter);
            this.textBoxAchternaam.Leave += new System.EventHandler(this.textBoxAchternaam_Leave);
            // 
            // buttonAccountAanmaken
            // 
            this.buttonAccountAanmaken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAccountAanmaken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAccountAanmaken.FlatAppearance.BorderSize = 0;
            this.buttonAccountAanmaken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccountAanmaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccountAanmaken.ForeColor = System.Drawing.Color.White;
            this.buttonAccountAanmaken.Location = new System.Drawing.Point(52, 504);
            this.buttonAccountAanmaken.Name = "buttonAccountAanmaken";
            this.buttonAccountAanmaken.Size = new System.Drawing.Size(537, 60);
            this.buttonAccountAanmaken.TabIndex = 5;
            this.buttonAccountAanmaken.Text = "ACCOUNT AANMAKEN";
            this.buttonAccountAanmaken.UseVisualStyleBackColor = false;
            this.buttonAccountAanmaken.Click += new System.EventHandler(this.buttonAccountAanmaken_Click);
            // 
            // textBoxWachtwoord
            // 
            this.textBoxWachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWachtwoord.ForeColor = System.Drawing.Color.Gray;
            this.textBoxWachtwoord.Location = new System.Drawing.Point(52, 370);
            this.textBoxWachtwoord.Name = "textBoxWachtwoord";
            this.textBoxWachtwoord.Size = new System.Drawing.Size(537, 40);
            this.textBoxWachtwoord.TabIndex = 4;
            this.textBoxWachtwoord.Text = "Wachtwoord";
            this.textBoxWachtwoord.TextChanged += new System.EventHandler(this.textBoxWachtwoord_TextChanged);
            this.textBoxWachtwoord.Enter += new System.EventHandler(this.textBoxWachtwoord_Enter);
            this.textBoxWachtwoord.Leave += new System.EventHandler(this.textBoxWachtwoord_Leave);
            // 
            // textBoxNaam
            // 
            this.textBoxNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNaam.ForeColor = System.Drawing.Color.Gray;
            this.textBoxNaam.Location = new System.Drawing.Point(52, 145);
            this.textBoxNaam.Multiline = true;
            this.textBoxNaam.Name = "textBoxNaam";
            this.textBoxNaam.Size = new System.Drawing.Size(537, 40);
            this.textBoxNaam.TabIndex = 200;
            this.textBoxNaam.Text = "naam";
            this.textBoxNaam.TextChanged += new System.EventHandler(this.textBoxNaam_TextChanged);
            this.textBoxNaam.Enter += new System.EventHandler(this.textBoxNaam_Enter);
            this.textBoxNaam.Leave += new System.EventHandler(this.textBoxNaam_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.panel2.Controls.Add(this.labelAfsluiten);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-6, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 93);
            this.panel2.TabIndex = 0;
            // 
            // labelAfsluiten
            // 
            this.labelAfsluiten.AutoSize = true;
            this.labelAfsluiten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelAfsluiten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAfsluiten.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAfsluiten.ForeColor = System.Drawing.Color.White;
            this.labelAfsluiten.Location = new System.Drawing.Point(615, 3);
            this.labelAfsluiten.Name = "labelAfsluiten";
            this.labelAfsluiten.Size = new System.Drawing.Size(23, 22);
            this.labelAfsluiten.TabIndex = 1;
            this.labelAfsluiten.Text = "X";
            this.labelAfsluiten.Click += new System.EventHandler(this.labelClose_Click);
            this.labelAfsluiten.MouseEnter += new System.EventHandler(this.labelAfsluiten_MouseEnter);
            this.labelAfsluiten.MouseLeave += new System.EventHandler(this.labelAfsluiten_MouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(641, 93);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Aanmaken";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 624);
            this.Controls.Add(this.q);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.q.ResumeLayout(false);
            this.q.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Panel q;
        private System.Windows.Forms.Button buttonAccountAanmaken;
        private System.Windows.Forms.TextBox textBoxWachtwoord;
        private System.Windows.Forms.TextBox textBoxNaam;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelAfsluiten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHerhaalWachtwoord;
        private System.Windows.Forms.TextBox textBoxGebruikersnaam;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAchternaam;
        private System.Windows.Forms.Label labelInlogscherm;
    }
}