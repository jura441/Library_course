namespace Library_course
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_library.Rows.Add("0", "���", "�.�.������", "���", "1967", "437", "������");
            dgv_library.Rows.Add("1", "���", "�.�.������", "���", "1967", "437", "������");
            dgv_library.Rows.Add("2", "���", "�.�.������", "���", "1967", "437", "������");
            dgv_library.Rows.Add("3", "���", "�.�.������", "���", "1967", "437", "������");
        }

        private void dgv_library_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_library.SelectedRows[0].Index >= 0)
                dgv_library.Rows.RemoveAt(dgv_library.SelectedRows[0].Index);
        }

        private void �������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBook editForm = new EditBook();
            if (editForm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook addForm = new AddBook();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                 
            }
        }
    }
}