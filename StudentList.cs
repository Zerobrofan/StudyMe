using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using DGVPrinterHelper;

namespace Gamey
{
    public partial class StudentList : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\StudyMe\StudyMeDB.mdf;Integrated Security=True;Connect Timeout=30");
        DGVPrinter printer = new DGVPrinter();
        public StudentList()
        {
            InitializeComponent();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printer.Title = "Student list";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.ToString());
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "StudyMe";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(stuListGrid);
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            Pobulate();
        }

        private void Pobulate()
        {
            con.Open();
            string query = "select * from stuTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder scd = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            BindingSource bs = new BindingSource();
            sda.Fill(ds);
            bs.DataSource = ds.Tables[0];
            stuListGrid.DataSource = bs;
            con.Close();
        }
    }
}
