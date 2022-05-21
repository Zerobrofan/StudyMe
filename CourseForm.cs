using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gamey
{
    public partial class CourseForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\StudyMe\StudyMeDB.mdf;Integrated Security=True;Connect Timeout=30");

        public CourseForm()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            courseNameBox.Clear();
            creditHourBox.Clear();
            courseDescBox.Clear();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (String.IsNullOrEmpty(courseNameBox.Text) || String.IsNullOrEmpty(courseDescBox.Text) || String.IsNullOrEmpty(creditHourBox.Text))
                {
                    MessageBox.Show("Missing fields were found. Please make sure all fields are filled");
                }
                else
                {
                    string query = "insert into courseTable values ('" + courseNameBox.Text + "','" + creditHourBox.Text + "','" + courseDescBox.Text + "','" +dateBoxStart.Text + "','" + dateBoxEnd.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Course added successfully");
                    courseNameBox.Clear();
                    creditHourBox.Clear();
                    courseDescBox.Clear();

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Pobulate();
        }

        private void Pobulate()
        {
            con.Open();
            string query = "select * from courseTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder scd = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            BindingSource bs = new BindingSource();
            sda.Fill(ds);
            bs.DataSource = ds.Tables[0];
            courseGrid.DataSource = bs;
            con.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(courseNameBox.Text) || String.IsNullOrEmpty(creditHourBox.Text) || String.IsNullOrEmpty(courseDescBox.Text))
                {
                    MessageBox.Show("Missing fields were found. Please make sure all fields are filled");
                }
                else
                {
                    con.Open();
                    string query = "update courseTable set CourseName=@name,CreditHours=@credit,CourseDesc=@desc,StartingDate=@start,EndingDate=@end where CourseName=@name";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", courseNameBox.Text);
                    cmd.Parameters.AddWithValue("@credit", creditHourBox.Text);
                    cmd.Parameters.AddWithValue("@desc", courseDescBox.Text);
                    cmd.Parameters.AddWithValue("@start", dateBoxStart.Text);
                    cmd.Parameters.AddWithValue("@end", dateBoxEnd.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Course updated successfully");
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
                if (courseNameBox.Text == "")
                {
                    MessageBox.Show("Please select a course to delete");
                }
                else
                {

                    con.Open();
                    string query = "DELETE FROM courseTable WHERE CourseName LIKE '" + courseNameBox.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Course deleted successfully");
                    con.Close();
                    Pobulate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            Pobulate();
        }

        private void courseGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow courseRow = courseGrid.Rows[e.RowIndex];
                courseNameBox.Text = courseRow.Cells[0].Value.ToString();
                creditHourBox.Text = courseRow.Cells[1].Value.ToString();
                courseDescBox.Text = courseRow.Cells[2].Value.ToString();
                dateBoxStart.Text = courseRow.Cells[3].Value.ToString();
                dateBoxEnd.Text = courseRow.Cells[4].Value.ToString();
            }
        }

        private void courseSearchBox_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from courseTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder scd = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            BindingSource bs = new BindingSource();
            sda.Fill(ds);
            bs.DataSource = ds.Tables[0];
            courseGrid.DataSource = bs;
            con.Close();

            //Actual search
            bs.Filter = "CourseName LIKE '" + courseSearchBox.Text + "%'";
        }
    }
}
