using System.ComponentModel;

namespace AdvancedProgrammingAssignment2.View
{
    partial class BookForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitle = new System.Windows.Forms.Label();
            this.separator = new System.Windows.Forms.Label();
            this.dataGridViewBook = new System.Windows.Forms.DataGridView();
            this.labelBook = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.iconButtonCreate = new FontAwesome.Sharp.IconButton();
            this.iconButtonDelete = new FontAwesome.Sharp.IconButton();
            this.iconButtonUpdate = new FontAwesome.Sharp.IconButton();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.iconButtonSearch = new FontAwesome.Sharp.IconButton();
            this.textBoxIsbn = new System.Windows.Forms.TextBox();
            this.labelIsbn = new System.Windows.Forms.Label();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.labelState = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonAddImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.labelTitle.Size = new System.Drawing.Size(1032, 66);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Book Management";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // separator
            // 
            this.separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator.Dock = System.Windows.Forms.DockStyle.Top;
            this.separator.Location = new System.Drawing.Point(0, 66);
            this.separator.Margin = new System.Windows.Forms.Padding(0);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(1032, 2);
            this.separator.TabIndex = 1;
            // 
            // dataGridViewBook
            // 
            this.dataGridViewBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBook.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBook.Location = new System.Drawing.Point(12, 116);
            this.dataGridViewBook.MultiSelect = false;
            this.dataGridViewBook.Name = "dataGridViewBook";
            this.dataGridViewBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBook.Size = new System.Drawing.Size(510, 464);
            this.dataGridViewBook.TabIndex = 2;
            this.dataGridViewBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategory_CellContentClick);
            // 
            // labelBook
            // 
            this.labelBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.labelBook.Location = new System.Drawing.Point(539, 82);
            this.labelBook.Name = "labelBook";
            this.labelBook.Size = new System.Drawing.Size(486, 31);
            this.labelBook.TabIndex = 3;
            this.labelBook.Text = "Book info";
            this.labelBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.labelName.Location = new System.Drawing.Point(543, 126);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(142, 30);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Book Name:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(687, 128);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(338, 31);
            this.textBoxName.TabIndex = 6;
            // 
            // iconButtonCreate
            // 
            this.iconButtonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.iconButtonCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconButtonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.iconButtonCreate.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButtonCreate.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.iconButtonCreate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCreate.IconSize = 30;
            this.iconButtonCreate.Location = new System.Drawing.Point(899, 395);
            this.iconButtonCreate.Name = "iconButtonCreate";
            this.iconButtonCreate.Size = new System.Drawing.Size(126, 36);
            this.iconButtonCreate.TabIndex = 7;
            this.iconButtonCreate.Text = "Add";
            this.iconButtonCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCreate.UseVisualStyleBackColor = false;
            this.iconButtonCreate.Click += new System.EventHandler(this.iconButtonCreate_Click);
            // 
            // iconButtonDelete
            // 
            this.iconButtonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.iconButtonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.iconButtonDelete.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.iconButtonDelete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.iconButtonDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDelete.IconSize = 30;
            this.iconButtonDelete.Location = new System.Drawing.Point(899, 517);
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
            this.iconButtonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.iconButtonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.iconButtonUpdate.IconChar = FontAwesome.Sharp.IconChar.CircleUp;
            this.iconButtonUpdate.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.iconButtonUpdate.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonUpdate.IconSize = 30;
            this.iconButtonUpdate.Location = new System.Drawing.Point(899, 457);
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
            this.textBoxId.Location = new System.Drawing.Point(539, 87);
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(78, 23);
            this.textBoxId.TabIndex = 10;
            this.textBoxId.Visible = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(12, 82);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(391, 28);
            this.textBoxSearch.TabIndex = 11;
            // 
            // iconButtonSearch
            // 
            this.iconButtonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.iconButtonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.iconButtonSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButtonSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.iconButtonSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSearch.IconSize = 18;
            this.iconButtonSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButtonSearch.Location = new System.Drawing.Point(419, 82);
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
            // textBoxIsbn
            // 
            this.textBoxIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIsbn.Location = new System.Drawing.Point(687, 165);
            this.textBoxIsbn.Multiline = true;
            this.textBoxIsbn.Name = "textBoxIsbn";
            this.textBoxIsbn.Size = new System.Drawing.Size(338, 31);
            this.textBoxIsbn.TabIndex = 14;
            // 
            // labelIsbn
            // 
            this.labelIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIsbn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.labelIsbn.Location = new System.Drawing.Point(543, 166);
            this.labelIsbn.Name = "labelIsbn";
            this.labelIsbn.Size = new System.Drawing.Size(98, 30);
            this.labelIsbn.TabIndex = 13;
            this.labelIsbn.Text = "ISBN: ";
            this.labelIsbn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAuthor.Location = new System.Drawing.Point(687, 202);
            this.textBoxAuthor.Multiline = true;
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(338, 31);
            this.textBoxAuthor.TabIndex = 16;
            // 
            // labelAuthor
            // 
            this.labelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.labelAuthor.Location = new System.Drawing.Point(550, 203);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(98, 30);
            this.labelAuthor.TabIndex = 15;
            this.labelAuthor.Text = "Author: ";
            this.labelAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCategory.Location = new System.Drawing.Point(687, 239);
            this.textBoxCategory.Multiline = true;
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(338, 31);
            this.textBoxCategory.TabIndex = 18;
            // 
            // labelCategory
            // 
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.labelCategory.Location = new System.Drawing.Point(552, 240);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(98, 30);
            this.labelCategory.TabIndex = 17;
            this.labelCategory.Text = "Category:";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxState
            // 
            this.textBoxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxState.Location = new System.Drawing.Point(687, 276);
            this.textBoxState.Multiline = true;
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(338, 31);
            this.textBoxState.TabIndex = 20;
            // 
            // labelState
            // 
            this.labelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.labelState.Location = new System.Drawing.Point(543, 276);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(98, 30);
            this.labelState.TabIndex = 19;
            this.labelState.Text = "State:";
            this.labelState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(550, 314);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 250);
            this.pictureBox.TabIndex = 21;
            this.pictureBox.TabStop = false;
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(204)))));
            this.buttonAddImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(204)))));
            this.buttonAddImage.FlatAppearance.BorderSize = 0;
            this.buttonAddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddImage.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.buttonAddImage.Location = new System.Drawing.Point(899, 335);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(126, 36);
            this.buttonAddImage.TabIndex = 22;
            this.buttonAddImage.Text = "Add image";
            this.buttonAddImage.UseVisualStyleBackColor = false;
            // 
            // BookForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1032, 576);
            this.ControlBox = false;
            this.Controls.Add(this.buttonAddImage);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.textBoxIsbn);
            this.Controls.Add(this.labelIsbn);
            this.Controls.Add(this.iconButtonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.iconButtonUpdate);
            this.Controls.Add(this.iconButtonDelete);
            this.Controls.Add(this.iconButtonCreate);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelBook);
            this.Controls.Add(this.dataGridViewBook);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.labelTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "CategoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox pictureBox;

        private System.Windows.Forms.Button buttonAddImage;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.Label labelState;

        private System.Windows.Forms.Label labelIsbn;
        private System.Windows.Forms.TextBox textBoxIsbn;

        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label labelAuthor;

        private System.Windows.Forms.TextBox textBoxSearch;
        private FontAwesome.Sharp.IconButton iconButtonSearch;

        private System.Windows.Forms.TextBox textBoxId;

        private FontAwesome.Sharp.IconButton iconButtonDelete;

        private FontAwesome.Sharp.IconButton iconButtonUpdate;
        
        private FontAwesome.Sharp.IconButton iconButtonCreate;

        private System.Windows.Forms.TextBox textBoxName;

        private System.Windows.Forms.Label labelName;

        private System.Windows.Forms.Label labelBook;

        public System.Windows.Forms.DataGridView dataGridViewBook;

        private System.Windows.Forms.Label separator;

        private System.Windows.Forms.Label labelTitle;

        #endregion
    }
}