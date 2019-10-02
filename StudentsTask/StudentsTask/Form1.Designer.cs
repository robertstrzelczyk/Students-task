namespace StudentsTask
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.StudentsDataGridView = new System.Windows.Forms.DataGridView();
            this.Checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indexNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsDatabaseDataSet = new StudentsTask.StudentsDatabaseDataSet();
            this.studentsTableAdapter = new StudentsTask.StudentsDatabaseDataSetTableAdapters.StudentsTableAdapter();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentsDataGridView
            // 
            this.StudentsDataGridView.AutoGenerateColumns = false;
            this.StudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Checkbox,
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.indexNumberDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.markDataGridViewTextBoxColumn});
            this.StudentsDataGridView.DataSource = this.studentsBindingSource;
            this.StudentsDataGridView.Location = new System.Drawing.Point(12, 79);
            this.StudentsDataGridView.Name = "StudentsDataGridView";
            this.StudentsDataGridView.Size = new System.Drawing.Size(644, 255);
            this.StudentsDataGridView.TabIndex = 0;
            this.StudentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsDataGridView_CellContentClick);
            // 
            // Checkbox
            // 
            this.Checkbox.HeaderText = "";
            this.Checkbox.Name = "Checkbox";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // indexNumberDataGridViewTextBoxColumn
            // 
            this.indexNumberDataGridViewTextBoxColumn.DataPropertyName = "IndexNumber";
            this.indexNumberDataGridViewTextBoxColumn.HeaderText = "IndexNumber";
            this.indexNumberDataGridViewTextBoxColumn.Name = "indexNumberDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // markDataGridViewTextBoxColumn
            // 
            this.markDataGridViewTextBoxColumn.DataPropertyName = "Mark";
            this.markDataGridViewTextBoxColumn.HeaderText = "Mark";
            this.markDataGridViewTextBoxColumn.Name = "markDataGridViewTextBoxColumn";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.studentsDatabaseDataSet;
            // 
            // studentsDatabaseDataSet
            // 
            this.studentsDatabaseDataSet.DataSetName = "StudentsDatabaseDataSet";
            this.studentsDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(12, 41);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(345, 20);
            this.SearchTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wyszukiwarka: ";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(363, 39);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(87, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Wyszukaj";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(482, 32);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(97, 36);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Dodaj studenta";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(585, 32);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(97, 36);
            this.EditButton.TabIndex = 5;
            this.EditButton.Text = "Edytuj studenta";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(688, 32);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(97, 36);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Usuń studenta";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(688, 298);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(97, 36);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Wyjdź";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(811, 360);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.StudentsDataGridView);
            this.Name = "Form1";
            this.Text = "Baza studentów";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentsDataGridView;
        private StudentsDatabaseDataSet studentsDatabaseDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private StudentsDatabaseDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

