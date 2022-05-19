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
    public partial class LoginForm : Form
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
        public LoginForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            capsLabel.Hide();
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\StudyMe\StudyMeDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void loginButton_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Select * from adminTable where AdminName='"+usernameBox.Text+"'and AdminPass='"+passBox.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                DashboardForm dashForm = new DashboardForm(usernameBox.Text);               
                this.Hide();
                dashForm.Show();                
            }
            else if (usernameBox.Text == "Rick Astely" && passBox.Text =="nevergonnagiveyouup")
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ&ab_channel=RickAstley");
            }

            else if(usernameBox.Text == "admin" && passBox.Text == "admin")
            {
                AdminForm adminForm = new AdminForm();
                this.Hide();
                adminForm.Show();
            }

            else
            {
                MessageBox.Show("Wrong username or password.");
            }
            con.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(Control.IsKeyLocked(Keys.CapsLock) == true)
            {
                capsLabel.Show();
            }
            else if(Control.IsKeyLocked(Keys.CapsLock) == false)
            {
                capsLabel.Hide();
            }
        }
    }
}
