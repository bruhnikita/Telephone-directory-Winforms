namespace Telephone_directory_Winforms
{
    partial class MainForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtName = new TextBox();
            txtNumber = new TextBox();
            txtAddres = new TextBox();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            contactListBox = new ListBox();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(txtName);
            flowLayoutPanel1.Controls.Add(txtNumber);
            flowLayoutPanel1.Controls.Add(txtAddres);
            flowLayoutPanel1.Controls.Add(txtSearch);
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Controls.Add(btnRemove);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(220, 562);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Top;
            txtName.Location = new Point(3, 3);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Введите имя:";
            txtName.Size = new Size(217, 23);
            txtName.TabIndex = 0;
            // 
            // txtNumber
            // 
            txtNumber.Dock = DockStyle.Top;
            txtNumber.Location = new Point(3, 32);
            txtNumber.Name = "txtNumber";
            txtNumber.PlaceholderText = "Введите номер:";
            txtNumber.Size = new Size(217, 23);
            txtNumber.TabIndex = 1;
            // 
            // txtAddres
            // 
            txtAddres.Dock = DockStyle.Top;
            txtAddres.Location = new Point(3, 61);
            txtAddres.Name = "txtAddres";
            txtAddres.PlaceholderText = "Введите адрес:";
            txtAddres.Size = new Size(217, 23);
            txtAddres.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Top;
            txtSearch.Location = new Point(3, 90);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Поле для поиска";
            txtSearch.Size = new Size(217, 23);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Top;
            btnAdd.Location = new Point(3, 119);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(220, 41);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Dock = DockStyle.Top;
            btnRemove.Location = new Point(3, 166);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(220, 41);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Удалить";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // contactListBox
            // 
            contactListBox.Dock = DockStyle.Fill;
            contactListBox.FormattingEnabled = true;
            contactListBox.ItemHeight = 15;
            contactListBox.Location = new Point(220, 0);
            contactListBox.Name = "contactListBox";
            contactListBox.Size = new Size(587, 562);
            contactListBox.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 562);
            Controls.Add(contactListBox);
            Controls.Add(flowLayoutPanel1);
            Name = "MainForm";
            Text = "Телефонный справочник";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txtName;
        private TextBox txtNumber;
        private TextBox txtAddres;
        private TextBox txtSearch;
        private Button btnAdd;
        private Button btnRemove;
        private ListBox contactListBox;
    }
}
