using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Midproject
{
    public partial class Rubric_Level : Form
    {
        public static int Id;
        public Rubric_Level()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Details_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void MeasurmentLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void reloadUpdatedDatabase()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from RubricLevel", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void LoadDataIntoComboBox()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Id from Rubric", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow r in dt.Rows)
            {
                RubricID.Items.Add(r["Id"].ToString());
            }
        }
        private void Insert_Click(object sender, EventArgs e)
        {
            if (Id != null && RubricID.Text != null && Details.Text != null && MeasurmentLevel.Text != null)
            {

                var con1 = Configuration.getInstance().getConnection();
                SqlCommand cmd1 = new SqlCommand("Select Details from Rubric where Details=@parm1 ", con1);
                cmd1.Parameters.AddWithValue("parm1", Details.Text);
                SqlDataReader reader1;
                reader1 = cmd1.ExecuteReader();
                if (reader1.Read())
                {
                    MessageBox.Show("Rubric Level with this detail already exists..");
                    con1.Close();
                }
                else
                {
                    con1.Close();
                    var con = Configuration.getInstance().getConnection();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO RubricLevel (RubricId, Details, MeasurementLevel) VALUES (@RubricId, @Details, @MeasurementLevel);", con);
                    cmd.Parameters.AddWithValue("@RubricId", int.Parse(RubricID.Text));
                    cmd.Parameters.AddWithValue("@Details", Details.Text);
                    cmd.Parameters.AddWithValue("@MeasurementLevel", int.Parse(MeasurmentLevel.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully saved");
                    reloadUpdatedDatabase();
                }
               
               
            }
            else
            {
                MessageBox.Show("Make sure that you have filled all text boxes!");
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if(Details.Text!=null)
            {
                DataTable dt = new DataTable();
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Select * from RubricLevel WHERE Details LIKE '%" + Details.Text + "%'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Please Select Rubric Id...");
            }
           
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (Id != null && RubricID.Text != null && Details.Text != null && MeasurmentLevel.Text != null)
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("UPDATE RubricLevel SET RubricId = @RubricId, Details = @Details, MeasurementLevel = @MeasurementLevel WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@RubricId", int.Parse(RubricID.Text));
                cmd.Parameters.AddWithValue("@Details", Details.Text);
                cmd.Parameters.AddWithValue("@MeasurementLevel", int.Parse(MeasurmentLevel.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved");
                reloadUpdatedDatabase();
            }
            else
            {
                MessageBox.Show("Make sure that you have filled all text boxes!");
            }
        }

        private void Show_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from RubricLevel", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow r = dataGridView2.Rows[index];
            Id = int.Parse(r.Cells[0].Value.ToString());
            
            RubricID.Text = r.Cells[1].Value + "";
            Details.Text = r.Cells[2].Value + "";
            MeasurmentLevel.Text = int.Parse(r.Cells[3].Value.ToString()) + "";
        }

        private void Rubric_Level_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBox();
        }
    }
}
