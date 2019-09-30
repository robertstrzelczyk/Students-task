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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentsDatabaseDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.studentsDatabaseDataSet.Students);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddorEdit Add = new AddorEdit();
            //Add.FormClosing += new FormClosingEventHandler(this.AddorEdit_FormClosing);
            Add.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            AddorEdit Edit = new AddorEdit();
            Edit.Show();
        }
    }
}
