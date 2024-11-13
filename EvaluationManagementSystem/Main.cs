using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Midproject
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void RubricLevel_Click(object sender, EventArgs e)
        {
            Rubric_Level form1 = new Rubric_Level();
            form1.Show();
        }

        private void Students_Click(object sender, EventArgs e)
        {
            Students form1 = new Students();
            form1.Show();
        }

        private void Attendance_Click(object sender, EventArgs e)
        {
            Attendance form1 = new Attendance();
            form1.Show();
        }

        private void Clo_Click(object sender, EventArgs e)
        {
            Clo form1 = new Clo();
            form1.Show();
        }

        private void Rubrics_Click(object sender, EventArgs e)
        {
           Rubrics form1 = new Rubrics();
            form1.Show();
        }

        private void Assesments_Click(object sender, EventArgs e)
        {
            Assesments form1 = new Assesments();
            form1.Show();
        }

        private void AssesmentComponent_Click(object sender, EventArgs e)
        {
            AssesmentComponent form1 = new AssesmentComponent();
            form1.Show();
        }

        private void StudentResults_Click(object sender, EventArgs e)
        {
            StudentResult form1 = new StudentResult();
            form1.Show();
        }

        private void Reports_Click(object sender, EventArgs e)
        {
            Reports form1 = new Reports();
            form1.Show();
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
