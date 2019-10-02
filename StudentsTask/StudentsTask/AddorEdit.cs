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
using System.Text.RegularExpressions; //biblioteka do wyrażeń

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
            if (MarkTextBox.Text == null)
            {
                MarkTextBox.Text = st.Mark.ToString();
            }
           
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

        public bool CheckValue()
        {
            bool[] errorArray = new bool[5]; //w formularzu jest pięć pól do obsługi wyrażeń
            bool err = false;

            for (int i=0; i<5; i++)
            {
                errorArray[i] = false;
            }

            // Name
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                NameLabel.Text = "To pole nie może być puste!";
                NameLabel.Visible = true;
                errorArray[0] = true;
            }
            else
            {
                if(NameTextBox.Text.Length > 15)
                {
                    NameLabel.Text = "Maksymalnie 15 znaków!";
                    NameLabel.Visible = true;
                    errorArray[0] = true;
                }
                else
                {
                    NameLabel.Visible = false;
                    errorArray[0] = false;
                }
            }

            // Surname
            if (string.IsNullOrWhiteSpace(SurnameTextBox.Text))
            {
                SurnameLabel.Text = "To pole nie może być puste!";
                SurnameLabel.Visible = true;
                errorArray[1] = true;
            }
            else
            {
                if (SurnameTextBox.Text.Length > 30)
                {
                    SurnameLabel.Text = "Maksymalnie 30 znaków!";
                    SurnameLabel.Visible = true;
                    errorArray[1] = true;
                }
                else
                {
                    SurnameLabel.Visible = false;
                    errorArray[1] = false;
                }
            }

            // IndexNumber
            if (string.IsNullOrWhiteSpace(IndexNumberTextBox.Text))
            {
                IndexNumberLabel.Text = "To pole nie może być puste!";
                IndexNumberLabel.Visible = true;
                errorArray[2] = true;
            }
            else
            {
                if (!Regex.IsMatch(IndexNumberTextBox.Text, "^[0-9]*$"))
                {
                    IndexNumberLabel.Text = "Tylko liczby całkowite!";
                    IndexNumberLabel.Visible = true;
                    errorArray[2] = true;
                }
                else
                {
                    IndexNumberLabel.Visible = false;
                    errorArray[2] = false;
                }
            }

            // DateOfBirth
            if (string.IsNullOrWhiteSpace(DateOfBirthTextBox.Text))
            {
                DateOfBirthLabel.Text = "To pole nie może być puste!";
                DateOfBirthLabel.Visible = true;
                errorArray[3] = true;
            }
            else
            {
                if (!Regex.IsMatch(DateOfBirthTextBox.Text, "^[0-9]{4}-(((0[13578]|(10|12))-(0[1-9]|[1-2][0-9]|3[0-1]))|(02-(0[1-9]|[1-2][0-9]))|((0[469]|11)-(0[1-9]|[1-2][0-9]|30)))$"))
                {
                    DateOfBirthLabel.Text = "Podany format jest nieprawidłowy!";
                    DateOfBirthLabel.Visible = true;
                    errorArray[3] = true;
                }
                else
                {
                    DateOfBirthLabel.Visible = false;
                    errorArray[3] = false;
                }
            }

            //Mark
                if (!Regex.IsMatch(MarkTextBox.Text, "^[0-9]*[,][0-9]{1}$") && this.Text == "Edytuj")
                {
                    MarkLabel.Text = "Tylko liczby (np. 3,0)!";
                    MarkLabel.Visible = true;
                    errorArray[4] = true;
                }
                else
                {
                    MarkLabel.Visible = false;
                    errorArray[4] = false;
                }        
            for (int i = 0; i < 5; i++)
            {
                err = err || errorArray[i];
            }
            return err;
        }

        public void Add()
        {
            bool err = CheckValue();
            if (err == true)
            {
                MessageBox.Show("Podane dane są niepoprawne",
                "Błąd");
            }
            else
            {


                stud.Name = NameTextBox.Text;
                stud.Surname = SurnameTextBox.Text;
                stud.IndexNumber = Convert.ToInt32(IndexNumberTextBox.Text);
                stud.DateOfBirth = DateOfBirthTextBox.Text;
                // stud.Mark = MarkTextBox.Text;
           

                db.Students.Add(stud);

                db.SaveChanges();
                MessageBox.Show("Udało się dodać studenta do bazy!",
                "Informacja");
                this.Close();
            }
        }

        public void Add(int StudID)
        {
            Students stud = db.Students.Find(StudID);
            bool err = CheckValue();
            if (err == true)
            {
                MessageBox.Show("Podane dane są niepoprawne",
                "Błąd");
            }
            else
            {
                stud.Name = NameTextBox.Text;
                stud.Surname = SurnameTextBox.Text;
                stud.IndexNumber = Convert.ToInt32(IndexNumberTextBox.Text);
                stud.DateOfBirth = DateOfBirthTextBox.Text;
                stud.Mark = MarkTextBox.Text;

                db.SaveChanges();
                MessageBox.Show("Edycja przebiegła pomyślnie!",
                "Informacja");
                this.Close();
            }
        }

        private void AddorEdit_Load(object sender, EventArgs e)
        {
            if(this.Text == "Dodaj")
            {
                MarkTextBox.Visible = false;
                label5.Visible = false;
            }
        }
    }
}
