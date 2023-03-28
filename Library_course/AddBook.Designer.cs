namespace Library_course
{
    partial class AddBook
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_Publishyear = new System.Windows.Forms.TextBox();
            this.Publishyear = new System.Windows.Forms.Label();
            this.tb_Publisher = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Pages = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_author = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.Label();
            this.tb_genre = new System.Windows.Forms.TextBox();
            this.genre = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(203, 358);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(492, 367);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(50, 31);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(17, 15);
            this.id.TabIndex = 2;
            this.id.Text = "id";
            this.id.Click += new System.EventHandler(this.id_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(50, 61);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(228, 23);
            this.tb_id.TabIndex = 3;
            this.tb_id.TextChanged += new System.EventHandler(this.tb_id_TextChanged);
            // 
            // tb_Publishyear
            // 
            this.tb_Publishyear.Location = new System.Drawing.Point(50, 123);
            this.tb_Publishyear.Name = "tb_Publishyear";
            this.tb_Publishyear.Size = new System.Drawing.Size(228, 23);
            this.tb_Publishyear.TabIndex = 5;
            this.tb_Publishyear.TextChanged += new System.EventHandler(this.tb_Publishyear_TextChanged);
            // 
            // Publishyear
            // 
            this.Publishyear.AutoSize = true;
            this.Publishyear.Location = new System.Drawing.Point(50, 93);
            this.Publishyear.Name = "Publishyear";
            this.Publishyear.Size = new System.Drawing.Size(71, 15);
            this.Publishyear.TabIndex = 4;
            this.Publishyear.Text = "Publish year";
            this.Publishyear.Click += new System.EventHandler(this.Publishyear_Click);
            // 
            // tb_Publisher
            // 
            this.tb_Publisher.Location = new System.Drawing.Point(50, 252);
            this.tb_Publisher.Name = "tb_Publisher";
            this.tb_Publisher.Size = new System.Drawing.Size(228, 23);
            this.tb_Publisher.TabIndex = 9;
            this.tb_Publisher.TextChanged += new System.EventHandler(this.tb_Publisher_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Publisher";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tb_Pages
            // 
            this.tb_Pages.Location = new System.Drawing.Point(50, 190);
            this.tb_Pages.Name = "tb_Pages";
            this.tb_Pages.Size = new System.Drawing.Size(228, 23);
            this.tb_Pages.TabIndex = 7;
            this.tb_Pages.TextChanged += new System.EventHandler(this.tb_Pages_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pages";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tb_author
            // 
            this.tb_author.Location = new System.Drawing.Point(408, 132);
            this.tb_author.Name = "tb_author";
            this.tb_author.Size = new System.Drawing.Size(228, 23);
            this.tb_author.TabIndex = 13;
            this.tb_author.TextChanged += new System.EventHandler(this.tb_author_TextChanged);
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Location = new System.Drawing.Point(408, 102);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(42, 15);
            this.author.TabIndex = 12;
            this.author.Text = "author";
            this.author.Click += new System.EventHandler(this.author_Click);
            // 
            // tb_genre
            // 
            this.tb_genre.Location = new System.Drawing.Point(408, 70);
            this.tb_genre.Name = "tb_genre";
            this.tb_genre.Size = new System.Drawing.Size(228, 23);
            this.tb_genre.TabIndex = 11;
            this.tb_genre.TextChanged += new System.EventHandler(this.tb_genre_TextChanged);
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Location = new System.Drawing.Point(408, 40);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(37, 15);
            this.genre.TabIndex = 10;
            this.genre.Text = "genre";
            this.genre.Click += new System.EventHandler(this.genre_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(408, 205);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(228, 23);
            this.tb_name.TabIndex = 15;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "name";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_author);
            this.Controls.Add(this.author);
            this.Controls.Add(this.tb_genre);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.tb_Publisher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Pages);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Publishyear);
            this.Controls.Add(this.Publishyear);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.id);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_add;
        private Button btn_cancel;
        private Label id;
        private Label Publishyear;
        private Label label3;
        private Label label4;
        private Label author;
        private Label genre;
        private Label label7;
        public TextBox tb_id;
        public TextBox tb_Publishyear;
        public TextBox tb_Publisher;
        public TextBox tb_Pages;
        public TextBox tb_author;
        public TextBox tb_genre;
        public TextBox tb_name;
    }
}