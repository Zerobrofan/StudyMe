
namespace Gamey
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timeLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.minButton = new System.Windows.Forms.Button();
            this.studyMeLabel = new System.Windows.Forms.Label();
            this.adminPortalLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOutButton = new System.Windows.Forms.Button();
            this.coursePanel = new System.Windows.Forms.Panel();
            this.courseListButton = new System.Windows.Forms.Button();
            this.courseManageButton = new System.Windows.Forms.Button();
            this.courseButton = new System.Windows.Forms.Button();
            this.stdPanel = new System.Windows.Forms.Panel();
            this.stdListButton = new System.Windows.Forms.Button();
            this.stdManageButton = new System.Windows.Forms.Button();
            this.stdButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.pleaseLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.coursePanel.SuspendLayout();
            this.stdPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.timeLabel.Location = new System.Drawing.Point(1007, 20);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(59, 22);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "22:33";
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(1108, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(30, 30);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // minButton
            // 
            this.minButton.FlatAppearance.BorderSize = 0;
            this.minButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minButton.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.minButton.Location = new System.Drawing.Point(1072, 12);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(30, 30);
            this.minButton.TabIndex = 2;
            this.minButton.Text = "_";
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // studyMeLabel
            // 
            this.studyMeLabel.AutoSize = true;
            this.studyMeLabel.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.studyMeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.studyMeLabel.Location = new System.Drawing.Point(12, 31);
            this.studyMeLabel.Name = "studyMeLabel";
            this.studyMeLabel.Size = new System.Drawing.Size(188, 47);
            this.studyMeLabel.TabIndex = 3;
            this.studyMeLabel.Text = "StudyMe";
            // 
            // adminPortalLabel
            // 
            this.adminPortalLabel.AutoSize = true;
            this.adminPortalLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.adminPortalLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.adminPortalLabel.Location = new System.Drawing.Point(40, 78);
            this.adminPortalLabel.Name = "adminPortalLabel";
            this.adminPortalLabel.Size = new System.Drawing.Size(132, 21);
            this.adminPortalLabel.TabIndex = 4;
            this.adminPortalLabel.Text = "ADMIN PORTAL";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.logOutButton);
            this.panel1.Controls.Add(this.coursePanel);
            this.panel1.Controls.Add(this.courseButton);
            this.panel1.Controls.Add(this.stdPanel);
            this.panel1.Controls.Add(this.stdButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 600);
            this.panel1.TabIndex = 22;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // logOutButton
            // 
            this.logOutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.logOutButton.ForeColor = System.Drawing.SystemColors.Control;
            this.logOutButton.Location = new System.Drawing.Point(0, 553);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.logOutButton.Size = new System.Drawing.Size(210, 47);
            this.logOutButton.TabIndex = 9;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // coursePanel
            // 
            this.coursePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.coursePanel.Controls.Add(this.courseListButton);
            this.coursePanel.Controls.Add(this.courseManageButton);
            this.coursePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.coursePanel.Location = new System.Drawing.Point(0, 356);
            this.coursePanel.Name = "coursePanel";
            this.coursePanel.Size = new System.Drawing.Size(210, 93);
            this.coursePanel.TabIndex = 6;
            // 
            // courseListButton
            // 
            this.courseListButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseListButton.FlatAppearance.BorderSize = 0;
            this.courseListButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.courseListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.courseListButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.courseListButton.ForeColor = System.Drawing.SystemColors.Control;
            this.courseListButton.Location = new System.Drawing.Point(0, 47);
            this.courseListButton.Name = "courseListButton";
            this.courseListButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.courseListButton.Size = new System.Drawing.Size(210, 47);
            this.courseListButton.TabIndex = 2;
            this.courseListButton.Text = "Course List";
            this.courseListButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.courseListButton.UseVisualStyleBackColor = true;
            this.courseListButton.Click += new System.EventHandler(this.courseListButton_Click);
            // 
            // courseManageButton
            // 
            this.courseManageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseManageButton.FlatAppearance.BorderSize = 0;
            this.courseManageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.courseManageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.courseManageButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.courseManageButton.ForeColor = System.Drawing.SystemColors.Control;
            this.courseManageButton.Location = new System.Drawing.Point(0, 0);
            this.courseManageButton.Name = "courseManageButton";
            this.courseManageButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.courseManageButton.Size = new System.Drawing.Size(210, 47);
            this.courseManageButton.TabIndex = 1;
            this.courseManageButton.Text = "Manage Courses";
            this.courseManageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.courseManageButton.UseVisualStyleBackColor = true;
            this.courseManageButton.Click += new System.EventHandler(this.courseManageButton_Click);
            // 
            // courseButton
            // 
            this.courseButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseButton.FlatAppearance.BorderSize = 0;
            this.courseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.courseButton.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.courseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.courseButton.Location = new System.Drawing.Point(0, 309);
            this.courseButton.Name = "courseButton";
            this.courseButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.courseButton.Size = new System.Drawing.Size(210, 47);
            this.courseButton.TabIndex = 5;
            this.courseButton.Text = "Course";
            this.courseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.courseButton.UseVisualStyleBackColor = true;
            this.courseButton.Click += new System.EventHandler(this.courseButton_Click);
            // 
            // stdPanel
            // 
            this.stdPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.stdPanel.Controls.Add(this.stdListButton);
            this.stdPanel.Controls.Add(this.stdManageButton);
            this.stdPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.stdPanel.Location = new System.Drawing.Point(0, 217);
            this.stdPanel.Name = "stdPanel";
            this.stdPanel.Size = new System.Drawing.Size(210, 92);
            this.stdPanel.TabIndex = 4;
            // 
            // stdListButton
            // 
            this.stdListButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stdListButton.FlatAppearance.BorderSize = 0;
            this.stdListButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.stdListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stdListButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.stdListButton.ForeColor = System.Drawing.SystemColors.Control;
            this.stdListButton.Location = new System.Drawing.Point(0, 45);
            this.stdListButton.Name = "stdListButton";
            this.stdListButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.stdListButton.Size = new System.Drawing.Size(210, 47);
            this.stdListButton.TabIndex = 2;
            this.stdListButton.Text = "Student List";
            this.stdListButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stdListButton.UseVisualStyleBackColor = true;
            this.stdListButton.Click += new System.EventHandler(this.stdListButton_Click);
            // 
            // stdManageButton
            // 
            this.stdManageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.stdManageButton.FlatAppearance.BorderSize = 0;
            this.stdManageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.stdManageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stdManageButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.stdManageButton.ForeColor = System.Drawing.SystemColors.Control;
            this.stdManageButton.Location = new System.Drawing.Point(0, 0);
            this.stdManageButton.Name = "stdManageButton";
            this.stdManageButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.stdManageButton.Size = new System.Drawing.Size(210, 47);
            this.stdManageButton.TabIndex = 1;
            this.stdManageButton.Text = "Manage Students";
            this.stdManageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stdManageButton.UseVisualStyleBackColor = true;
            this.stdManageButton.Click += new System.EventHandler(this.stdManageButton_Click);
            // 
            // stdButton
            // 
            this.stdButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.stdButton.FlatAppearance.BorderSize = 0;
            this.stdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stdButton.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.stdButton.ForeColor = System.Drawing.SystemColors.Control;
            this.stdButton.Location = new System.Drawing.Point(0, 170);
            this.stdButton.Name = "stdButton";
            this.stdButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.stdButton.Size = new System.Drawing.Size(210, 47);
            this.stdButton.TabIndex = 3;
            this.stdButton.Text = "Student";
            this.stdButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stdButton.UseVisualStyleBackColor = true;
            this.stdButton.Click += new System.EventHandler(this.stdButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userNameLabel);
            this.panel2.Controls.Add(this.studyMeLabel);
            this.panel2.Controls.Add(this.adminPortalLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 170);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.userNameLabel.Location = new System.Drawing.Point(55, 104);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(103, 23);
            this.userNameLabel.TabIndex = 5;
            this.userNameLabel.Text = "Username";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timeTimer
            // 
            this.timeTimer.Tick += new System.EventHandler(this.timeTimer_Tick);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.welcomeLabel.Location = new System.Drawing.Point(547, 217);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(219, 47);
            this.welcomeLabel.TabIndex = 23;
            this.welcomeLabel.Text = "Welcome!";
            // 
            // pleaseLabel
            // 
            this.pleaseLabel.AutoSize = true;
            this.pleaseLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pleaseLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pleaseLabel.Location = new System.Drawing.Point(412, 276);
            this.pleaseLabel.Name = "pleaseLabel";
            this.pleaseLabel.Size = new System.Drawing.Size(488, 22);
            this.pleaseLabel.TabIndex = 24;
            this.pleaseLabel.Text = "Please select a category from the list to start working";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(210, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(940, 52);
            this.panel3.TabIndex = 25;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 600);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.minButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pleaseLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProductForm_MouseDown);
            this.panel1.ResumeLayout(false);
            this.coursePanel.ResumeLayout(false);
            this.stdPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Label studyMeLabel;
        private System.Windows.Forms.Label adminPortalLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Timer timeTimer;
        private System.Windows.Forms.Panel coursePanel;
        private System.Windows.Forms.Button courseListButton;
        private System.Windows.Forms.Button courseManageButton;
        private System.Windows.Forms.Button courseButton;
        private System.Windows.Forms.Panel stdPanel;
        private System.Windows.Forms.Button stdListButton;
        private System.Windows.Forms.Button stdManageButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label pleaseLabel;
        private System.Windows.Forms.Button stdButton;
        private System.Windows.Forms.Panel panel3;
    }
}