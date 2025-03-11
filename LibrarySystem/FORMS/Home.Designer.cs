namespace LibrarySystem.FORMS
{
    partial class Home
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
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            panel1 = new Panel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            linkLabel5 = new LinkLabel();
            linkLabel6 = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.BackColor = Color.MistyRose;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Iskoola Pota", 18F);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.FromArgb(0, 64, 64);
            linkLabel1.Location = new Point(174, 19);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(189, 87);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Available Books";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.BackColor = Color.Orange;
            label1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(430, 200);
            label1.Name = "label1";
            label1.Size = new Size(500, 150);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Library";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.bookwall;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 216);
            panel1.Name = "panel1";
            panel1.Size = new Size(1347, 511);
            panel1.TabIndex = 0;
            // 
            // linkLabel2
            // 
            linkLabel2.BackColor = Color.MistyRose;
            linkLabel2.Cursor = Cursors.Hand;
            linkLabel2.Font = new Font("Iskoola Pota", 18F);
            linkLabel2.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel2.LinkColor = Color.FromArgb(0, 64, 64);
            linkLabel2.Location = new Point(455, 19);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(188, 87);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Manage Books";
            linkLabel2.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.BackColor = Color.MistyRose;
            linkLabel3.Cursor = Cursors.Hand;
            linkLabel3.Font = new Font("Iskoola Pota", 18F);
            linkLabel3.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel3.LinkColor = Color.FromArgb(0, 64, 64);
            linkLabel3.Location = new Point(1015, 19);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(163, 87);
            linkLabel3.TabIndex = 3;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Transactions";
            linkLabel3.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel4
            // 
            linkLabel4.BackColor = Color.MistyRose;
            linkLabel4.Cursor = Cursors.Hand;
            linkLabel4.Font = new Font("Iskoola Pota", 18F);
            linkLabel4.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel4.LinkColor = Color.FromArgb(0, 64, 64);
            linkLabel4.Location = new Point(455, 122);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(188, 74);
            linkLabel4.TabIndex = 4;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "CLI MENU";
            linkLabel4.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            // 
            // linkLabel5
            // 
            linkLabel5.BackColor = Color.MistyRose;
            linkLabel5.Cursor = Cursors.Hand;
            linkLabel5.Font = new Font("Iskoola Pota", 18F);
            linkLabel5.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel5.LinkColor = Color.FromArgb(0, 64, 64);
            linkLabel5.Location = new Point(735, 122);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(188, 74);
            linkLabel5.TabIndex = 5;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "Exit";
            linkLabel5.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel5.LinkClicked += linkLabel5_LinkClicked;
            // 
            // linkLabel6
            // 
            linkLabel6.BackColor = Color.MistyRose;
            linkLabel6.Cursor = Cursors.Hand;
            linkLabel6.Font = new Font("Iskoola Pota", 18F);
            linkLabel6.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel6.LinkColor = Color.FromArgb(0, 64, 64);
            linkLabel6.Location = new Point(735, 19);
            linkLabel6.Name = "linkLabel6";
            linkLabel6.Size = new Size(188, 87);
            linkLabel6.TabIndex = 6;
            linkLabel6.TabStop = true;
            linkLabel6.Text = "Member Details";
            linkLabel6.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel6.LinkClicked += linkLabel6_LinkClicked;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1344, 721);
            Controls.Add(linkLabel6);
            Controls.Add(linkLabel5);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(panel1);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private LinkLabel linkLabel1;
        private Label label1;
        private Panel panel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel5;
        private LinkLabel linkLabel6;
    }
}