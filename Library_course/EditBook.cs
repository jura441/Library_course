using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_course
{
    public partial class EditBook : Form
    {
        public  Book EditableBook { get; set; }
        public EditBook(Book book)
        { 
            InitializeComponent();
            EditableBook = book;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
             this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void EditBook_Load(object sender, EventArgs e)
        {
            tb_author.Text = EditableBook.Author;
            tb_genre.Text = EditableBook.Genre;
            tb_id.Text = EditableBook.Id.ToString(); 
            tb_Pages.Text = EditableBook.Pages.ToString();
            tb_Pages.Text = EditableBook.Publisher.ToString();
            tb_Pages.Text = EditableBook.PublishYear.ToString();
            tb_name.Text = EditableBook.Name;
        }

        private void tb_id_TextChanged(object sender, EventArgs e)
        {
            if(tb_id.Text.Length > 0)
            {
                EditableBook.Id = Convert.ToInt32(tb_id.Text);
            }
            else
            {
                MessageBox.Show("Поле не может быть пустым");
            }
        }

        private void tb_Publishyear_TextChanged(object sender, EventArgs e)
        {
            if (tb_Publishyear.Text.Length > 0)
            {
                EditableBook.PublishYear = Convert.ToInt32(tb_Publishyear.Text);
            }
            else
            {
                MessageBox.Show("Поле не может быть пустым");
            }
        }

        private void tb_Pages_TextChanged(object sender, EventArgs e)
        {
            if (tb_Pages.Text.Length > 0)
            {
                EditableBook.Pages = Convert.ToInt32(tb_Pages.Text);
            }
            else
            {
                MessageBox.Show("Поле не может быть пустым");
            }
        }
    }
}
