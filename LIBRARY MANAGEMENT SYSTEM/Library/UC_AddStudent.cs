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
    public partial class UC_AddStudent : UserControl
    {
        Function fun = new Function();
        String query;
        public UC_AddStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtStudentName.Text!="" && txtEnrollmentNo.Text!="" && txtDepartment.Text!="" && txtSemester.Text!="" && txtStudentContact.Text!="" && txtStudentEmail.Text!="")
            {
                String sname = txtStudentName.Text;
                String senrollmentno = txtEnrollmentNo.Text;
                String sdepartment=txtDepartment.Text;
                String semester =txtSemester.Text;
                Int64 contact = Int64.Parse(txtStudentContact.Text);
                String email = txtStudentEmail.Text;

                query = "insert into NewStudent (Sname,Senrollment,Sdepartment,Ssemester,Scontact,Semail) values ('"+sname+"','"+senrollmentno+"','"+sdepartment+"','"+semester+"',"+contact+",'"+email+"')";
                fun.setData(query, "Add Student Successfully !!!");
                ClearALL();
            }
            else
            {
                MessageBox.Show("Please Fill The Field !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ClearALL()
        {
            txtStudentName.Clear();
            txtEnrollmentNo.Clear();
            txtDepartment.Clear();
            txtSemester.Clear();
            txtStudentContact.Clear();
            txtStudentEmail.Clear();   
        }

      

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearALL();
        }

        private void UC_AddStudent_Leave(object sender, EventArgs e)
        {
            ClearALL();
        }

      
    }
}
