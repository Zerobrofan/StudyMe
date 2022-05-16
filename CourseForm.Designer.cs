
namespace Gamey
{
    partial class CourseForm
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
            this.courseNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.courseGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.courseSearchBox = new System.Windows.Forms.TextBox();
            this.creditHourBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.courseDescBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // courseNameBox
            // 
            this.courseNameBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameBox.Location = new System.Drawing.Point(173, 403);
            this.courseNameBox.Name = "courseNameBox";
            this.courseNameBox.Size = new System.Drawing.Size(336, 22);
            this.courseNameBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(30, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Course Name:";
            // 
            // courseGrid
            // 
            this.courseGrid.AllowUserToAddRows = false;
            this.courseGrid.AllowUserToDeleteRows = false;
            this.courseGrid.AllowUserToResizeColumns = false;
            this.courseGrid.AllowUserToResizeRows = false;
            this.courseGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.courseGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.courseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseGrid.Location = new System.Drawing.Point(12, 125);
            this.courseGrid.Name = "courseGrid";
            this.courseGrid.ReadOnly = true;
            this.courseGrid.Size = new System.Drawing.Size(916, 249);
            this.courseGrid.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(244, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Search";
            // 
            // courseSearchBox
            // 
            this.courseSearchBox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.courseSearchBox.Location = new System.Drawing.Point(248, 88);
            this.courseSearchBox.Name = "courseSearchBox";
            this.courseSearchBox.Size = new System.Drawing.Size(437, 22);
            this.courseSearchBox.TabIndex = 24;
            // 
            // creditHourBox
            // 
            this.creditHourBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditHourBox.Location = new System.Drawing.Point(659, 403);
            this.creditHourBox.Name = "creditHourBox";
            this.creditHourBox.Size = new System.Drawing.Size(122, 22);
            this.creditHourBox.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(531, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "Credit Hours:";
            // 
            // courseDescBox
            // 
            this.courseDescBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseDescBox.Location = new System.Drawing.Point(218, 449);
            this.courseDescBox.Name = "courseDescBox";
            this.courseDescBox.Size = new System.Drawing.Size(336, 22);
            this.courseDescBox.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(30, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 22);
            this.label4.TabIndex = 30;
            this.label4.Text = "Course Description:";
            // 
            // clearButton
            // 
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.clearButton.Location = new System.Drawing.Point(423, 509);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(117, 39);
            this.clearButton.TabIndex = 37;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // editButton
            // 
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.editButton.Location = new System.Drawing.Point(669, 509);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(117, 39);
            this.editButton.TabIndex = 36;
            this.editButton.Text = "EDIT";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.deleteButton.Location = new System.Drawing.Point(792, 509);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(117, 39);
            this.deleteButton.TabIndex = 35;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.addButton.Location = new System.Drawing.Point(546, 509);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(117, 39);
            this.addButton.TabIndex = 34;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 600);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.courseDescBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.creditHourBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.courseSearchBox);
            this.Controls.Add(this.courseGrid);
            this.Controls.Add(this.courseNameBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CourseForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "CourseForm";
            ((System.ComponentModel.ISupportInitialize)(this.courseGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox courseNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView courseGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox courseSearchBox;
        private System.Windows.Forms.TextBox creditHourBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox courseDescBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
    }
}