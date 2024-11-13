using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Midproject
{
    public partial class Clo : Form
    {
        public static int Id = 0;

        public Clo()
        {
            InitializeComponent();
        }

        private void reloadUpdatedDatabase()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Clo ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Clo_Load(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (Id != null && CloName.Text != null && DateCreated.Text != null && DateUpdated.Text != null)
            {
                var con1 = Configuration.getInstance().getConnection();
                SqlCommand cmd1 = new SqlCommand("Select Name from Clo where Name=@parm1 ", con1);
                cmd1.Parameters.AddWithValue("parm1",CloName.Text);
                SqlDataReader reader1;
                reader1 = cmd1.ExecuteReader();
                if (reader1.Read())
                {
                    MessageBox.Show("Clo with this Name already exists..");
                    con1.Close();
                }
                else
                {
                    con1.Close();
                    var con = Configuration.getInstance().getConnection();
                    con.Open();
       
                    SqlCommand cmd = new SqlCommand("INSERT INTO Clo (Name, DateCreated, DateUpdated) VALUES (@Name, @DateCreated, @DateUpdated);", con);
                    cmd.Parameters.AddWithValue("@Name", CloName.Text);
                    cmd.Parameters.AddWithValue("@DateCreated", SqlDbType.Date).Value = DateCreated.Value.Date;
                    cmd.Parameters.AddWithValue("@DateUpdated", SqlDbType.Date).Value = DateUpdated.Value.Date;
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

        private void Update_Click(object sender, EventArgs e)
        {
            if (Id != null && CloName.Text != null && DateCreated.Text != null && DateUpdated.Text != null)
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("UPDATE Clo SET Name = @Name, DateUpdated = @DateUpdated WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Name", CloName.Text);
                

                cmd.Parameters.AddWithValue("@DateUpdated", SqlDbType.Date).Value = DateUpdated.Value.Date;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved");
                reloadUpdatedDatabase();
            }
            else
            {
                MessageBox.Show("Make sure that you have filled all text boxes!");
            }
        }

        
        

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow r = dataGridView2.Rows[index];
            Id = int.Parse(r.Cells[0].Value.ToString());
            CloName.Text= r.Cells[1].Value + "";
            DateCreated.Text = r.Cells[2].Value + "";
            DateUpdated.Text = r.Cells[3].Value + "";
        }

        private void Show_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Clo", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void Search_Click(object sender, EventArgs e)
        {
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Search_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Clo WHERE Name LIKE '%" + CloName.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
    }
}
