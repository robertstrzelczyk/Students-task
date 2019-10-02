using StudentsTask.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsTask
{
    public partial class Form1 : Form
    {
        StudentsDatabaseEntities db = new StudentsDatabaseEntities();
        public Form1()
        {
            InitializeComponent();

            RefreshStudents();
            StudentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SearchTextBox.ForeColor = Color.Gray;
            SearchTextBox.Text = "Szukaj (imię, nazwisko, numer indeksu lub date urodzenia)";
            // TODO: This line of code loads data into the 'studentsDatabaseDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.studentsDatabaseDataSet.Students);

        }
        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "Szukaj (imię, nazwisko, numer indeksu lub date urodzenia)")
            {
                SearchTextBox.ForeColor = Color.Black;
                SearchTextBox.Text = "";
            }

        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "")
            {
                SearchTextBox.ForeColor = Color.Gray;
                SearchTextBox.Text = "Szukaj (imię, nazwisko, numer indeksu lub date urodzenia)";
            }

        }

        public void RefreshStudents()
        {
            StudentsDataGridView.DataSource = new StudentsDatabaseEntities().Students.ToList();
        }

        public List<int> SelectRows()
        {
            List<int> GridID = new List<int>();
            for (int i = 0; i < StudentsDataGridView.Rows.Count; i++)
            {
                if (Convert.ToBoolean(StudentsDataGridView.Rows[i].Cells["CheckBox"].Value) == true)
                {
                    GridID.Add(Convert.ToInt32(StudentsDataGridView.Rows[i].Cells["iDDataGridViewTextBoxColumn"].Value));                 
                }
              
            }
            return GridID;

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            
        }
        private void AddorEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshStudents();
        }
        private void AddMark_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshStudents();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddorEdit Add = new AddorEdit();
            Add.FormClosing += new FormClosingEventHandler(this.AddorEdit_FormClosing);
            Add.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            List<int> IDList = SelectRows();
            foreach (int i in IDList)
            {
                AddorEdit Edit = new AddorEdit(i);
                Edit.FormClosing += new FormClosingEventHandler(this.AddorEdit_FormClosing);
                Edit.Show();

            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            List<int> ListID = SelectRows();
            foreach (int i in ListID)
            {
                Students st = db.Students.Find(i);
                db.Students.Remove(st);
               
            }

            db.SaveChanges();

            RefreshStudents();
        }
       
        private void StudentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            int c = 0;
            if (string.IsNullOrWhiteSpace(SearchTextBox.Text))
            {
                label2.Visible = true;
            }
            else
            {
                label2.Visible = false;
                foreach (DataGridViewRow row in StudentsDataGridView.Rows)
                {
                    if (row.Cells["nameDataGridViewTextBoxColumn"].Value.ToString().ToLower().Equals(SearchTextBox.Text.ToLower()) ||
                        row.Cells["surnameDataGridViewTextBoxColumn"].Value.ToString().ToLower().Equals(SearchTextBox.Text.ToLower()) ||
                        row.Cells["indexNumberDataGridViewTextBoxColumn"].Value.ToString().ToLower().Equals(SearchTextBox.Text.ToLower()) ||
                        row.Cells["dateOfBirthDataGridViewTextBoxColumn"].Value.ToString().ToLower().Equals(SearchTextBox.Text.ToLower()))
                    {
                       
                        var results = db.Students.Where(p => p.Name.Contains(SearchTextBox.Text) ||
                                                             p.Surname.Contains(SearchTextBox.Text) ||
                                                             p.IndexNumber.ToString().Contains(SearchTextBox.Text) ||
                                                             p.DateOfBirth.Contains(SearchTextBox.Text));
                        StudentsDataGridView.DataSource = results.ToList();
                        CancelButton.Enabled = true;
                        CancelButton.Visible = true;
                        c++;
                    }
                    else
                    {
                        RefreshStudents();
                        CancelButton.Enabled = false;
                        CancelButton.Visible = false;
                    }

                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            RefreshStudents();
            CancelButton.Enabled = false;
            CancelButton.Visible = false;
        }
    }
}
