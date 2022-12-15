using System;
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
            
            var list = CategoryManage.CategoryCollection.Find(new BsonDocument()).ToList();
            dataGridViewCategory.DataSource = list;
        }

        private void dataGridViewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}