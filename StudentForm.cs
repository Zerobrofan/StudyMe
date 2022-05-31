using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gamey
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();           
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\StudyMe\StudyMeDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from stuTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            BindingSource bs = new BindingSource();
            sda.Fill(ds);
            bs.DataSource = ds.Tables[0];
            studGrid.DataSource = bs;
            con.Close();

            //Actual search
            bs.Filter = "Name LIKE '" + searchBox.Text + "%'";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameBox.Clear();
            maleButton.Checked = true;
            femaleButton.Checked = false;
            dateBox.ResetText();
            phoneBox.Clear();
            addressBox.Clear();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Check if male or female
            string gender = maleButton.Checked ? "Male" : "Female";
            try
            {
                con.Open();
                if (String.IsNullOrEmpty(nameBox.Text) || String.IsNullOrEmpty(phoneBox.Text) || String.IsNullOrEmpty(addressBox.Text))
                {
                    MessageBox.Show("Missing fields were found. Please make sure all fields are filled");
                }
                else
                {
                    string query = "insert into stuTable values ('" + nameBox.Text + "','" + gender + "','" + phoneBox.Text + "','" + addressBox.Text + "','" + dateBox.Text + "','" + courseBox.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student added successfully");

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Pobulate();

            nameBox.Clear();
            maleButton.Checked = true;
            femaleButton.Checked = false;
            dateBox.ResetText();
            phoneBox.Clear();
            addressBox.Clear();
        }

        private void Pobulate()
        {
            con.Open();
            string query = "select * from stuTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            BindingSource bs = new BindingSource();
            sda.Fill(ds);
            bs.DataSource = ds.Tables[0];
            studGrid.DataSource = bs;
            con.Close();
        }

        private void ActualStudentForm_Load(object sender, EventArgs e)
        {
            Pobulate();

            con.Open();
            string query = "select * from courseTable";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();

            courseBox.DataSource = ds.Tables[0];
            courseBox.DisplayMember = "CourseName";
            maleButton.Checked = true;

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //Check if male or female
            string gender = maleButton.Checked ? "Male" : "Female";
            try
            {
                if (String.IsNullOrEmpty(nameBox.Text) || String.IsNullOrEmpty(phoneBox.Text) || String.IsNullOrEmpty(addressBox.Text))
                {
                    MessageBox.Show("Missing fields were found. Please make sure all fields are filled");
                }
                else
                {
                    con.Open();                   
                    string query = "update stuTable set Name=@name,Gender=@gender,Phone=@phone,Address=@address,DateOfBirth=@dateofbirth,Course=@course where Name=@name";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", nameBox.Text);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@phone", phoneBox.Text);
                    cmd.Parameters.AddWithValue("@address", addressBox.Text);
                    cmd.Parameters.AddWithValue("@dateofbirth", dateBox.Text);
                    cmd.Parameters.AddWithValue("@course", courseBox.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student updated successfully");
                    con.Close();
                    Pobulate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameBox.Text == "")
                {
                    MessageBox.Show("Please select a student to delete");
                }
                else
                {

                    con.Open();
                    string query = "DELETE FROM stuTable WHERE Name LIKE '" + nameBox.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student deleted successfully");
                    con.Close();
                    Pobulate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void studGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow stuRow = studGrid.Rows[e.RowIndex];
                nameBox.Text = stuRow.Cells[0].Value.ToString();
                if (stuRow.Cells[1].Value.ToString() == "Male")
                {
                    maleButton.Checked = true;
                }
                else { femaleButton.Checked = true; }
                phoneBox.Text = stuRow.Cells[2].Value.ToString();
                addressBox.Text = stuRow.Cells[3].Value.ToString();
                dateBox.Text = stuRow.Cells[4].Value.ToString();
                courseBox.Text = stuRow.Cells[5].Value.ToString();
            }
        }
    }
}
