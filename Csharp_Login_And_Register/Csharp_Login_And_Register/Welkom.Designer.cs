namespace Csharp_Login_And_Register
{
    partial class Welkom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

       

       
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAfsluiten = new System.Windows.Forms.Label();
            this.labelMeterstandenVersturen = new System.Windows.Forms.Label();
            this.lblKlantenScherm = new System.Windows.Forms.Label();
            this.textboxMeterstandUpdate = new System.Windows.Forms.TextBox();
            this.textboxID = new System.Windows.Forms.TextBox();
            this.buttonMeterstandenVersturen = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.labelAfsluiten);
            this.panel1.Controls.Add(this.labelMeterstandenVersturen);
            this.panel1.Controls.Add(this.lblKlantenScherm);
            this.panel1.Controls.Add(this.textboxMeterstandUpdate);
            this.panel1.Controls.Add(this.textboxID);
            this.panel1.Controls.Add(this.buttonMeterstandenVersturen);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 425);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelAfsluiten
            // 
            this.labelAfsluiten.AutoSize = true;
            this.labelAfsluiten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelAfsluiten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAfsluiten.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAfsluiten.ForeColor = System.Drawing.Color.White;
            this.labelAfsluiten.Location = new System.Drawing.Point(448, 4);
            this.labelAfsluiten.Name = "labelAfsluiten";
            this.labelAfsluiten.Size = new System.Drawing.Size(23, 22);
            this.labelAfsluiten.TabIndex = 210;
            this.labelAfsluiten.Text = "X";
            this.labelAfsluiten.Click += new System.EventHandler(this.labelAfsluiten_Click);
            this.labelAfsluiten.MouseEnter += new System.EventHandler(this.labelAfsluiten_MouseEnter);
            this.labelAfsluiten.MouseLeave += new System.EventHandler(this.labelAfsluiten_MouseLeave);
            // 
            // labelMeterstandenVersturen
            // 
            this.labelMeterstandenVersturen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelMeterstandenVersturen.Font = new System.Drawing.Font("Arial", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeterstandenVersturen.ForeColor = System.Drawing.Color.White;
            this.labelMeterstandenVersturen.Location = new System.Drawing.Point(112, 126);
            this.labelMeterstandenVersturen.Name = "labelMeterstandenVersturen";
            this.labelMeterstandenVersturen.Size = new System.Drawing.Size(252, 101);
            this.labelMeterstandenVersturen.TabIndex = 209;
            this.labelMeterstandenVersturen.Text = "Meterstanden Versturen";
            this.labelMeterstandenVersturen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKlantenScherm
            // 
            this.lblKlantenScherm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblKlantenScherm.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblKlantenScherm.ForeColor = System.Drawing.Color.White;
            this.lblKlantenScherm.Location = new System.Drawing.Point(0, 0);
            this.lblKlantenScherm.Name = "lblKlantenScherm";
            this.lblKlantenScherm.Size = new System.Drawing.Size(474, 93);
            this.lblKlantenScherm.TabIndex = 208;
            this.lblKlantenScherm.Text = "Welkom bij Blue Energy";
            this.lblKlantenScherm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textboxMeterstandUpdate
            // 
            this.textboxMeterstandUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxMeterstandUpdate.ForeColor = System.Drawing.Color.Gray;
            this.textboxMeterstandUpdate.Location = new System.Drawing.Point(112, 301);
            this.textboxMeterstandUpdate.Multiline = true;
            this.textboxMeterstandUpdate.Name = "textboxMeterstandUpdate";
            this.textboxMeterstandUpdate.Size = new System.Drawing.Size(252, 40);
            this.textboxMeterstandUpdate.TabIndex = 207;
            this.textboxMeterstandUpdate.Text = "meterstand";
            this.textboxMeterstandUpdate.TextChanged += new System.EventHandler(this.textboxMeterstandUpdate_TextChanged);
            this.textboxMeterstandUpdate.Enter += new System.EventHandler(this.textboxMeterstandUpdate_Enter);
            this.textboxMeterstandUpdate.Leave += new System.EventHandler(this.textboxMeterstandUpdate_Leave);
            // 
            // textboxID
            // 
            this.textboxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxID.ForeColor = System.Drawing.Color.Gray;
            this.textboxID.Location = new System.Drawing.Point(112, 256);
            this.textboxID.Multiline = true;
            this.textboxID.Name = "textboxID";
            this.textboxID.Size = new System.Drawing.Size(252, 39);
            this.textboxID.TabIndex = 206;
            this.textboxID.Text = "gebruikersnaam";
            this.textboxID.TextChanged += new System.EventHandler(this.textboxID_TextChanged);
            this.textboxID.Enter += new System.EventHandler(this.textboxID_Enter);
            this.textboxID.Leave += new System.EventHandler(this.textboxID_Leave);
            // 
            // buttonMeterstandenVersturen
            // 
            this.buttonMeterstandenVersturen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonMeterstandenVersturen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMeterstandenVersturen.FlatAppearance.BorderSize = 0;
            this.buttonMeterstandenVersturen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMeterstandenVersturen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMeterstandenVersturen.ForeColor = System.Drawing.Color.White;
            this.buttonMeterstandenVersturen.Location = new System.Drawing.Point(112, 348);
            this.buttonMeterstandenVersturen.Name = "buttonMeterstandenVersturen";
            this.buttonMeterstandenVersturen.Size = new System.Drawing.Size(252, 40);
            this.buttonMeterstandenVersturen.TabIndex = 205;
            this.buttonMeterstandenVersturen.Text = "Versturen";
            this.buttonMeterstandenVersturen.UseVisualStyleBackColor = false;
            this.buttonMeterstandenVersturen.Click += new System.EventHandler(this.buttonMeterstandenVersturen_Click);
            // 
            // Welkom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 425);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Welkom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        


        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMeterstandenVersturen;
        private System.Windows.Forms.TextBox textboxMeterstandUpdate;
        private System.Windows.Forms.Label labelMeterstandenVersturen;
        private System.Windows.Forms.Label lblKlantenScherm;
        private System.Windows.Forms.Label labelAfsluiten;
        public System.Windows.Forms.TextBox textboxID;
    }
}