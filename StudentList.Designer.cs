
namespace Gamey
{
    partial class StudentList
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
            this.stuListGrid = new System.Windows.Forms.DataGridView();
            this.printButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stuListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // stuListGrid
            // 
            this.stuListGrid.AllowUserToAddRows = false;
            this.stuListGrid.AllowUserToDeleteRows = false;
            this.stuListGrid.AllowUserToResizeColumns = false;
            this.stuListGrid.AllowUserToResizeRows = false;
            this.stuListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stuListGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stuListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stuListGrid.Location = new System.Drawing.Point(14, 73);
            this.stuListGrid.Name = "stuListGrid";
            this.stuListGrid.ReadOnly = true;
            this.stuListGrid.Size = new System.Drawing.Size(913, 366);
            this.stuListGrid.TabIndex = 45;
            // 
            // printButton
            // 
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.printButton.Location = new System.Drawing.Point(742, 502);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(143, 38);
            this.printButton.TabIndex = 46;
            this.printButton.Text = "PRINT";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // StudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 600);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.stuListGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentList";
            this.Text = "StudentList";
            this.Load += new System.EventHandler(this.StudentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stuListGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView stuListGrid;
        private System.Windows.Forms.Button printButton;
    }
}