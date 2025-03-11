namespace LibrarySystem.FORMS
{
    partial class Members_Details
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
            dataGridView_members = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_members).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_members
            // 
            dataGridView_members.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_members.Location = new Point(82, 178);
            dataGridView_members.Name = "dataGridView_members";
            dataGridView_members.Size = new Size(672, 423);
            dataGridView_members.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.LightSalmon;
            label1.Font = new Font("Iskoola Pota", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(266, 64);
            label1.Name = "label1";
            label1.Size = new Size(325, 52);
            label1.TabIndex = 1;
            label1.Text = "Member Details";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(336, 620);
            button1.Name = "button1";
            button1.Size = new Size(166, 57);
            button1.TabIndex = 2;
            button1.Text = "Main menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Members_Details
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.book1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1344, 721);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView_members);
            Name = "Members_Details";
            Text = "Members_Details";
            Load += Members_Details_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_members).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_members;
        private Label label1;
        private Button button1;
    }
}