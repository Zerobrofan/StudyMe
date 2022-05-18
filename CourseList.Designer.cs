
namespace Gamey
{
    partial class CourseList
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
            this.printButton = new System.Windows.Forms.Button();
            this.courseListGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.courseListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // printButton
            // 
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.printButton.Location = new System.Drawing.Point(742, 496);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(143, 38);
            this.printButton.TabIndex = 48;
            this.printButton.Text = "PRINT";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // courseListGrid
            // 
            this.courseListGrid.AllowUserToAddRows = false;
            this.courseListGrid.AllowUserToDeleteRows = false;
            this.courseListGrid.AllowUserToResizeColumns = false;
            this.courseListGrid.AllowUserToResizeRows = false;
            this.courseListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.courseListGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.courseListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseListGrid.Location = new System.Drawing.Point(14, 67);
            this.courseListGrid.Name = "courseListGrid";
            this.courseListGrid.ReadOnly = true;
            this.courseListGrid.Size = new System.Drawing.Size(913, 366);
            this.courseListGrid.TabIndex = 47;
            // 
            // CourseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 600);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.courseListGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseList";
            this.Text = "CourseList";
            this.Load += new System.EventHandler(this.CourseList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseListGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.DataGridView courseListGrid;
    }
}