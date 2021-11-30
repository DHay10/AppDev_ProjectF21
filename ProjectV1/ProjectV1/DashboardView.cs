﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectV1
{
    public partial class DashboardView : Form
    {
        public DashboardView()
        {
            InitializeComponent();
        }

        private void addNewStudentButton_Click(object sender, EventArgs e)
        {
            NewStudentView newStudent = new NewStudentView();
            newStudent.ShowDialog();
        }

        private void searchStudentButton_Click(object sender, EventArgs e)
        {
            StudentFileView viewFile = new StudentFileView();
            viewFile.ShowDialog();
        }
    }


}
