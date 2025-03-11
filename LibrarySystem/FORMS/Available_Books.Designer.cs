namespace LibrarySystem.FORMS
{
    partial class Available_Books
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
            button1 = new Button();
            dataGridView_available = new DataGridView();
            panel1 = new Panel();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_available).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Lucida Bright", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(552, 43);
            button1.Name = "button1";
            button1.Size = new Size(257, 66);
            button1.TabIndex = 1;
            button1.Text = "Available books";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView_available
            // 
            dataGridView_available.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_available.BackgroundColor = Color.White;
            dataGridView_available.ColumnHeadersHeight = 28;
            dataGridView_available.Location = new Point(3, 29);
            dataGridView_available.Name = "dataGridView_available";
            dataGridView_available.RowHeadersWidth = 50;
            dataGridView_available.Size = new Size(987, 361);
            dataGridView_available.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.BackgroundImage = Properties.Resources.bookwall;
            panel1.Controls.Add(dataGridView_available);
            panel1.Location = new Point(172, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(1017, 415);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Lucida Bright", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(601, 536);
            button2.Name = "button2";
            button2.Size = new Size(154, 59);
            button2.TabIndex = 1;
            button2.Text = "Main menu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Available_Books
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            BackgroundImage = Properties.Resources.bookwall;
            ClientSize = new Size(1344, 721);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Available_Books";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Available_Books";
            ((System.ComponentModel.ISupportInitialize)dataGridView_available).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private DataGridView dataGridView_available;
        private Panel panel1;
        private Button button2;
    }
}