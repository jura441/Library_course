namespace Library_course
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитИзБазыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьИзXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поИмениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameFilteraSKToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nameFilterdESCToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поАвторуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSKToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dESCToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.поИздательствуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dESCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_library = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_library)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.создатьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.фильтрToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитИзБазыToolStripMenuItem,
            this.загрузитьИзXMLToolStripMenuItem,
            this.toolStripSeparator2,
            this.cToolStripMenuItem,
            this.сохранитьВXMLToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // загрузитИзБазыToolStripMenuItem
            // 
            this.загрузитИзБазыToolStripMenuItem.Name = "загрузитИзБазыToolStripMenuItem";
            this.загрузитИзБазыToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.загрузитИзБазыToolStripMenuItem.Text = "Загрузить из базы";
            // 
            // загрузитьИзXMLToolStripMenuItem
            // 
            this.загрузитьИзXMLToolStripMenuItem.Name = "загрузитьИзXMLToolStripMenuItem";
            this.загрузитьИзXMLToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.загрузитьИзXMLToolStripMenuItem.Text = "Загрузить из XML";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(170, 6);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.cToolStripMenuItem.Text = "Сохранить в базу";
            // 
            // сохранитьВXMLToolStripMenuItem
            // 
            this.сохранитьВXMLToolStripMenuItem.Name = "сохранитьВXMLToolStripMenuItem";
            this.сохранитьВXMLToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.сохранитьВXMLToolStripMenuItem.Text = "Сохранить в XML";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // фильтрToolStripMenuItem
            // 
            this.фильтрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поИмениToolStripMenuItem,
            this.поАвторуToolStripMenuItem,
            this.поИздательствуToolStripMenuItem});
            this.фильтрToolStripMenuItem.Name = "фильтрToolStripMenuItem";
            this.фильтрToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.фильтрToolStripMenuItem.Text = "Фильтр";
            // 
            // поИмениToolStripMenuItem
            // 
            this.поИмениToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameFilteraSKToolStripMenuItem1,
            this.nameFilterdESCToolStripMenuItem1});
            this.поИмениToolStripMenuItem.Name = "поИмениToolStripMenuItem";
            this.поИмениToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поИмениToolStripMenuItem.Text = "По имени";
            // 
            // nameFilteraSKToolStripMenuItem1
            // 
            this.nameFilteraSKToolStripMenuItem1.Name = "nameFilteraSKToolStripMenuItem1";
            this.nameFilteraSKToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.nameFilteraSKToolStripMenuItem1.Text = "ASK";
            this.nameFilteraSKToolStripMenuItem1.Click += new System.EventHandler(this.nameFilteraSKToolStripMenuItem1_Click);
            // 
            // nameFilterdESCToolStripMenuItem1
            // 
            this.nameFilterdESCToolStripMenuItem1.Name = "nameFilterdESCToolStripMenuItem1";
            this.nameFilterdESCToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.nameFilterdESCToolStripMenuItem1.Text = "DESC";
            this.nameFilterdESCToolStripMenuItem1.Click += new System.EventHandler(this.nameFilterdESCToolStripMenuItem1_Click);
            // 
            // поАвторуToolStripMenuItem
            // 
            this.поАвторуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aSKToolStripMenuItem2,
            this.dESCToolStripMenuItem2});
            this.поАвторуToolStripMenuItem.Name = "поАвторуToolStripMenuItem";
            this.поАвторуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поАвторуToolStripMenuItem.Text = "По автору";
            // 
            // aSKToolStripMenuItem2
            // 
            this.aSKToolStripMenuItem2.Name = "aSKToolStripMenuItem2";
            this.aSKToolStripMenuItem2.Size = new System.Drawing.Size(102, 22);
            this.aSKToolStripMenuItem2.Text = "ASK";
            // 
            // dESCToolStripMenuItem2
            // 
            this.dESCToolStripMenuItem2.Name = "dESCToolStripMenuItem2";
            this.dESCToolStripMenuItem2.Size = new System.Drawing.Size(102, 22);
            this.dESCToolStripMenuItem2.Text = "DESC";
            // 
            // поИздательствуToolStripMenuItem
            // 
            this.поИздательствуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aSKToolStripMenuItem,
            this.dESCToolStripMenuItem});
            this.поИздательствуToolStripMenuItem.Name = "поИздательствуToolStripMenuItem";
            this.поИздательствуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поИздательствуToolStripMenuItem.Text = "По издательству";
            // 
            // aSKToolStripMenuItem
            // 
            this.aSKToolStripMenuItem.Name = "aSKToolStripMenuItem";
            this.aSKToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.aSKToolStripMenuItem.Text = "ASK";
            // 
            // dESCToolStripMenuItem
            // 
            this.dESCToolStripMenuItem.Name = "dESCToolStripMenuItem";
            this.dESCToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.dESCToolStripMenuItem.Text = "DESC";
            // 
            // dgv_library
            // 
            this.dgv_library.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_library.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_library.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.author,
            this.genre,
            this.publishYear,
            this.pages,
            this.publisher});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_library.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_library.Location = new System.Drawing.Point(0, 27);
            this.dgv_library.MultiSelect = false;
            this.dgv_library.Name = "dgv_library";
            this.dgv_library.RowHeadersVisible = false;
            this.dgv_library.RowTemplate.Height = 25;
            this.dgv_library.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_library.Size = new System.Drawing.Size(800, 423);
            this.dgv_library.TabIndex = 1;
            this.dgv_library.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_library_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // author
            // 
            this.author.HeaderText = "Author";
            this.author.Name = "author";
            // 
            // genre
            // 
            this.genre.HeaderText = "Genre";
            this.genre.Name = "genre";
            // 
            // publishYear
            // 
            this.publishYear.HeaderText = "PublishYear";
            this.publishYear.Name = "publishYear";
            // 
            // pages
            // 
            this.pages.HeaderText = "Pages";
            this.pages.Name = "pages";
            // 
            // publisher
            // 
            this.publisher.HeaderText = "Publisher";
            this.publisher.Name = "publisher";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_library);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_library)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem редактироватьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private DataGridView dgv_library;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn author;
        private DataGridViewTextBoxColumn genre;
        private DataGridViewTextBoxColumn publishYear;
        private DataGridViewTextBoxColumn pages;
        private DataGridViewTextBoxColumn publisher;
        private ToolStripMenuItem загрузитИзБазыToolStripMenuItem;
        private ToolStripMenuItem загрузитьИзXMLToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem cToolStripMenuItem;
        private ToolStripMenuItem сохранитьВXMLToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem фильтрToolStripMenuItem;
        private ToolStripMenuItem поИмениToolStripMenuItem;
        private ToolStripMenuItem nameFilteraSKToolStripMenuItem1;
        private ToolStripMenuItem nameFilterdESCToolStripMenuItem1;
        private ToolStripMenuItem поАвторуToolStripMenuItem;
        private ToolStripMenuItem aSKToolStripMenuItem2;
        private ToolStripMenuItem dESCToolStripMenuItem2;
        private ToolStripMenuItem поИздательствуToolStripMenuItem;
        private ToolStripMenuItem aSKToolStripMenuItem;
        private ToolStripMenuItem dESCToolStripMenuItem;
    }
}