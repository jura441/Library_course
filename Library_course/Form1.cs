using System.Data;

namespace Library_course
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dataTable = new DataTable();
         
        private Book bufferBook = new Book();

        private void Form1_Load(object sender, EventArgs e)

        {
           // dataTable.Columns.Add(new DataColumn("ID", typeof(int)));
            //dataTable.Rows.Add();
            dgv_library.Rows.Add("0", "Âèé", "Í.Â.Ãîãîëü", "Âèé", "1967", "437", "Àçáóêà");
            dgv_library.Rows.Add("1", "Âèé", "Í.Â.Ãîãîëü", "Âèé", "1967", "437", "Àçáóêà");
            dgv_library.Rows.Add("2", "Âèé", "Í.Â.Ãîãîëü", "Âèé", "1967", "437", "Àçáóêà");
            dgv_library.Rows.Add("3", "Âèé", "Í.Â.Ãîãîëü", "Âèé", "1967", "437", "Àçáóêà");
        }

        private void dgv_library_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void óäàëèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_library.SelectedRows[0].Index >= 0)
                dgv_library.Rows.RemoveAt(dgv_library.SelectedRows[0].Index);
        }

        private void ðåäàêòèðîâàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_library.SelectedRows.Count > 0)
            {
                bufferBook = new Book(
                    Convert.ToInt32(dgv_library.SelectedRows[0].Cells[0].Value.ToString()),
                    dgv_library.SelectedRows[0].Cells[1].Value.ToString(),
                    dgv_library.SelectedRows[0].Cells[2].Value.ToString(),
                    dgv_library.SelectedRows[0].Cells[3].Value.ToString(),
                    Convert.ToInt32(dgv_library.SelectedRows[0].Cells[4].Value.ToString()),
                    Convert.ToInt32(dgv_library.SelectedRows[0].Cells[5].Value.ToString()),
                    dgv_library.SelectedRows[0].Cells[6].Value.ToString());
                EditBook editForm = new EditBook(bufferBook);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    bufferBook = editForm.EditableBook;
                    dgv_library.SelectedRows[0].Cells[0].Value = bufferBook.Id;
                    dgv_library.SelectedRows[0].Cells[1].Value = bufferBook.Name;
                    dgv_library.SelectedRows[0].Cells[2].Value = bufferBook.Author;
                    dgv_library.SelectedRows[0].Cells[3].Value = bufferBook.Genre;
                    dgv_library.SelectedRows[0].Cells[4].Value = bufferBook.PublishYear;
                    dgv_library.SelectedRows[0].Cells[5].Value = bufferBook.Pages;
                    dgv_library.SelectedRows[0].Cells[6].Value = bufferBook.Publisher;
                    editForm.Close();
                }
                
            }
        }

        private void ñîçäàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook addForm = new AddBook();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                bufferBook = addForm.AddableBook;
                dgv_library.Rows.Add(
                bufferBook.Id,
                bufferBook.Name,
                bufferBook.Author,
                bufferBook.Genre,
                bufferBook.PublishYear,
                bufferBook.Pages,
                bufferBook.Publisher);
            }
                
        }

        private void nameFilteraSKToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void nameFilterdESCToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}