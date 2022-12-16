using System.ComponentModel;

namespace AdvancedProgrammingAssignment2.View
{
    partial class CategoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.labelTitle = new System.Windows.Forms.Label();
            this.separator = new System.Windows.Forms.Label();
            this.dataGridViewCategory = new System.Windows.Forms.DataGridView();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.iconButtonCreate = new FontAwesome.Sharp.IconButton();
            this.iconButtonDelete = new FontAwesome.Sharp.IconButton();
            this.iconButtonUpdate = new FontAwesome.Sharp.IconButton();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.iconButtonSearch = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Lato Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.labelTitle.Size = new System.Drawing.Size(1032, 66);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Category Management";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // separator
            // 
            this.separator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator.Location = new System.Drawing.Point(12, 64);
            this.separator.Margin = new System.Windows.Forms.Padding(0);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(1012, 2);
            this.separator.TabIndex = 1;
            // 
            // dataGridViewCategory
            // 
            this.dataGridViewCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCategory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategory.Location = new System.Drawing.Point(12, 120);
            this.dataGridViewCategory.MultiSelect = false;
            this.dataGridViewCategory.Name = "dataGridViewCategory";
            this.dataGridViewCategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCategory.Size = new System.Drawing.Size(464, 452);
            this.dataGridViewCategory.TabIndex = 2;
            this.dataGridViewCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategory_CellContentClick);
            // 
            // labelCategory
            // 
            this.labelCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCategory.Font = new System.Drawing.Font("Lato", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.labelCategory.Location = new System.Drawing.Point(484, 120);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(544, 31);
            this.labelCategory.TabIndex = 3;
            this.labelCategory.Text = "Category";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelName.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.labelName.Location = new System.Drawing.Point(517, 164);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(121, 22);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Category Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName.Location = new System.Drawing.Point(507, 189);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(500, 23);
            this.textBoxName.TabIndex = 6;
            // 
            // iconButtonCreate
            // 
            this.iconButtonCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.iconButtonCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconButtonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCreate.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.iconButtonCreate.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButtonCreate.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.iconButtonCreate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCreate.IconSize = 30;
            this.iconButtonCreate.Location = new System.Drawing.Point(507, 231);
            this.iconButtonCreate.Name = "iconButtonCreate";
            this.iconButtonCreate.Size = new System.Drawing.Size(126, 36);
            this.iconButtonCreate.TabIndex = 7;
            this.iconButtonCreate.Text = "Create";
            this.iconButtonCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCreate.UseVisualStyleBackColor = false;
            this.iconButtonCreate.Click += new System.EventHandler(this.iconButtonCreate_Click);
            // 
            // iconButtonDelete
            // 
            this.iconButtonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.iconButtonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDelete.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.iconButtonDelete.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.iconButtonDelete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.iconButtonDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDelete.IconSize = 30;
            this.iconButtonDelete.Location = new System.Drawing.Point(881, 231);
            this.iconButtonDelete.Name = "iconButtonDelete";
            this.iconButtonDelete.Size = new System.Drawing.Size(126, 36);
            this.iconButtonDelete.TabIndex = 8;
            this.iconButtonDelete.Text = "Delete";
            this.iconButtonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDelete.UseVisualStyleBackColor = false;
            this.iconButtonDelete.Click += new System.EventHandler(this.iconButtonDelete_Click);
            // 
            // iconButtonUpdate
            // 
            this.iconButtonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.iconButtonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonUpdate.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.iconButtonUpdate.IconChar = FontAwesome.Sharp.IconChar.CircleUp;
            this.iconButtonUpdate.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.iconButtonUpdate.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonUpdate.IconSize = 30;
            this.iconButtonUpdate.Location = new System.Drawing.Point(695, 231);
            this.iconButtonUpdate.Name = "iconButtonUpdate";
            this.iconButtonUpdate.Size = new System.Drawing.Size(126, 36);
            this.iconButtonUpdate.TabIndex = 9;
            this.iconButtonUpdate.Text = "Update";
            this.iconButtonUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonUpdate.UseVisualStyleBackColor = false;
            this.iconButtonUpdate.Click += new System.EventHandler(this.iconButtonUpdate_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxId.Location = new System.Drawing.Point(507, 312);
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(500, 23);
            this.textBoxId.TabIndex = 10;
            this.textBoxId.Visible = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearch.Location = new System.Drawing.Point(12, 82);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(354, 28);
            this.textBoxSearch.TabIndex = 11;
            // 
            // iconButtonSearch
            // 
            this.iconButtonSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.iconButtonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSearch.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.iconButtonSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButtonSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.iconButtonSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSearch.IconSize = 18;
            this.iconButtonSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButtonSearch.Location = new System.Drawing.Point(372, 82);
            this.iconButtonSearch.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonSearch.Name = "iconButtonSearch";
            this.iconButtonSearch.Size = new System.Drawing.Size(104, 28);
            this.iconButtonSearch.TabIndex = 12;
            this.iconButtonSearch.Text = "Search";
            this.iconButtonSearch.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.iconButtonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSearch.UseVisualStyleBackColor = false;
            this.iconButtonSearch.Click += new System.EventHandler(this.iconButtonSearch_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1032, 576);
            this.ControlBox = false;
            this.Controls.Add(this.iconButtonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.iconButtonUpdate);
            this.Controls.Add(this.iconButtonDelete);
            this.Controls.Add(this.iconButtonCreate);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.dataGridViewCategory);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.labelTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CategoryForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "CategoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxSearch;
        private FontAwesome.Sharp.IconButton iconButtonSearch;

        private System.Windows.Forms.TextBox textBoxId;

        private FontAwesome.Sharp.IconButton iconButtonDelete;

        private FontAwesome.Sharp.IconButton iconButtonUpdate;
        
        private FontAwesome.Sharp.IconButton iconButtonCreate;

        private System.Windows.Forms.TextBox textBoxName;

        private System.Windows.Forms.Label labelName;

        private System.Windows.Forms.Label labelCategory;

        public System.Windows.Forms.DataGridView dataGridViewCategory;

        private System.Windows.Forms.Label separator;

        private System.Windows.Forms.Label labelTitle;

        #endregion
    }
}