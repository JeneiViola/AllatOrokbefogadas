namespace AllatKliens
{
    partial class AllatKartya
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picAllat = new PictureBox();
            lblNev = new Label();
            lblAdatok = new Label();
            lblPontszam = new Label();
            lblTavolsag = new Label();
            lblLeiras = new Label();
            ((System.ComponentModel.ISupportInitialize)picAllat).BeginInit();
            SuspendLayout();
            // 
            // picAllat
            // 
            picAllat.BackColor = Color.FromArgb(235, 220, 210);
            picAllat.Location = new Point(15, 15);
            picAllat.Name = "picAllat";
            picAllat.Size = new Size(248, 165);
            picAllat.SizeMode = PictureBoxSizeMode.Zoom;
            picAllat.TabIndex = 0;
            picAllat.TabStop = false;
            // 
            // lblNev
            // 
            lblNev.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNev.Location = new Point(15, 200);
            lblNev.Name = "lblNev";
            lblNev.Size = new Size(175, 35);
            lblNev.TabIndex = 1;
            lblNev.Text = "\tBodri";
            lblNev.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAdatok
            // 
            lblAdatok.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdatok.ForeColor = Color.FromArgb(110, 90, 90);
            lblAdatok.Location = new Point(15, 240);
            lblAdatok.Name = "lblAdatok";
            lblAdatok.Size = new Size(248, 25);
            lblAdatok.TabIndex = 2;
            lblAdatok.Text = "\t3 éves · Mohács";
            lblAdatok.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPontszam
            // 
            lblPontszam.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPontszam.ForeColor = Color.FromArgb(100, 40, 55);
            lblPontszam.Location = new Point(185, 200);
            lblPontszam.Name = "lblPontszam";
            lblPontszam.Size = new Size(78, 35);
            lblPontszam.TabIndex = 3;
            lblPontszam.Text = "95 pont";
            lblPontszam.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTavolsag
            // 
            lblTavolsag.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTavolsag.ForeColor = Color.FromArgb(100, 40, 55);
            lblTavolsag.Location = new Point(15, 270);
            lblTavolsag.Name = "lblTavolsag";
            lblTavolsag.Size = new Size(248, 30);
            lblTavolsag.TabIndex = 4;
            lblTavolsag.Text = "12,5 km légvonalban";
            lblTavolsag.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLeiras
            // 
            lblLeiras.AutoEllipsis = true;
            lblLeiras.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLeiras.ForeColor = Color.FromArgb(80, 70, 70);
            lblLeiras.Location = new Point(15, 310);
            lblLeiras.Name = "lblLeiras";
            lblLeiras.Size = new Size(248, 65);
            lblLeiras.TabIndex = 5;
            lblLeiras.Text = "Barátságos, játékos kutyus, aki imád sétálni.";
            // 
            // AllatKartya
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 235, 228);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblLeiras);
            Controls.Add(lblTavolsag);
            Controls.Add(lblPontszam);
            Controls.Add(lblAdatok);
            Controls.Add(lblNev);
            Controls.Add(picAllat);
            Margin = new Padding(10);
            Name = "AllatKartya";
            Size = new Size(280, 380);
            ((System.ComponentModel.ISupportInitialize)picAllat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picAllat;
        private Label lblNev;
        private Label lblAdatok;
        private Label lblPontszam;
        private Label lblTavolsag;
        private Label lblLeiras;
    }
}
