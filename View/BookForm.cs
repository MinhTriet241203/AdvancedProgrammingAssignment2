using System;
using System.Windows.Forms;
using AdvancedProgrammingAssignment2.Controller;

namespace AdvancedProgrammingAssignment2.View
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
            dataGridViewBook.DataSource = CategoryManage.ShowCategory();
            dataGridViewBook.Columns["Id"].Visible = false;
        }

        private void dataGridViewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridViewBook.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxName.Text = dataGridViewBook.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void iconButtonCreate_Click(object sender, EventArgs e)
        {
            var result = CategoryManage.AddCategory(textBoxName.Text);
            dataGridViewBook.DataSource = CategoryManage.ShowCategory();
            MessageBox.Show(result, @"Message");
        }

        private void iconButtonUpdate_Click(object sender, EventArgs e)
        {
            var result = CategoryManage.UpdateCategory(textBoxId.Text, textBoxName.Text);
            dataGridViewBook.DataSource = CategoryManage.ShowCategory();
            MessageBox.Show(result, @"Message");
        }

        private void iconButtonDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show($@"Confirm delete of ""{textBoxName.Text}"" ?",
                @"Confirm delete",
                MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                var result = CategoryManage.DeleteCategory(textBoxId.Text);
                dataGridViewBook.DataSource = CategoryManage.ShowCategory();
                MessageBox.Show(result, @"Message");
            }
        }

        private void iconButtonSearch_Click(object sender, EventArgs e)
        {
            var list = CategoryManage.SearchCategory(textBoxSearch.Text);
            if (list != null)
            {
                dataGridViewBook.DataSource = list;
            }
            else
            {
                dataGridViewBook.DataSource = CategoryManage.ShowCategory();
                MessageBox.Show(@"No result for """ + textBoxSearch.Text + @""" :(", @"Message");
            }
        }

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
        }
    }
}