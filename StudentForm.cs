using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gamey
{
    public partial class StudentForm : Form
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
        public StudentForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            timeTimer.Start();

            stdPanel.Visible = false;
            coursePanel.Visible = false;
            scorePanel.Visible = false;
        }
        


        private void HidePanel()
        {
            if (stdPanel.Visible == true)
            {
                stdPanel.Visible = false;
            }
            if (coursePanel.Visible == true)
            {
                coursePanel.Visible = false;
            }
            if (scorePanel.Visible == true)
            {
                scorePanel.Visible = false;
            }
        }
        private void ShowPanel(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ProductForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm");          
        }

        private void stdButton_Click(object sender, EventArgs e)
        {
            HidePanel();
            ShowPanel(stdPanel);
        }

        private void courseButton_Click(object sender, EventArgs e)
        {
            HidePanel();
            ShowPanel(coursePanel);
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            HidePanel();
            ShowPanel(scorePanel);
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\abdal\source\repos\Gamey\GameStoreDataBase.mdf;Integrated Security=True;Connect Timeout=30");
        private void addButton_Click(object sender, EventArgs e)
        {
            //Check if male or female
          string gender =  maleButton.Checked ? "Male" : "Female";
            try
            {
                con.Open();
                if (String.IsNullOrEmpty(nameBox.Text) || String.IsNullOrEmpty(phoneBox.Text) || String.IsNullOrEmpty(addressBox.Text))
                {
                    MessageBox.Show("Missing fields were found. Please make sure all fields are filled");
                }
                else
                {
                    string query = "insert into stuTable values ('" + nameBox.Text + "','" + gender + "','" + phoneBox.Text + "','" + addressBox.Text + "','" + dateBox.Text + "')";
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
        }

        private void Pobulate()
        {
            con.Open();
            string query = "select * from stuTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder scd = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            BindingSource bs = new BindingSource();
            sda.Fill(ds);
            bs.DataSource = ds.Tables[0];           
            studGrid.DataSource = bs;
            con.Close();            
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            Pobulate();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from stuTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder scd = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            BindingSource bs = new BindingSource();
            sda.Fill(ds);
            bs.DataSource = ds.Tables[0];
            studGrid.DataSource = bs;
            con.Close();

            //Actual search
            bs.Filter = "Name LIKE '" + searchBox.Text + "%'";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                if(nameBox.Text == "")
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
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void studGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow stuRow = studGrid.Rows[e.RowIndex];
                nameBox.Text = stuRow.Cells[0].Value.ToString();               
                if(stuRow.Cells[1].Value.ToString() == "Male")
                {
                    maleButton.Checked = true;
                }
                else { femaleButton.Checked = true; }
                phoneBox.Text = stuRow.Cells[2].Value.ToString();
                addressBox.Text = stuRow.Cells[3].Value.ToString();
                dateBox.Text = stuRow.Cells[4].Value.ToString();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            /*try
            {
                    con.Open();
                    string query = "update stuTable set Name='" + nameBox.Text + "',Gender";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student deleted successfully");
                    con.Close();
                    Pobulate();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
    }
}
