
namespace Gamey
{
    partial class StudentForm
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
            this.clearButton = new System.Windows.Forms.Button();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.femaleButton = new System.Windows.Forms.RadioButton();
            this.maleButton = new System.Windows.Forms.RadioButton();
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.clearButton.Location = new System.Drawing.Point(429, 537);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(117, 39);
            this.clearButton.TabIndex = 54;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addressBox
            // 
            this.addressBox.Font = new System.Drawing.Font("Arial", 10F);
            this.addressBox.Location = new System.Drawing.Point(114, 482);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(625, 23);
            this.addressBox.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(25, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 22);
            this.label7.TabIndex = 52;
            this.label7.Text = "Address:";
            // 
            // phoneBox
            // 
            this.phoneBox.Font = new System.Drawing.Font("Arial", 10F);
            this.phoneBox.Location = new System.Drawing.Point(346, 443);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(258, 23);
            this.phoneBox.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(269, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 22);
            this.label6.TabIndex = 50;
            this.label6.Text = "Phone:";
            // 
            // femaleButton
            // 
            this.femaleButton.AutoSize = true;
            this.femaleButton.Font = new System.Drawing.Font("Arial", 9.75F);
            this.femaleButton.Location = new System.Drawing.Point(174, 446);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(69, 20);
            this.femaleButton.TabIndex = 49;
            this.femaleButton.TabStop = true;
            this.femaleButton.Text = "Female";
            this.femaleButton.UseVisualStyleBackColor = true;
            // 
            // maleButton
            // 
            this.maleButton.AutoSize = true;
            this.maleButton.Font = new System.Drawing.Font("Arial", 9.75F);
            this.maleButton.Location = new System.Drawing.Point(114, 446);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(54, 20);
            this.maleButton.TabIndex = 48;
            this.maleButton.TabStop = true;
            this.maleButton.Text = "Male";
            this.maleButton.UseVisualStyleBackColor = true;
            // 
            // dateBox
            // 
            this.dateBox.CustomFormat = "yyyy-MM-dd";
            this.dateBox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.dateBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBox.Location = new System.Drawing.Point(581, 402);
            this.dateBox.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(237, 22);
            this.dateBox.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(25, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 46;
            this.label5.Text = "Gender:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(455, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 45;
            this.label1.Text = "Date of Birth:";
            // 
            // studGrid
            // 
            this.studGrid.AllowUserToAddRows = false;
            this.studGrid.AllowUserToDeleteRows = false;
            this.studGrid.AllowUserToResizeColumns = false;
            this.studGrid.AllowUserToResizeRows = false;
            this.studGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studGrid.Location = new System.Drawing.Point(12, 129);
            this.studGrid.Name = "studGrid";
            this.studGrid.ReadOnly = true;
            this.studGrid.Size = new System.Drawing.Size(913, 249);
            this.studGrid.TabIndex = 44;
            this.studGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studGrid_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(228, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 39;
            this.label3.Text = "Search";
            // 
            // editButton
            // 
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.editButton.Location = new System.Drawing.Point(675, 537);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(117, 39);
            this.editButton.TabIndex = 43;
            this.editButton.Text = "EDIT";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.searchBox.Location = new System.Drawing.Point(232, 86);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(437, 22);
            this.searchBox.TabIndex = 42;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.deleteButton.Location = new System.Drawing.Point(798, 537);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(117, 39);
            this.deleteButton.TabIndex = 41;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.addButton.Location = new System.Drawing.Point(552, 537);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(117, 39);
            this.addButton.TabIndex = 38;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(100, 402);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(336, 22);
            this.nameBox.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(25, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 37;
            this.label2.Text = "Name:";
            // 
            // ActualStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 600);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.femaleButton);
            this.Controls.Add(this.maleButton);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ActualStudentForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ActualStudentForm";
            this.Load += new System.EventHandler(this.ActualStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton femaleButton;
        private System.Windows.Forms.RadioButton maleButton;
        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView studGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
    }
}