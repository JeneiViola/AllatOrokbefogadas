namespace AllatKliens
{
    partial class TalalatokForm
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
            lblCim = new Label();
            flpAllatok = new FlowLayoutPanel();
            btnVissza = new Button();
            SuspendLayout();
            // 
            // lblCim
            // 
            lblCim.Font = new Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCim.ForeColor = Color.FromArgb(100, 40, 55);
            lblCim.Location = new Point(60, 30);
            lblCim.Name = "lblCim";
            lblCim.Size = new Size(960, 65);
            lblCim.TabIndex = 0;
            lblCim.Text = "🐾 A hozzád legjobban illő kedvencek";
            lblCim.TextAlign = ContentAlignment.TopCenter;
            // 
            // flpAllatok
            // 
            flpAllatok.AutoScroll = true;
            flpAllatok.Location = new Point(60, 140);
            flpAllatok.Name = "flpAllatok";
            flpAllatok.Size = new Size(960, 490);
            flpAllatok.TabIndex = 1;
            // 
            // btnVissza
            // 
            btnVissza.BackColor = Color.FromArgb(100, 40, 55);
            btnVissza.Cursor = Cursors.Hand;
            btnVissza.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVissza.ForeColor = Color.White;
            btnVissza.Location = new Point(60, 650);
            btnVissza.Name = "btnVissza";
            btnVissza.Size = new Size(210, 45);
            btnVissza.TabIndex = 3;
            btnVissza.Text = "← Vissza a kereséshez";
            btnVissza.UseVisualStyleBackColor = false;
            btnVissza.Click += btnVissza_Click;
            // 
            // TalalatokForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 246, 243);
            ClientSize = new Size(1084, 711);
            Controls.Add(btnVissza);
            Controls.Add(flpAllatok);
            Controls.Add(lblCim);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TalalatokForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Állatajánlások 🐾";
            ResumeLayout(false);
        }

        #endregion

        private Label lblCim;
        private FlowLayoutPanel flpAllatok;
        private Button btnVissza;
    }
}