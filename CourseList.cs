using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using DGVPrinterHelper;

namespace Gamey
{
    public partial class CourseList : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\StudyMe\StudyMeDB.mdf;Integrated Security=True;Connect Timeout=30");
        DGVPrinter printer = new DGVPrinter();
        public CourseList()
        {
            InitializeComponent();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printer.Title = "Course list";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.ToString());
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "StudyMe";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(courseListGrid);
        }

        private void Pobulate()
        {
            con.Open();
            string query = "select * from courseTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder scd = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            BindingSource bs = new BindingSource();
            sda.Fill(ds);
            bs.DataSource = ds.Tables[0];
            courseListGrid.DataSource = bs;
            con.Close();
        }

        private void CourseList_Load(object sender, EventArgs e)
        {
            Pobulate();
        }
    }
}
