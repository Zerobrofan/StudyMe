
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
            this.scorePanel = new System.Windows.Forms.Panel();
            this.scoreListButton = new System.Windows.Forms.Button();
            this.scoreManageButton = new System.Windows.Forms.Button();
            this.scoreAddButton = new System.Windows.Forms.Button();
            this.scoreButton = new System.Windows.Forms.Button();
            this.coursePanel = new System.Windows.Forms.Panel();
            this.courseListButton = new System.Windows.Forms.Button();
            this.courseManageButton = new System.Windows.Forms.Button();
            this.courseButton = new System.Windows.Forms.Button();
            this.stdPanel = new System.Windows.Forms.Panel();
            this.stdListButton = new System.Windows.Forms.Button();
            this.stdManageButton = new System.Windows.Forms.Button();
            this.stdButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.pleaseLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.scorePanel.SuspendLayout();
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
            this.panel1.Controls.Add(this.scorePanel);
            this.panel1.Controls.Add(this.scoreButton);
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
            // 
            // logOutButton
            // 
            this.logOutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.logOutButton.ForeColor = System.Drawing.SystemColors.Control;
            this.logOutButton.Location = new System.Drawing.Point(0, 636);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.logOutButton.Size = new System.Drawing.Size(193, 47);
            this.logOutButton.TabIndex = 9;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // scorePanel
            // 
            this.scorePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.scorePanel.Controls.Add(this.scoreListButton);
            this.scorePanel.Controls.Add(this.scoreManageButton);
            this.scorePanel.Controls.Add(this.scoreAddButton);
            this.scorePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.scorePanel.Location = new System.Drawing.Point(0, 496);
            this.scorePanel.Name = "scorePanel";
            this.scorePanel.Size = new System.Drawing.Size(193, 140);
            this.scorePanel.TabIndex = 8;
            // 
            // scoreListButton
            // 
            this.scoreListButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.scoreListButton.FlatAppearance.BorderSize = 0;
            this.scoreListButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.scoreListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreListButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.scoreListButton.ForeColor = System.Drawing.SystemColors.Control;
            this.scoreListButton.Location = new System.Drawing.Point(0, 94);
            this.scoreListButton.Name = "scoreListButton";
            this.scoreListButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.scoreListButton.Size = new System.Drawing.Size(193, 47);
            this.scoreListButton.TabIndex = 2;
            this.scoreListButton.Text = "All Scores";
            this.scoreListButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scoreListButton.UseVisualStyleBackColor = true;
            // 
            // scoreManageButton
            // 
            this.scoreManageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.scoreManageButton.FlatAppearance.BorderSize = 0;
            this.scoreManageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.scoreManageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreManageButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.scoreManageButton.ForeColor = System.Drawing.SystemColors.Control;
            this.scoreManageButton.Location = new System.Drawing.Point(0, 47);
            this.scoreManageButton.Name = "scoreManageButton";
            this.scoreManageButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.scoreManageButton.Size = new System.Drawing.Size(193, 47);
            this.scoreManageButton.TabIndex = 1;
            this.scoreManageButton.Text = "Manage Scores";
            this.scoreManageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scoreManageButton.UseVisualStyleBackColor = true;
            // 
            // scoreAddButton
            // 
            this.scoreAddButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.scoreAddButton.FlatAppearance.BorderSize = 0;
            this.scoreAddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.scoreAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreAddButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.scoreAddButton.ForeColor = System.Drawing.SystemColors.Control;
            this.scoreAddButton.Location = new System.Drawing.Point(0, 0);
            this.scoreAddButton.Name = "scoreAddButton";
            this.scoreAddButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.scoreAddButton.Size = new System.Drawing.Size(193, 47);
            this.scoreAddButton.TabIndex = 0;
            this.scoreAddButton.Text = "Add Score";
            this.scoreAddButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scoreAddButton.UseVisualStyleBackColor = true;
            // 
            // scoreButton
            // 
            this.scoreButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.scoreButton.FlatAppearance.BorderSize = 0;
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.scoreButton.ForeColor = System.Drawing.SystemColors.Control;
            this.scoreButton.Location = new System.Drawing.Point(0, 449);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.scoreButton.Size = new System.Drawing.Size(193, 47);
            this.scoreButton.TabIndex = 7;
            this.scoreButton.Text = "Scores";
            this.scoreButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scoreButton.UseVisualStyleBackColor = true;
            this.scoreButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // coursePanel
            // 
            this.coursePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.coursePanel.Controls.Add(this.courseListButton);
            this.coursePanel.Controls.Add(this.courseManageButton);
            this.coursePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.coursePanel.Location = new System.Drawing.Point(0, 356);
            this.coursePanel.Name = "coursePanel";
            this.coursePanel.Size = new System.Drawing.Size(193, 93);
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
            this.courseListButton.Size = new System.Drawing.Size(193, 47);
            this.courseListButton.TabIndex = 2;
            this.courseListButton.Text = "Course List";
            this.courseListButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.courseListButton.UseVisualStyleBackColor = true;
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
            this.courseManageButton.Size = new System.Drawing.Size(193, 47);
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
            this.courseButton.Size = new System.Drawing.Size(193, 47);
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
            this.stdPanel.Size = new System.Drawing.Size(193, 92);
            this.stdPanel.TabIndex = 4;
            // 
            // stdListButton
            // 
            this.stdListButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.stdListButton.FlatAppearance.BorderSize = 0;
            this.stdListButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.stdListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stdListButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.stdListButton.ForeColor = System.Drawing.SystemColors.Control;
            this.stdListButton.Location = new System.Drawing.Point(0, 47);
            this.stdListButton.Name = "stdListButton";
            this.stdListButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.stdListButton.Size = new System.Drawing.Size(193, 47);
            this.stdListButton.TabIndex = 2;
            this.stdListButton.Text = "Student List";
            this.stdListButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stdListButton.UseVisualStyleBackColor = true;
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
            this.stdManageButton.Size = new System.Drawing.Size(193, 47);
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
            this.stdButton.Size = new System.Drawing.Size(193, 47);
            this.stdButton.TabIndex = 3;
            this.stdButton.Text = "Student";
            this.stdButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stdButton.UseVisualStyleBackColor = true;
            this.stdButton.Click += new System.EventHandler(this.stdButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.studyMeLabel);
            this.panel2.Controls.Add(this.adminPortalLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 170);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(54, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Username";
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
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 600);
            this.Controls.Add(this.pleaseLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.minButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProductForm_MouseDown);
            this.panel1.ResumeLayout(false);
            this.scorePanel.ResumeLayout(false);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timeTimer;
        private System.Windows.Forms.Panel scorePanel;
        private System.Windows.Forms.Button scoreListButton;
        private System.Windows.Forms.Button scoreManageButton;
        private System.Windows.Forms.Button scoreAddButton;
        private System.Windows.Forms.Button scoreButton;
        private System.Windows.Forms.Panel coursePanel;
        private System.Windows.Forms.Button courseListButton;
        private System.Windows.Forms.Button courseManageButton;
        private System.Windows.Forms.Button courseButton;
        private System.Windows.Forms.Panel stdPanel;
        private System.Windows.Forms.Button stdListButton;
        private System.Windows.Forms.Button stdManageButton;
        private System.Windows.Forms.Button stdButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label pleaseLabel;
    }
}