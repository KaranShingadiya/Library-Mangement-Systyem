using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY_MANAGEMENT_SYSTEM.Library
{
    public partial class UC_IssueBooks : UserControl
    {
        Function fun = new Function();
        String query;
        public UC_IssueBooks()
        {
            InitializeComponent();
        }

        private void UC_IssueBooks_Load(object sender, EventArgs e)
        {
            query = "select Bname from NewBook";
            setComboBox(query, cmbBookName);

        }
        public void setComboBox(String query, ComboBox combo)
        {
            SqlDataReader sdr = fun.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }



        int count;
        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            String eid = txtEnrollmentNo.Text;
            if (txtEnrollmentNo.Text != "")
            {
                query = "select * from NewStudent where Senrollment='" + eid + "'";
                DataSet ds = fun.getData(query);

                query = "select count(stud_enroll) from IssueReturnBook where stud_enroll='" + eid + "' and book_return_date is null ";
                DataSet ds1 = fun.getData(query);

                count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtStudentName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtDepartment.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtSemester.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtContact.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0][6].ToString();

                }
                else
                {
                    clearAll();
                    MessageBox.Show("Invalid Enrollment No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
        public void clearAll()
        {
            txtEnrollmentNo.Clear();
            txtStudentName.Clear();
            txtDepartment.Clear();
            txtSemester.Clear();
            txtContact.Clear();
            txtEmail.Clear();

        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (txtStudentName.Text != "")
            {

                if (cmbBookName.SelectedIndex != -1 && count <= 2)
                {
                    String enroll = txtEnrollmentNo.Text;
                    String name = txtStudentName.Text;
                    String dep = txtDepartment.Text;
                    String sem = txtSemester.Text;
                    Int64 con = Int64.Parse(txtContact.Text);
                    String email = txtEmail.Text;
                    String bookname = cmbBookName.Text;
                    String bookissuedate = txtBookIssueDate.Text;

                    query = "insert into IssueReturnBook (stud_enroll,stud_name,stud_dep,stud_sem,stud_contact,stud_email,book_name,book_issue_date) values ('" + enroll + "','" + name + "','" + dep + "','" + sem + "'," + con + ",'" + email + "','" + bookname + "','" + bookissuedate + "')";
                    fun.setData(query, "Book Issued Successfully!!!");
                    UC_IssueBooks_Load(this, null);
                    clearAll();
                }
                else
                {
                    MessageBox.Show("Select Book. OR Maximum number of Book has been ISSUED", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Enter Valid Enrollment Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEnrollmentNo_TextChanged(object sender, EventArgs e)
        {
            if (txtEnrollmentNo.Text == "")
            {
                clearAll();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnrollmentNo.Clear();
        }

     
    }
}