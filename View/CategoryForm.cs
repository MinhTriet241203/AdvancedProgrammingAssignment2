using System;
using System.Windows.Forms;
using AdvancedProgrammingAssignment2.Controller;

namespace AdvancedProgrammingAssignment2.View
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            dataGridViewCategory.DataSource = CategoryManage.ShowCategory();
            dataGridViewCategory.Columns["Id"].Visible = false;
        }

        private void dataGridViewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridViewCategory.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxName.Text = dataGridViewCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void iconButtonCreate_Click(object sender, EventArgs e)
        {
            var result = CategoryManage.AddCategory(textBoxName.Text);
            dataGridViewCategory.DataSource = CategoryManage.ShowCategory();
            MessageBox.Show(result, @"Message");
        }

        private void iconButtonUpdate_Click(object sender, EventArgs e)
        {
            var result = CategoryManage.UpdateCategory(textBoxId.Text, textBoxName.Text);
            dataGridViewCategory.DataSource = CategoryManage.ShowCategory();
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
                dataGridViewCategory.DataSource = CategoryManage.ShowCategory();
                MessageBox.Show(result, "Message");
            }
        }

        private void iconButtonSearch_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}