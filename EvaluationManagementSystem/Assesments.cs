using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Midproject
{
    public partial class Assesments : Form
    {
        public static int Id;
        public Assesments()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Title_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TotalMarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TotalWeightage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void DateCreated_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (Id != null && Title.Text != null && DateCreated.Text != null && TotalMarks.Text != null && TotalWeightage.Text != null)
            {
                var con1 = Configuration.getInstance().getConnection();
                SqlCommand cmd1 = new SqlCommand("Select Title from Assessment where Title=@parm1 ", con1);
                cmd1.Parameters.AddWithValue("parm1", Title.Text);
                SqlDataReader reader1;

                reader1 = cmd1.ExecuteReader();
                if (reader1.Read())
                {
                    MessageBox.Show("Assesment with this Title  already exists..");
                    con1.Close();
                }
                else
                {
                    con1.Close();
                    var con = Configuration.getInstance().getConnection();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Assessment (Title, DateCreated, TotalMarks, TotalWeightage) VALUES (@Title, @DateCreated, @TotalMarks, @TotalWeightage);", con);
                    cmd.Parameters.AddWithValue("@Title", Title.Text);
                    cmd.Parameters.AddWithValue("@DateCreated", SqlDbType.Date).Value = DateCreated.Value.Date;
                    cmd.Parameters.AddWithValue("@TotalMarks", TotalMarks.Text);
                    cmd.Parameters.AddWithValue("@TotalWeightage", TotalWeightage.Text);
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

        private void Deleteb_Click(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Assessment WHERE Title LIKE '%" + Title.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (Id != null && Title.Text != null && DateCreated.Text != null && TotalMarks.Text != null && TotalWeightage.Text != null)
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("UPDATE  Assessment SET Title = @Title, DateCreated = @DateCreated, TotalMarks = @TotalMarks, TotalWeightage = @TotalWeightage Where Id = @Id;", con);
                cmd.Parameters.AddWithValue("@Title", Title.Text);
                cmd.Parameters.AddWithValue("@DateCreated", SqlDbType.Date).Value = DateCreated.Value.Date;
                cmd.Parameters.AddWithValue("@TotalMarks", TotalMarks.Text);
                cmd.Parameters.AddWithValue("@TotalWeightage", TotalWeightage.Text);
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
            SqlCommand cmd = new SqlCommand("Select * from Assessment", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void reloadUpdatedDatabase()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Assessment", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void Assesments_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow r = dataGridView2.Rows[index];
            Id = int.Parse(r.Cells[0].Value.ToString());
            Title.Text = r.Cells[1].Value + "";
            DateCreated.Text = r.Cells[4].Value + "";
            TotalMarks.Text = r.Cells[3].Value + "";
            TotalWeightage.Text = r.Cells[5].Value + "";
        }
    }
}
