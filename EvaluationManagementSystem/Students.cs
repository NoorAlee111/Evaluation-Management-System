using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Midproject
{
    public partial class Students : Form
    {
        int Id;
        
        public Students()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            loadrecord();
            LoadDataIntoComboBox();
        }
        private void LoadDataIntoComboBox()
        {
            string Category = "STUDENT_STATUS";
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select distinct LookupId from Lookup Where Category=@Category", con);
            cmd.Parameters.AddWithValue("@Category", Category);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Status.DataSource = dt;
            foreach (DataRow dr in dt.Rows)
            {
                Statusc.Items.Add(dr["LookupId"].ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Id != null && FirstNamet.Text != null && LastNamet.Text != null && Contactt.Text != null && Emailt.Text != null && RegistrationNumber.Text != null && Statusc.Text != null)
            {
                if (Contactt.BackColor == Color.Green)
                {
                    if (Regex.IsMatch(Emailt.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$") == true)
                    {
                        var con = Configuration.getInstance().getConnection();
                        
                        SqlCommand cmd = new SqlCommand("UPDATE Student SET FirstName=@FirstName,LastName=@LastName,Contact=@Contact,Email=@Email,RegistrationNumber = @RegistrationNumber,Status=@Status WHERE Id=@Id ", con);
                        cmd.Parameters.AddWithValue("@Id", Id);
                        cmd.Parameters.AddWithValue("@FirstName", FirstNamet.Text);
                        cmd.Parameters.AddWithValue("@LastName", LastNamet.Text);
                        cmd.Parameters.AddWithValue("@Contact", Contactt.Text);
                        cmd.Parameters.AddWithValue("@Email", Emailt.Text);
                        cmd.Parameters.AddWithValue("@RegistrationNumber", RegistrationNumber.Text);
                        cmd.Parameters.AddWithValue("@Status", int.Parse(Statusc.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully updated");
                        loadrecord();
                    }
                    else
                    {
                        MessageBox.Show("Enter Valiid Email Address....");
                    }

                }
                else if (Contactt.BackColor == Color.Red)
                {
                    MessageBox.Show("Invalid Ph no...");
                }
            }
        
            else
            {
                MessageBox.Show("Fill out all text boxes...");
            }
            
           
        }
        
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RegistrationNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)) && (!char.IsDigit(e.KeyChar)) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void FirstNamet_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void LastNamet_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Contactt_KeyPress(object sender, KeyPressEventArgs e)
        {

            Regex r = new Regex(@"^[0-9]{10}$");
            if (r.IsMatch(Contactt.Text))
            {
                Contactt.BackColor = Color.Green;
            }
            else
            {
                Contactt.BackColor = Color.Red;
            }
        }

          private void loadrecord()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Student Where Status = '5' ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Emailt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (Id != null && FirstNamet.Text != null && LastNamet.Text != null && Contactt.Text != null && Emailt.Text != null && RegistrationNumber.Text != null && Statusc.Text != null)
            {
                if (Contactt.BackColor == Color.Green)
                {
                    if (Regex.IsMatch(Emailt.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$") == true)
                    {
                        var con = Configuration.getInstance().getConnection();
                        
                        SqlCommand cmd1 = new SqlCommand("Select RegistrationNumber from Student where RegistrationNumber=@parm1 ", con);
                        cmd1.Parameters.AddWithValue("parm1", RegistrationNumber.Text);
                        SqlDataReader reader1;
                        reader1 = cmd1.ExecuteReader();
                        if(reader1.Read())
                        {
                            MessageBox.Show("Student with this Registrartion number already exists..");
                            con.Close();
                        }
                        else
                        {
                            con.Close();
                            var con1 = Configuration.getInstance().getConnection();
                            con1.Open();
                            SqlCommand cmd = new SqlCommand("Insert into Student values ( @FirstName,@LastName,@Contact,@Email,@RegistrationNumber,@Status)", con1);
                            cmd.Parameters.AddWithValue("@FirstName", FirstNamet.Text);
                            cmd.Parameters.AddWithValue("@LastName", LastNamet.Text);
                            cmd.Parameters.AddWithValue("@Contact", Contactt.Text);
                            cmd.Parameters.AddWithValue("@Email", Emailt.Text);
                            cmd.Parameters.AddWithValue("@RegistrationNumber", RegistrationNumber.Text);
                            cmd.Parameters.AddWithValue("@Status", int.Parse(Statusc.Text));
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Successfully saved");
                            loadrecord();
                        }



                        
                    }
                    else
                    {
                        MessageBox.Show("Enter Valiid Email Address....");
                    }

                }
                else if (Contactt.BackColor == Color.Red)
                {
                    MessageBox.Show("Invalid Ph no...");
                }
            }
            else
            {
                MessageBox.Show("Fill out all text boxes...");
            }
           
           

        }

        private void Show_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Student Where Status = '5' ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                dataGridView1.Rows.Remove(selectedRow);
                MessageBox.Show("Successfully deleted from DataGridView");
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("No row is selected from the DataGridView!");
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow r = dataGridView1.Rows[i];
            Id = int.Parse(r.Cells[0].Value.ToString());
            FirstNamet.Text = r.Cells[1].Value + "";
            LastNamet.Text = r.Cells[2].Value + "";
            Contactt.Text = r.Cells[3].Value + "";
            Emailt.Text = r.Cells[4].Value + "";
            RegistrationNumber.Text = r.Cells[5].Value + "";
            Statusc.Text = r.Cells[6].Value + "";
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (RegistrationNumber.Text != null)
            {
                DataTable dt = new DataTable();
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Select * from Student WHERE RegistrationNumber LIKE '%" + RegistrationNumber.Text  + "%'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Please select the row from table...");
            }

        }
    }
}
