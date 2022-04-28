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
    public partial class ProductForm : Form
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
        public ProductForm()
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
          string gender =  maleButton.Checked ? "Male" : "Female";
            try
            {
                con.Open();
                string query = "insert into stuTable values ('" + nameBox.Text + "','" + lastNameBox.Text + "','" + gender + "','" + phoneBox.Text + "','" + addressBox.Text + "','"+ dateBox.Text+ "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student added successfully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Pobulate()
        {
            con.Open();
            string query = "select * from stuTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder scd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            studGrid.DataSource = ds.Tables[0];
            con.Close();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            Pobulate();
        }
    }
}
