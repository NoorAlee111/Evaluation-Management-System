using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Midproject
{
    public partial class Rubrics : Form
    {
        public static int Id;
        public Rubrics()
        {
            InitializeComponent();
        }

        private void Rubrics_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBox();
        }

        private void Details_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void reloadUpdatedDatabase()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Rubric", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (Id != null && Details.Text != null && CloID.Text != null)
            {
                var con1 = Configuration.getInstance().getConnection();
                SqlCommand cmd1 = new SqlCommand("Select Id from Rubric where Id=@parm1 ", con1);
                cmd1.Parameters.AddWithValue("parm1", int.Parse(txtId.Text));
                SqlDataReader reader1;

                reader1 = cmd1.ExecuteReader();
                if (reader1.Read())
                {
                    MessageBox.Show("Rubric with this Id already exists..");
                    con1.Close();
                }
                else
                {
                    con1.Close();
                    var con = Configuration.getInstance().getConnection();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Rubric (Id, Details, CloId) VALUES (@Id, @Details, @CloId);", con);
                    cmd.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));
                    cmd.Parameters.AddWithValue("@Details", Details.Text);
                    cmd.Parameters.AddWithValue("@CloId", int.Parse(CloID.Text));
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
            DataTable dt = new DataTable();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Rubric WHERE Id LIKE '%" + txtId.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView3.DataSource = dt;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (Id != null && Details.Text != null && CloID.Text != null)
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("UPDATE Rubric SET Details = @Details, CloId = @CloId WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));
                cmd.Parameters.AddWithValue("@Details", Details.Text);
                cmd.Parameters.AddWithValue("@CloId", int.Parse(CloID.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved");
                reloadUpdatedDatabase();
            }
            else
            {
                MessageBox.Show("Make sure that you have filled all text boxes!");
            }
        }
        private void LoadDataIntoComboBox()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Id from Clo", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow r in dt.Rows)
            {
                CloID.Items.Add(r["Id"].ToString());
            }
        }
        private void Show_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Rubric", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow r = dataGridView3.Rows[index];
            Id = int.Parse(r.Cells[0].Value.ToString());
            Details.Text = r.Cells[1].Value + "";
            CloID.Text = r.Cells[2].Value + "";
        }
    }
}
