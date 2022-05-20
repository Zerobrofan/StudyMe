
namespace Gamey
{
    partial class AdminForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOutButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.studyMeLabel = new System.Windows.Forms.Label();
            this.adminPortalLabel = new System.Windows.Forms.Label();
            this.adminGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.minButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.logOutButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 542);
            this.panel1.TabIndex = 23;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // logOutButton
            // 
            this.logOutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.logOutButton.ForeColor = System.Drawing.SystemColors.Control;
            this.logOutButton.Location = new System.Drawing.Point(0, 495);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.logOutButton.Size = new System.Drawing.Size(210, 47);
            this.logOutButton.TabIndex = 9;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
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
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.userNameLabel.Location = new System.Drawing.Point(68, 108);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(70, 23);
            this.userNameLabel.TabIndex = 5;
            this.userNameLabel.Text = "admin";
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
            // adminGrid
            // 
            this.adminGrid.AllowUserToAddRows = false;
            this.adminGrid.AllowUserToDeleteRows = false;
            this.adminGrid.AllowUserToResizeColumns = false;
            this.adminGrid.AllowUserToResizeRows = false;
            this.adminGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adminGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adminGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminGrid.Location = new System.Drawing.Point(225, 126);
            this.adminGrid.Name = "adminGrid";
            this.adminGrid.ReadOnly = true;
            this.adminGrid.Size = new System.Drawing.Size(913, 249);
            this.adminGrid.TabIndex = 45;
            this.adminGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminGrid_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(473, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 46;
            this.label3.Text = "Search";
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.searchBox.Location = new System.Drawing.Point(477, 79);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(437, 22);
            this.searchBox.TabIndex = 47;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // clearButton
            // 
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.clearButton.Location = new System.Drawing.Point(642, 485);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(117, 39);
            this.clearButton.TabIndex = 58;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // editButton
            // 
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.editButton.Location = new System.Drawing.Point(888, 485);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(117, 39);
            this.editButton.TabIndex = 57;
            this.editButton.Text = "EDIT";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.deleteButton.Location = new System.Drawing.Point(1011, 485);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(117, 39);
            this.deleteButton.TabIndex = 56;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.addButton.Location = new System.Drawing.Point(765, 485);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(117, 39);
            this.addButton.TabIndex = 55;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(356, 398);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(292, 22);
            this.nameBox.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(245, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 59;
            this.label2.Text = "Username:";
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBox.Location = new System.Drawing.Point(766, 398);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(336, 22);
            this.passBox.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(663, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 61;
            this.label1.Text = "Password:";
            // 
            // timeTimer
            // 
            this.timeTimer.Enabled = true;
            this.timeTimer.Interval = 1000;
            this.timeTimer.Tick += new System.EventHandler(this.timeTimer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.timeLabel.Location = new System.Drawing.Point(1007, 20);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(59, 22);
            this.timeLabel.TabIndex = 63;
            this.timeLabel.Text = "22:33";
            // 
            // minButton
            // 
            this.minButton.FlatAppearance.BorderSize = 0;
            this.minButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minButton.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.minButton.Location = new System.Drawing.Point(1072, 12);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(30, 30);
            this.minButton.TabIndex = 65;
            this.minButton.Text = "_";
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(1108, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(30, 30);
            this.exitButton.TabIndex = 64;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 542);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.minButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.adminGrid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label studyMeLabel;
        private System.Windows.Forms.Label adminPortalLabel;
        private System.Windows.Forms.DataGridView adminGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timeTimer;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Button exitButton;
    }
}