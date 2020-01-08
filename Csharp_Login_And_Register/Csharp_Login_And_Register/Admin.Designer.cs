namespace Csharp_Login_And_Register
{
    partial class Admin
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAdminscherm = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelAfsluiten = new System.Windows.Forms.Label();
            this.buttonKlanten = new System.Windows.Forms.Button();
            this.textboxRemoveID = new System.Windows.Forms.TextBox();
            this.buttonVerwijderData = new System.Windows.Forms.Button();
            this.buttonVerwijderMeterstand = new System.Windows.Forms.Button();
            this.textboxVerwijderMeterstand = new System.Windows.Forms.TextBox();
            this.labelOpties = new System.Windows.Forms.Label();
            this.buttonInlogscherm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdminscherm
            // 
            this.lblAdminscherm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblAdminscherm.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblAdminscherm.ForeColor = System.Drawing.Color.White;
            this.lblAdminscherm.Location = new System.Drawing.Point(0, -1);
            this.lblAdminscherm.Name = "lblAdminscherm";
            this.lblAdminscherm.Size = new System.Drawing.Size(935, 93);
            this.lblAdminscherm.TabIndex = 0;
            this.lblAdminscherm.Text = "Administrator Paneel";
            this.lblAdminscherm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(645, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelAfsluiten
            // 
            this.labelAfsluiten.AutoSize = true;
            this.labelAfsluiten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelAfsluiten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAfsluiten.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAfsluiten.ForeColor = System.Drawing.Color.White;
            this.labelAfsluiten.Location = new System.Drawing.Point(908, 3);
            this.labelAfsluiten.Name = "labelAfsluiten";
            this.labelAfsluiten.Size = new System.Drawing.Size(23, 22);
            this.labelAfsluiten.TabIndex = 6;
            this.labelAfsluiten.Text = "X";
            this.labelAfsluiten.Click += new System.EventHandler(this.labelAfsluiten_Click);
            this.labelAfsluiten.MouseEnter += new System.EventHandler(this.labelAfsluiten_MouseEnter);
            this.labelAfsluiten.MouseLeave += new System.EventHandler(this.labelAfsluiten_MouseLeave);
            // 
            // buttonKlanten
            // 
            this.buttonKlanten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonKlanten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKlanten.FlatAppearance.BorderSize = 0;
            this.buttonKlanten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKlanten.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKlanten.ForeColor = System.Drawing.Color.White;
            this.buttonKlanten.Location = new System.Drawing.Point(659, 102);
            this.buttonKlanten.Name = "buttonKlanten";
            this.buttonKlanten.Size = new System.Drawing.Size(264, 150);
            this.buttonKlanten.TabIndex = 7;
            this.buttonKlanten.Text = "Ververs Klanteninformatie";
            this.buttonKlanten.UseVisualStyleBackColor = false;
            this.buttonKlanten.Click += new System.EventHandler(this.buttonKlanten_Click_1);
            // 
            // textboxRemoveID
            // 
            this.textboxRemoveID.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxRemoveID.ForeColor = System.Drawing.Color.Gray;
            this.textboxRemoveID.Location = new System.Drawing.Point(245, 369);
            this.textboxRemoveID.Multiline = true;
            this.textboxRemoveID.Name = "textboxRemoveID";
            this.textboxRemoveID.Size = new System.Drawing.Size(117, 40);
            this.textboxRemoveID.TabIndex = 201;
            this.textboxRemoveID.Text = "klantid";
            this.textboxRemoveID.TextChanged += new System.EventHandler(this.textboxRemoveID_TextChanged);
            this.textboxRemoveID.Enter += new System.EventHandler(this.textboxRemoveID_Enter);
            this.textboxRemoveID.Leave += new System.EventHandler(this.textboxRemoveID_Leave);
            // 
            // buttonVerwijderData
            // 
            this.buttonVerwijderData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonVerwijderData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVerwijderData.FlatAppearance.BorderSize = 0;
            this.buttonVerwijderData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerwijderData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerwijderData.ForeColor = System.Drawing.Color.White;
            this.buttonVerwijderData.Location = new System.Drawing.Point(12, 369);
            this.buttonVerwijderData.Name = "buttonVerwijderData";
            this.buttonVerwijderData.Size = new System.Drawing.Size(227, 40);
            this.buttonVerwijderData.TabIndex = 202;
            this.buttonVerwijderData.Text = "Verwijder Klant";
            this.buttonVerwijderData.UseVisualStyleBackColor = false;
            this.buttonVerwijderData.Click += new System.EventHandler(this.buttonVerwijderData_Click_1);
            // 
            // buttonVerwijderMeterstand
            // 
            this.buttonVerwijderMeterstand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonVerwijderMeterstand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVerwijderMeterstand.FlatAppearance.BorderSize = 0;
            this.buttonVerwijderMeterstand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerwijderMeterstand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerwijderMeterstand.ForeColor = System.Drawing.Color.White;
            this.buttonVerwijderMeterstand.Location = new System.Drawing.Point(12, 323);
            this.buttonVerwijderMeterstand.Name = "buttonVerwijderMeterstand";
            this.buttonVerwijderMeterstand.Size = new System.Drawing.Size(227, 40);
            this.buttonVerwijderMeterstand.TabIndex = 205;
            this.buttonVerwijderMeterstand.Text = "Verwijder Meterstand";
            this.buttonVerwijderMeterstand.UseVisualStyleBackColor = false;
            this.buttonVerwijderMeterstand.Click += new System.EventHandler(this.buttonVerwijderMeterstand_Click);
            // 
            // textboxVerwijderMeterstand
            // 
            this.textboxVerwijderMeterstand.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxVerwijderMeterstand.ForeColor = System.Drawing.Color.Gray;
            this.textboxVerwijderMeterstand.Location = new System.Drawing.Point(245, 323);
            this.textboxVerwijderMeterstand.Multiline = true;
            this.textboxVerwijderMeterstand.Name = "textboxVerwijderMeterstand";
            this.textboxVerwijderMeterstand.Size = new System.Drawing.Size(117, 40);
            this.textboxVerwijderMeterstand.TabIndex = 206;
            this.textboxVerwijderMeterstand.Text = "klantid";
            this.textboxVerwijderMeterstand.Enter += new System.EventHandler(this.textboxVerwijderMeterstand_Enter);
            this.textboxVerwijderMeterstand.Leave += new System.EventHandler(this.textboxVerwijderMeterstand_Leave);
            // 
            // labelOpties
            // 
            this.labelOpties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelOpties.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold);
            this.labelOpties.ForeColor = System.Drawing.Color.White;
            this.labelOpties.Location = new System.Drawing.Point(12, 255);
            this.labelOpties.Name = "labelOpties";
            this.labelOpties.Size = new System.Drawing.Size(350, 50);
            this.labelOpties.TabIndex = 207;
            this.labelOpties.Text = "Opties";
            this.labelOpties.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonInlogscherm
            // 
            this.buttonInlogscherm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonInlogscherm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInlogscherm.FlatAppearance.BorderSize = 0;
            this.buttonInlogscherm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInlogscherm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInlogscherm.ForeColor = System.Drawing.Color.White;
            this.buttonInlogscherm.Location = new System.Drawing.Point(659, 255);
            this.buttonInlogscherm.Name = "buttonInlogscherm";
            this.buttonInlogscherm.Size = new System.Drawing.Size(264, 150);
            this.buttonInlogscherm.TabIndex = 208;
            this.buttonInlogscherm.Text = "Terug naar inlogscherm";
            this.buttonInlogscherm.UseVisualStyleBackColor = false;
            this.buttonInlogscherm.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(935, 493);
            this.Controls.Add(this.buttonInlogscherm);
            this.Controls.Add(this.labelOpties);
            this.Controls.Add(this.textboxVerwijderMeterstand);
            this.Controls.Add(this.buttonVerwijderMeterstand);
            this.Controls.Add(this.buttonVerwijderData);
            this.Controls.Add(this.textboxRemoveID);
            this.Controls.Add(this.buttonKlanten);
            this.Controls.Add(this.labelAfsluiten);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblAdminscherm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
            
        private System.Windows.Forms.Label lblAdminscherm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelAfsluiten;
        private System.Windows.Forms.Button buttonKlanten;
        private System.Windows.Forms.TextBox textboxRemoveID;
        private System.Windows.Forms.Button buttonVerwijderData;
        private System.Windows.Forms.Button buttonVerwijderMeterstand;
        private System.Windows.Forms.TextBox textboxVerwijderMeterstand;
        private System.Windows.Forms.Label labelOpties;
        private System.Windows.Forms.Button buttonInlogscherm;
    }
}