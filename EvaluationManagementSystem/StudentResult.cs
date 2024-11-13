using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Midproject
{
    public partial class StudentResult : Form
    {
        public List<string> list = new List<string>();
        public StudentResult()
        {
            InitializeComponent();
        }

        private void StudentResult_Load(object sender, EventArgs e)
        {
            LoadDataIntoStudentIDComboBox();
            LoadDataIntoAssessmnetIDComboBox();
            LoadDataIntoRubricMeasurementIDComboBox();
        }
        private void LoadDataIntoStudentIDComboBox()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Id from Student Where Status = '5'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow r in dt.Rows)
            {
               StudentID.Items.Add(r["Id"].ToString());
            }
        }

        private void LoadDataIntoAssessmnetIDComboBox()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Id from Assessment", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                AssesmentIdl.Items.Add(row["Id"].ToString());
                list.Add(row["Id"].ToString());

            }
        }

        private void LoadDataIntoRubricMeasurementIDComboBox()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select MeasurementLevel from RubricLevel", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow r in dt.Rows)
            {
                RubricMeasurmentId.Items.Add(r["MeasurementLevel"].ToString());
            }
        }

        private void AssesmentIdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (AssesmentIdl.Text == list[i].ToString())
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("Select * from AssessmentComponent where AssessmentId = " + AssesmentIdl.Text + "", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    AssesmentComponentID.Items.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        AssesmentComponentID.Items.Add(row["Id"].ToString());
                    }
                }
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO StudentResult( StudentId,AssessmentComponentId, RubricMeasurementId, EvaluationDate) VALUES ( @StudentId, @AssessmentComponentId, @RubricMeasurementId, @EvaluationDate)", con);
            cmd.Parameters.AddWithValue("@StudentId", int.Parse(StudentID.Text));
            cmd.Parameters.AddWithValue("@AssessmentComponentId", int.Parse(AssesmentComponentID.Text));
            cmd.Parameters.AddWithValue("@RubricMeasurementId", int.Parse(RubricMeasurmentId.Text));
            cmd.Parameters.AddWithValue("@EvaluationDate", SqlDbType.Date).Value = EvaluationDate.Value.Date;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Saved");
        }

        private void Update_Click(object sender, EventArgs e)
        {

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE StudentResult SET StudentId = @StudentId, AssessmentComponentId = @AssessmentComponentId, RubricMeasurementId = @RubricMeasurementId, EvaluationDate = @EvaluationDate", con);
            cmd.Parameters.AddWithValue("@StudentId", int.Parse(StudentID.Text));
            //cmd.Parameters.AddWithValue("@StudentId", int.Parse(comboBoxAssessmentId.Text));
            cmd.Parameters.AddWithValue("@AssessmentComponentId", int.Parse(AssesmentComponentID.Text));
            cmd.Parameters.AddWithValue("@RubricMeasurementId", int.Parse(RubricMeasurmentId.Text));
            cmd.Parameters.AddWithValue("@EvaluationDate", SqlDbType.Date).Value =EvaluationDate.Value.Date;

             cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Saved");
        }

        private void Show_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from StudentResult", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow r = dataGridView2.Rows[index];
            StudentID.Text = r.Cells[0].Value + "";
            AssesmentComponentID.Text = r.Cells[1].Value + "";
            RubricMeasurmentId.Text = r.Cells[2].Value + "";
            EvaluationDate.Text = r.Cells[3].Value + "";
        }
    }
}
