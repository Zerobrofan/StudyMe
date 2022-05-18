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

namespace Gamey
{
    public partial class DashboardForm : Form
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
        public DashboardForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            timeTimer.Start();

            stdPanel.Visible = false;
            coursePanel.Visible = false;

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

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void courseManageButton_Click(object sender, EventArgs e)
        {
            welcomeLabel.Text = "";
            pleaseLabel.Text = "";

            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            this.IsMdiContainer = true;
            CourseForm courseForm = new CourseForm();
            courseForm.MdiParent = this;
            courseForm.FormBorderStyle = FormBorderStyle.None;
            courseForm.Dock = DockStyle.Fill;
            courseForm.Show();
        }

        private void stdManageButton_Click(object sender, EventArgs e)
        {
            welcomeLabel.Text = "";
            pleaseLabel.Text = "";

            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            this.IsMdiContainer = true;
            StudentForm studentForm = new StudentForm();
            studentForm.MdiParent = this;
            studentForm.FormBorderStyle = FormBorderStyle.None;
            studentForm.Dock = DockStyle.Fill;
            studentForm.Show();
        }

        private void stdListButton_Click(object sender, EventArgs e)
        {
            welcomeLabel.Text = "";
            pleaseLabel.Text = "";

            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            this.IsMdiContainer = true;
            StudentList studentList = new StudentList();
            studentList.MdiParent = this;
            studentList.FormBorderStyle = FormBorderStyle.None;
            studentList.Dock = DockStyle.Fill;
            studentList.Show();
        }

        private void courseListButton_Click(object sender, EventArgs e)
        {
            welcomeLabel.Text = "";
            pleaseLabel.Text = "";

            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            this.IsMdiContainer = true;
            CourseList courseList = new CourseList();
            courseList.MdiParent = this;
            courseList.FormBorderStyle = FormBorderStyle.None;
            courseList.Dock = DockStyle.Fill;
            courseList.Show();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
