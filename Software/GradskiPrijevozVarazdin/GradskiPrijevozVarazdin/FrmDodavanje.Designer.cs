namespace GradskiPrijevozVarazdin
{
    partial class FrmDodavanje
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtBrPerona = new System.Windows.Forms.TextBox();
            this.txtKapacitet = new System.Windows.Forms.TextBox();
            this.cboLinija = new System.Windows.Forms.ComboBox();
            this.cboZaposlenik = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(93, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Definiranje autobusne stanice";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(95, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adresa stanice:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(95, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Opis:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(95, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Br.perona:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(95, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Linija:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(95, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kapacitet:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(99, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Zaposlenik:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSalmon;
            this.button1.Location = new System.Drawing.Point(237, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "Upiši";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSalmon;
            this.button2.Location = new System.Drawing.Point(467, 458);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 54);
            this.button2.TabIndex = 9;
            this.button2.Text = "Odustani";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(319, 143);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(194, 22);
            this.txtAdresa.TabIndex = 11;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(319, 185);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(194, 46);
            this.txtOpis.TabIndex = 12;
            // 
            // txtBrPerona
            // 
            this.txtBrPerona.Location = new System.Drawing.Point(319, 246);
            this.txtBrPerona.Name = "txtBrPerona";
            this.txtBrPerona.Size = new System.Drawing.Size(194, 22);
            this.txtBrPerona.TabIndex = 13;
            // 
            // txtKapacitet
            // 
            this.txtKapacitet.Location = new System.Drawing.Point(319, 331);
            this.txtKapacitet.Name = "txtKapacitet";
            this.txtKapacitet.Size = new System.Drawing.Size(194, 22);
            this.txtKapacitet.TabIndex = 15;
            // 
            // cboLinija
            // 
            this.cboLinija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLinija.FormattingEnabled = true;
            this.cboLinija.Items.AddRange(new object[] {
            "Linija 1",
            "Linija 2",
            "Linija 3"});
            this.cboLinija.Location = new System.Drawing.Point(319, 290);
            this.cboLinija.Name = "cboLinija";
            this.cboLinija.Size = new System.Drawing.Size(194, 24);
            this.cboLinija.TabIndex = 17;
            this.cboLinija.SelectedIndexChanged += new System.EventHandler(this.cboLinija_SelectedIndexChanged);
            // 
            // cboZaposlenik
            // 
            this.cboZaposlenik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboZaposlenik.FormattingEnabled = true;
            this.cboZaposlenik.Items.AddRange(new object[] {
            "Pero Peric",
            "Ana Anic",
            "Domagoj Juric",
            "Ante Horvat",
            "Ivan Novak"});
            this.cboZaposlenik.Location = new System.Drawing.Point(319, 371);
            this.cboZaposlenik.Name = "cboZaposlenik";
            this.cboZaposlenik.Size = new System.Drawing.Size(194, 24);
            this.cboZaposlenik.TabIndex = 18;
            // 
            // FrmDodavanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(642, 553);
            this.Controls.Add(this.cboZaposlenik);
            this.Controls.Add(this.cboLinija);
            this.Controls.Add(this.txtKapacitet);
            this.Controls.Add(this.txtBrPerona);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmDodavanje";
            this.Text = "FrmDodavanje";
            this.Load += new System.EventHandler(this.FrmDodavanje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtBrPerona;
        private System.Windows.Forms.TextBox txtKapacitet;
        private System.Windows.Forms.ComboBox cboLinija;
        private System.Windows.Forms.ComboBox cboZaposlenik;
    }
}