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

    public partial class AddorEdit : Form
    {
        StudentsDatabaseEntities db = new StudentsDatabaseEntities();
        Students stud = new Students();
        public AddorEdit()
        {
            InitializeComponent();
        }
        public AddorEdit(int StudID)
        {
            InitializeComponent();
            this.Text = "Edytuj";
            Students st = db.Students.Find(StudID);

            IDTextBox.Text = st.ID.ToString();
            NameTextBox.Text = st.Name.ToString();
            SurnameTextBox.Text = st.Surname.ToString();
            IndexNumberTextBox.Text = st.IndexNumber.ToString();
            DateOfBirthTextBox.Text = st.DateOfBirth.ToString();
            MarkTextBox.Text = st.Mark.ToString();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


            private void SaveButton_Click(object sender, EventArgs e)
        {
            if (this.Text == "Dodaj")
            {
                Add();
               
            }
            else
            {
                if (this.Text == "Edytuj")
                {
                    Add(Convert.ToInt32(IDTextBox.Text.ToString()));
                   
                }
            }

        }

        public void Add()
        {

            stud.Name = NameTextBox.Text;
            stud.Surname = SurnameTextBox.Text;
            stud.IndexNumber = Convert.ToInt32(IndexNumberTextBox.Text);
            stud.DateOfBirth = DateOfBirthTextBox.Text;
            stud.Mark = MarkTextBox.Text;

            db.Students.Add(stud);

            db.SaveChanges();
            this.Close();
        }

        public void Add(int StudID)
        {
            Students stud = db.Students.Find(StudID);

            stud.Name = NameTextBox.Text;
            stud.Surname = SurnameTextBox.Text;
            stud.IndexNumber = Convert.ToInt32(IndexNumberTextBox.Text);
            stud.DateOfBirth = DateOfBirthTextBox.Text;
            stud.Mark = MarkTextBox.Text;

            db.SaveChanges();

            this.Close();
        }
    }
}
