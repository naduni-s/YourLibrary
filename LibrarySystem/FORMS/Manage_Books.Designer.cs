namespace LibrarySystem.FORMS
{
    partial class Manage_Books
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox_isbn = new TextBox();
            textBox_title = new TextBox();
            textBox_author = new TextBox();
            textBox_publisher = new TextBox();
            textBox_genre = new TextBox();
            textBox_language = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView_books = new DataGridView();
            button4 = new Button();
            button_searchByIsbn = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_books).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Orange;
            label1.Font = new Font("Lucida Bright", 15.75F);
            label1.Location = new Point(178, 87);
            label1.Name = "label1";
            label1.Size = new Size(100, 33);
            label1.TabIndex = 0;
            label1.Text = "ISBN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Orange;
            label2.Font = new Font("Lucida Bright", 15.75F);
            label2.Location = new Point(178, 163);
            label2.Name = "label2";
            label2.Size = new Size(88, 40);
            label2.TabIndex = 1;
            label2.Text = "Title";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Orange;
            label3.Font = new Font("Lucida Bright", 15.75F);
            label3.Location = new Point(178, 234);
            label3.Name = "label3";
            label3.Size = new Size(100, 39);
            label3.TabIndex = 2;
            label3.Text = "Author";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.Orange;
            label4.Font = new Font("Lucida Bright", 15.75F);
            label4.Location = new Point(178, 304);
            label4.Name = "label4";
            label4.Size = new Size(107, 40);
            label4.TabIndex = 3;
            label4.Text = "Publisher";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.Orange;
            label5.Font = new Font("Lucida Bright", 15.75F);
            label5.Location = new Point(178, 375);
            label5.Name = "label5";
            label5.Size = new Size(100, 35);
            label5.TabIndex = 4;
            label5.Text = "Genre";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.Orange;
            label6.Font = new Font("Lucida Bright", 15.75F);
            label6.Location = new Point(178, 441);
            label6.Name = "label6";
            label6.Size = new Size(121, 36);
            label6.TabIndex = 5;
            label6.Text = "Language";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_isbn
            // 
            textBox_isbn.Location = new Point(319, 96);
            textBox_isbn.Name = "textBox_isbn";
            textBox_isbn.Size = new Size(167, 23);
            textBox_isbn.TabIndex = 6;
            // 
            // textBox_title
            // 
            textBox_title.Location = new Point(319, 180);
            textBox_title.Name = "textBox_title";
            textBox_title.Size = new Size(167, 23);
            textBox_title.TabIndex = 7;
            // 
            // textBox_author
            // 
            textBox_author.Location = new Point(319, 249);
            textBox_author.Name = "textBox_author";
            textBox_author.Size = new Size(167, 23);
            textBox_author.TabIndex = 8;
            // 
            // textBox_publisher
            // 
            textBox_publisher.Location = new Point(319, 318);
            textBox_publisher.Name = "textBox_publisher";
            textBox_publisher.Size = new Size(167, 23);
            textBox_publisher.TabIndex = 9;
            // 
            // textBox_genre
            // 
            textBox_genre.Location = new Point(319, 387);
            textBox_genre.Name = "textBox_genre";
            textBox_genre.Size = new Size(167, 23);
            textBox_genre.TabIndex = 10;
            // 
            // textBox_language
            // 
            textBox_language.Location = new Point(319, 456);
            textBox_language.Name = "textBox_language";
            textBox_language.Size = new Size(167, 23);
            textBox_language.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(111, 547);
            button1.Name = "button1";
            button1.Size = new Size(155, 62);
            button1.TabIndex = 12;
            button1.Text = "Add book";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Orange;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(558, 549);
            button2.Name = "button2";
            button2.Size = new Size(160, 62);
            button2.TabIndex = 13;
            button2.Text = "remove book";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Orange;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(340, 549);
            button3.Name = "button3";
            button3.Size = new Size(144, 62);
            button3.TabIndex = 14;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView_books
            // 
            dataGridView_books.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_books.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_books.Location = new Point(555, 99);
            dataGridView_books.Name = "dataGridView_books";
            dataGridView_books.Size = new Size(611, 378);
            dataGridView_books.TabIndex = 15;
            // 
            // button4
            // 
            button4.BackColor = Color.Orange;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(792, 554);
            button4.Name = "button4";
            button4.Size = new Size(209, 57);
            button4.TabIndex = 16;
            button4.Text = "Clear all fields";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button_searchByIsbn
            // 
            button_searchByIsbn.BackColor = Color.LightGreen;
            button_searchByIsbn.Cursor = Cursors.Hand;
            button_searchByIsbn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_searchByIsbn.Location = new Point(348, 125);
            button_searchByIsbn.Name = "button_searchByIsbn";
            button_searchByIsbn.Size = new Size(108, 35);
            button_searchByIsbn.TabIndex = 17;
            button_searchByIsbn.Text = "Search by ISBN";
            button_searchByIsbn.UseVisualStyleBackColor = false;
            button_searchByIsbn.Click += button_searchByIsbn_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Orange;
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(1075, 554);
            button5.Name = "button5";
            button5.Size = new Size(165, 57);
            button5.TabIndex = 18;
            button5.Text = "Main menu";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Manage_Books
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            BackgroundImage = Properties.Resources.bwall1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1344, 721);
            Controls.Add(button5);
            Controls.Add(button_searchByIsbn);
            Controls.Add(button4);
            Controls.Add(dataGridView_books);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox_language);
            Controls.Add(textBox_genre);
            Controls.Add(textBox_publisher);
            Controls.Add(textBox_author);
            Controls.Add(textBox_title);
            Controls.Add(textBox_isbn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Manage_Books";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage_Books";
            Load += Manage_Books_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_books).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox_isbn;
        private TextBox textBox_title;
        private TextBox textBox_author;
        private TextBox textBox_publisher;
        private TextBox textBox_genre;
        private TextBox textBox_language;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView_books;
        private Button button4;
        private Button button_searchByIsbn;
        private Button button5;
    }
}