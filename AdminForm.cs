using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gamey
{
    public partial class AdminForm : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\StudyMe\StudyMeDB.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            timeTimer.Start();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            Pobulate();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameBox.Text = "";
            passBox.Text = "";
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from adminTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder scd = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            BindingSource bs = new BindingSource();
            sda.Fill(ds);
            bs.DataSource = ds.Tables[0];
            adminGrid.DataSource = bs;
            con.Close();

            //Actual search
            bs.Filter = "AdminName LIKE '" + searchBox.Text + "%'";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (String.IsNullOrEmpty(nameBox.Text) || String.IsNullOrEmpty(passBox.Text))
                {
                    MessageBox.Show("Missing fields were found. Please make sure all fields are filled");
                }
                else
                {
                    string query = "insert into adminTable values('" + nameBox.Text + "','" + passBox.Text +  "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin added successfully");

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
            string query = "select * from adminTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder scd = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            BindingSource bs = new BindingSource();
            sda.Fill(ds);
            bs.DataSource = ds.Tables[0];
            adminGrid.DataSource = bs;
            con.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(nameBox.Text) || String.IsNullOrEmpty(passBox.Text))
                {
                    MessageBox.Show("Missing fields were found. Please make sure all fields are filled");
                }
                else
                {
                    con.Open();
                    string query = "update adminTable set AdminName=@name,AdminPass=@pass where AdminName=@name";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", nameBox.Text);
                    cmd.Parameters.AddWithValue("@pass", passBox.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin updated successfully");
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
                    MessageBox.Show("Please select a admin to delete");
                }
                else
                {

                    con.Open();
                    string query = "DELETE FROM adminTable WHERE AdminName LIKE '" + nameBox.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin deleted successfully");
                    con.Close();
                    Pobulate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void adminGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow adminRow = adminGrid.Rows[e.RowIndex];
                nameBox.Text = adminRow.Cells[0].Value.ToString();
                passBox.Text = adminRow.Cells[1].Value.ToString();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
