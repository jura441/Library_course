namespace Library_course
{
    partial class EditBook
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
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_author = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.Label();
            this.tb_genre = new System.Windows.Forms.TextBox();
            this.genre = new System.Windows.Forms.Label();
            this.tb_publisher = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Pages = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Publishyear = new System.Windows.Forms.TextBox();
            this.Publishyear = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(429, 190);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(228, 23);
            this.tb_name.TabIndex = 31;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "name";
            // 
            // tb_author
            // 
            this.tb_author.Location = new System.Drawing.Point(429, 117);
            this.tb_author.Name = "tb_author";
            this.tb_author.Size = new System.Drawing.Size(228, 23);
            this.tb_author.TabIndex = 29;
            this.tb_author.TextChanged += new System.EventHandler(this.tb_author_TextChanged);
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Location = new System.Drawing.Point(429, 87);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(42, 15);
            this.author.TabIndex = 28;
            this.author.Text = "author";
            // 
            // tb_genre
            // 
            this.tb_genre.Location = new System.Drawing.Point(429, 55);
            this.tb_genre.Name = "tb_genre";
            this.tb_genre.Size = new System.Drawing.Size(228, 23);
            this.tb_genre.TabIndex = 27;
            this.tb_genre.TextChanged += new System.EventHandler(this.tb_genre_TextChanged);
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Location = new System.Drawing.Point(429, 25);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(37, 15);
            this.genre.TabIndex = 26;
            this.genre.Text = "genre";
            // 
            // tb_publisher
            // 
            this.tb_publisher.Location = new System.Drawing.Point(32, 246);
            this.tb_publisher.Name = "tb_publisher";
            this.tb_publisher.Size = new System.Drawing.Size(228, 23);
            this.tb_publisher.TabIndex = 25;
            this.tb_publisher.TextChanged += new System.EventHandler(this.tb_publisher_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Publisher";
            // 
            // tb_Pages
            // 
            this.tb_Pages.Location = new System.Drawing.Point(32, 184);
            this.tb_Pages.Name = "tb_Pages";
            this.tb_Pages.Size = new System.Drawing.Size(228, 23);
            this.tb_Pages.TabIndex = 23;
            this.tb_Pages.TextChanged += new System.EventHandler(this.tb_Pages_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Pages";
            // 
            // tb_Publishyear
            // 
            this.tb_Publishyear.Location = new System.Drawing.Point(32, 117);
            this.tb_Publishyear.Name = "tb_Publishyear";
            this.tb_Publishyear.Size = new System.Drawing.Size(228, 23);
            this.tb_Publishyear.TabIndex = 21;
            this.tb_Publishyear.TextChanged += new System.EventHandler(this.tb_Publishyear_TextChanged);
            // 
            // Publishyear
            // 
            this.Publishyear.AutoSize = true;
            this.Publishyear.Location = new System.Drawing.Point(32, 87);
            this.Publishyear.Name = "Publishyear";
            this.Publishyear.Size = new System.Drawing.Size(71, 15);
            this.Publishyear.TabIndex = 20;
            this.Publishyear.Text = "Publish year";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(32, 55);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(228, 23);
            this.tb_id.TabIndex = 19;
            this.tb_id.TextChanged += new System.EventHandler(this.tb_id_TextChanged);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(32, 25);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(17, 15);
            this.id.TabIndex = 18;
            this.id.Text = "id";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(549, 382);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 17;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(260, 373);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 16;
            this.btn_edit.Text = "Сохранить";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // EditBook
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
            this.Controls.Add(this.tb_publisher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Pages);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Publishyear);
            this.Controls.Add(this.Publishyear);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.id);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_edit);
            this.Name = "EditBook";
            this.Text = "EditBook";
            this.Load += new System.EventHandler(this.EditBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label7;
        private Label author;
        private Label genre;
        private Label label3;
        private Label label4;
        private Label Publishyear;
        private Label id;
        private Button btn_cancel;
        private Button btn_edit;
        public TextBox tb_name;
        public TextBox tb_author;
        public TextBox tb_genre;
        public TextBox tb_publisher;
        public TextBox tb_Pages;
        public TextBox tb_Publishyear;
        public TextBox tb_id;
    }
}