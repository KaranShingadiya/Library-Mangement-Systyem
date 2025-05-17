using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY_MANAGEMENT_SYSTEM.Library
{
    public partial class UC_ReturnBook : UserControl
    {
        Function fun=new Function();
        String query;
        public UC_ReturnBook()
        {
            InitializeComponent();
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            query= "select * from IssueReturnBook where stud_enroll='" + txtEnrollmentNo.Text + "' and book_return_date IS NULL";


            DataSet ds = fun.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

            if (ds.Tables[0].Rows.Count != 0)
            {
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid Enrollment Number or No Book Issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnrollmentNo.Clear();
            }
        }

        private void UC_ReturnBook_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            txtEnrollmentNo.Clear();
        }
        String bname;
        String bdate;
        Int64 rowid;

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible=true;

            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value !=null)
            {
                rowid = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = guna2DataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                bdate= guna2DataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            txtBookName.Text = bname;
            txtBookIssueDate.Text = bdate;
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            query = "select * from IssueReturnBook where stud_enroll='" + txtEnrollmentNo.Text + "' and book_return_date IS NULL";


            query = "update IssueReturnBook set book_return_date='" + guna2DateTimePicker1.Text + "' where stud_enroll='" + txtEnrollmentNo.Text + "' and id=" + rowid + " ";
            fun.setData(query, "Return Book Successfully!!!");

            UC_ReturnBook_Load(this, null);
        }

        private void txtEnrollmentNo_TextChanged(object sender, EventArgs e)
        {
            if(txtEnrollmentNo.Text =="")
            {
                panel1.Visible = false;
                guna2DataGridView1.DataSource = null;// aakhu khali batavse.
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
