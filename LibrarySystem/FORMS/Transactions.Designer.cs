namespace LibrarySystem.FORMS
{
    partial class Transactions
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
            dataGridView_transactions = new DataGridView();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_transactions).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_transactions
            // 
            dataGridView_transactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_transactions.BackgroundColor = Color.Maroon;
            dataGridView_transactions.ColumnHeadersHeight = 34;
            dataGridView_transactions.Location = new Point(311, 159);
            dataGridView_transactions.Name = "dataGridView_transactions";
            dataGridView_transactions.RowHeadersWidth = 45;
            dataGridView_transactions.Size = new Size(723, 378);
            dataGridView_transactions.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(559, 61);
            label1.Name = "label1";
            label1.Size = new Size(268, 36);
            label1.TabIndex = 34;
            label1.Text = "TRANSACTIONS";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(608, 580);
            button2.Name = "button2";
            button2.Size = new Size(148, 70);
            button2.TabIndex = 35;
            button2.Text = "MAIN MENU";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Transactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            BackgroundImage = Properties.Resources.bwall1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1344, 721);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(dataGridView_transactions);
            Name = "Transactions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transactions";
            Load += Transactions_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_transactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_transactions;
        private TextBox textBox1;
        private Button button_searchByIsbn;
        private TextBox textBox_language;
        private TextBox textBox_genre;
        private TextBox textBox_publisher;
        private TextBox textBox_author;
        private Label label6;
        private Label label5;
        private Label label1;
        private Button button2;
    }
}