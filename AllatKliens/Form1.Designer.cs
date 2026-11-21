namespace AllatKliens
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlBalOldal = new Panel();
            picAllatok = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbAllatTipus = new ComboBox();
            label4 = new Label();
            cmbLakhatas = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cmbMasikAllat = new ComboBox();
            cmbAktivitas = new ComboBox();
            txtTelepules = new TextBox();
            numTavolsag = new NumericUpDown();
            btnKereses = new Button();
            pnlKerdoiv = new Panel();
            pnlBalOldal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAllatok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTavolsag).BeginInit();
            SuspendLayout();
            // 
            // pnlBalOldal
            // 
            pnlBalOldal.BackColor = Color.FromArgb(232, 218, 207);
            pnlBalOldal.Controls.Add(picAllatok);
            pnlBalOldal.Location = new Point(20, 20);
            pnlBalOldal.Name = "pnlBalOldal";
            pnlBalOldal.Size = new Size(400, 600);
            pnlBalOldal.TabIndex = 1;
            // 
            // picAllatok
            // 
            picAllatok.Dock = DockStyle.Fill;
            picAllatok.Image = (Image)resources.GetObject("picAllatok.Image");
            picAllatok.Location = new Point(0, 0);
            picAllatok.Name = "picAllatok";
            picAllatok.Size = new Size(400, 600);
            picAllatok.SizeMode = PictureBoxSizeMode.Zoom;
            picAllatok.TabIndex = 0;
            picAllatok.TabStop = false;
            picAllatok.Click += picAllatok_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(82, 49, 60);
            label1.Location = new Point(522, 32);
            label1.Name = "label1";
            label1.Size = new Size(510, 38);
            label1.TabIndex = 2;
            label1.Text = "Találd meg új kedvencedet!🐾";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(547, 80);
            label2.Name = "label2";
            label2.Size = new Size(420, 50);
            label2.TabIndex = 3;
            label2.Text = "Meséld el, milyen kis kedvencet keresel, mi pedig segítünk megtalálni a hozzád legjobban illő társat!";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(82, 49, 60);
            label3.Location = new Point(468, 164);
            label3.Name = "label3";
            label3.Size = new Size(164, 21);
            label3.TabIndex = 4;
            label3.Text = "Milyen állatot keresel?";
            label3.Click += label3_Click;
            // 
            // cmbAllatTipus
            // 
            cmbAllatTipus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAllatTipus.Font = new Font("Segoe UI", 11F);
            cmbAllatTipus.FormattingEnabled = true;
            cmbAllatTipus.Items.AddRange(new object[] { "Kutya", "Macska" });
            cmbAllatTipus.Location = new Point(468, 188);
            cmbAllatTipus.Name = "cmbAllatTipus";
            cmbAllatTipus.Size = new Size(250, 28);
            cmbAllatTipus.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(82, 49, 60);
            label4.Location = new Point(801, 164);
            label4.Name = "label4";
            label4.Size = new Size(190, 21);
            label4.TabIndex = 6;
            label4.Text = "Milyen környezetben élsz?";
            label4.Click += label4_Click;
            // 
            // cmbLakhatas
            // 
            cmbLakhatas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLakhatas.Font = new Font("Segoe UI", 11F);
            cmbLakhatas.FormattingEnabled = true;
            cmbLakhatas.Items.AddRange(new object[] { "Lakás", "Kertes ház" });
            cmbLakhatas.Location = new Point(786, 188);
            cmbLakhatas.Name = "cmbLakhatas";
            cmbLakhatas.Size = new Size(250, 28);
            cmbLakhatas.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(82, 49, 60);
            label5.Location = new Point(468, 266);
            label5.Name = "label5";
            label5.Size = new Size(70, 21);
            label5.TabIndex = 8;
            label5.Text = "Hol élsz?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(82, 49, 60);
            label6.Location = new Point(468, 372);
            label6.Name = "label6";
            label6.Size = new Size(230, 21);
            label6.TabIndex = 9;
            label6.Text = "Milyen aktivitású társat keresel?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(82, 49, 60);
            label7.Location = new Point(801, 266);
            label7.Name = "label7";
            label7.Size = new Size(163, 21);
            label7.TabIndex = 10;
            label7.Text = "Van másik háziálltod?";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(82, 49, 60);
            label8.Location = new Point(801, 372);
            label8.Name = "label8";
            label8.Size = new Size(249, 21);
            label8.TabIndex = 11;
            label8.Text = "Milyen messzire utaznál érte? (km)";
            // 
            // cmbMasikAllat
            // 
            cmbMasikAllat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMasikAllat.Font = new Font("Segoe UI", 11F);
            cmbMasikAllat.FormattingEnabled = true;
            cmbMasikAllat.Items.AddRange(new object[] { "Igen", "Nem" });
            cmbMasikAllat.Location = new Point(786, 290);
            cmbMasikAllat.Name = "cmbMasikAllat";
            cmbMasikAllat.Size = new Size(250, 28);
            cmbMasikAllat.TabIndex = 14;
            // 
            // cmbAktivitas
            // 
            cmbAktivitas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAktivitas.Font = new Font("Segoe UI", 11F);
            cmbAktivitas.FormattingEnabled = true;
            cmbAktivitas.Items.AddRange(new object[] { "Nyugodt", "Közepesen aktív", "Nagyon aktv" });
            cmbAktivitas.Location = new Point(468, 396);
            cmbAktivitas.Name = "cmbAktivitas";
            cmbAktivitas.Size = new Size(250, 28);
            cmbAktivitas.TabIndex = 15;
            // 
            // txtTelepules
            // 
            txtTelepules.Location = new Point(468, 290);
            txtTelepules.Name = "txtTelepules";
            txtTelepules.Size = new Size(250, 23);
            txtTelepules.TabIndex = 17;
            // 
            // numTavolsag
            // 
            numTavolsag.Location = new Point(786, 401);
            numTavolsag.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numTavolsag.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numTavolsag.Name = "numTavolsag";
            numTavolsag.Size = new Size(250, 23);
            numTavolsag.TabIndex = 18;
            numTavolsag.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // btnKereses
            // 
            btnKereses.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnKereses.Location = new Point(653, 527);
            btnKereses.Name = "btnKereses";
            btnKereses.Size = new Size(220, 45);
            btnKereses.TabIndex = 19;
            btnKereses.Text = "🐾 Állatok keresése";
            btnKereses.UseVisualStyleBackColor = true;
            btnKereses.Click += btnKereses_Click;
            // 
            // pnlKerdoiv
            // 
            pnlKerdoiv.BackColor = Color.FromArgb(255, 250, 247);
            pnlKerdoiv.BorderStyle = BorderStyle.FixedSingle;
            pnlKerdoiv.Location = new Point(452, 151);
            pnlKerdoiv.Name = "pnlKerdoiv";
            pnlKerdoiv.Size = new Size(610, 469);
            pnlKerdoiv.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 245, 242);
            ClientSize = new Size(1084, 661);
            Controls.Add(btnKereses);
            Controls.Add(numTavolsag);
            Controls.Add(txtTelepules);
            Controls.Add(cmbAktivitas);
            Controls.Add(cmbMasikAllat);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cmbLakhatas);
            Controls.Add(label4);
            Controls.Add(cmbAllatTipus);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pnlBalOldal);
            Controls.Add(pnlKerdoiv);
            Name = "Form1";
            Text = "Állatörökbefogadási ajánlórendszer";
            pnlBalOldal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAllatok).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTavolsag).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlBalOldal;
        private PictureBox picAllatok;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbAllatTipus;
        private Label label4;
        private ComboBox cmbLakhatas;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cmbMasikAllat;
        private ComboBox cmbAktivitas;
        private TextBox txtTelepules;
        private NumericUpDown numTavolsag;
        private Button btnKereses;
        private Panel pnlKerdoiv;
    }
}
