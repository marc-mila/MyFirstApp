using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp.ForeachLoop
{
    public partial class frmForEach : Form
    {
        public frmForEach()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.StudentId = Convert.ToInt32(txtStudentId.Text);
            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;
            student.Age = Convert.ToInt32(txtAge.Text);

            var studentList = new ArrayList(); //recommended
            //boxing-polymorphism
            studentList.Add(student);

            foreach (Student _student in studentList)
            {
                //unboxing-polymorphism
                
                 MessageBox.Show(_student.Name + " " + _student.Surname);
                
            }

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
