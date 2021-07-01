﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp.Inheritance
{
    public partial class frmTeacher : Form
    {
        public frmTeacher()
        {
            InitializeComponent();
        }

        private void frmTeacher_Load(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.Name = "Pepe";
            teacher.Surname = "Soto";
            teacher.Subject = "Programación";
            teacher.Salary = 40000.00f;

            MessageBox.Show("El nombre del profesor es: " + teacher.Name +
                "\nEl salario del profesor es: " + teacher.Salary);

            //polymorphism example with boxing
            Person person1 = new Teacher();
            person1.Name = "Neus";
            person1.Surname = "Membrado";

            //unboxing
            ((Teacher)person1).Salary = 50000.00f;
            ((Teacher)person1).Subject = "Mates";

            MessageBox.Show("El nombre del profesor es: " + person1.Name +
                "\nEl salario del profesor es: " + ((Teacher) person1).Salary);

        }
    }
}
