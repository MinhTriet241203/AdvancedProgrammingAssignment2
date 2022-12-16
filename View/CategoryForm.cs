using System;
using System.Data;
using System.Windows.Forms;
using AdvancedProgrammingAssignment2.Controller;
using MongoDB.Bson;
using MongoDB.Driver;

namespace AdvancedProgrammingAssignment2.View
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            dataGridViewCategory.DataSource = CategoryManage.ShowCategory();
        }

        private void dataGridViewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxName.Text = dataGridViewCategory.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void iconButtonCreate_Click(object sender, EventArgs e)
        {
            CategoryManage.AddCategory(textBoxName.Text);
            dataGridViewCategory.DataSource = CategoryManage.ShowCategory();
        }
    }
}