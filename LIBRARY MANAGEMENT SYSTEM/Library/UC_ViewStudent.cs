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
    public partial class UC_ViewStudent : UserControl
    {
        Function fun = new Function();
        String query;
        public UC_ViewStudent()
        {
            InitializeComponent();
        }

        private void txtSearchEnrollmentNo_TextChanged(object sender, EventArgs e)
        {
            

            if (txtSearchEnrollmentNo.Text!="")
            {
                query = "select * from NewStudent where Senrollment LIKE '"+txtSearchEnrollmentNo.Text+"%'";
                DataSet ds=fun.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                query = "select * from NewStudent";
                DataSet ds = fun.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void UC_ViewStudent_Load(object sender, EventArgs e)
        {
            

            panel1.Visible = false;

            query = "select * from NewStudent";
            DataSet ds = fun.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
         
        }

        int bid;
        Int64 rowid;

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                bid = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel1.Visible = true;

            query = "select * from NewStudent where Sid=" + bid + "";
            DataSet ds = fun.getData(query);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtStudentName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtEnrollmentNo.Text = ds.Tables[0].Rows[0][2].ToString();
            txtDepartment.Text = ds.Tables[0].Rows[0][3].ToString();
            txtStudentSemester.Text = ds.Tables[0].Rows[0][4].ToString();
            txtStudentContact.Text = ds.Tables[0].Rows[0][5].ToString();
            txtStudentEmail.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String sname = txtStudentName.Text;
            String senroll = txtSearchEnrollmentNo.Text;
            String depart= txtDepartment.Text;
            String sem =txtStudentSemester.Text;
            Int64 contact = Int64.Parse(txtStudentContact.Text);
            String email=txtStudentEmail.Text;
            
            if(MessageBox.Show("Data Will Be Updated, Confirm ?.", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                query = "update NewStudent set Sname='"+sname+"',Senrollment='"+senroll+"',Sdepartment='"+depart+"',Ssemester='"+sem+"',Scontact="+contact+",Semail='"+email+"' where Sid="+rowid+"";
                fun.setData(query, "Update Successfully!!!");
                UC_ViewStudent_Load(this, null);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UC_ViewStudent_Load(this, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be Deleted,Confirm?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                query = "delete NewStudent where Sid=" + rowid + "";
                fun.setData(query, "Deleted Successfully!!!");
                UC_ViewStudent_Load(this, null);
            } 
        }

        private void txtSearchEnrollmentNo_Click(object sender, EventArgs e)
        {
            UC_ViewStudent_Load(this, null);
        }
    }
    
}
