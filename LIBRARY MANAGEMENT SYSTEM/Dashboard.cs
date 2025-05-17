using LIBRARY_MANAGEMENT_SYSTEM.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY_MANAGEMENT_SYSTEM
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExitt_Click(object sender, EventArgs e)
        {
            Application.Exit();    
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            uC_AddStudent1.Visible = true;
            uC_AddStudent1.BringToFront();
        }

        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            uC_AddBook1.Visible = true;
            uC_AddBook1.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
           
            uC_AddBook1.Visible = false;
            uC_AddStudent1.Visible = false;
            btnAddStudent.PerformClick();
            uC_ViewStudent1.Visible = false;
            uC_ViewBooks1.Visible = false;
            uC_IssueBooks1.Visible = false;
            uC_ReturnBook1.Visible = false;
            uC_CompleteBookDetails1.Visible = false;
           
            
        }

        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            uC_ViewStudent1.Visible = true;
            uC_ViewStudent1.BringToFront();
        }

        private void btnViewBooks_Click(object sender, EventArgs e)
        {
            uC_ViewBooks1.Visible= true;
            uC_ViewBooks1.BringToFront();
        }

        private void btnIssuedBooks_Click(object sender, EventArgs e)
        {
            uC_IssueBooks1.Visible = true;
            uC_IssueBooks1.BringToFront();
        }

        private void btnReturnBooks_Click(object sender, EventArgs e)
        {
            uC_ReturnBook1.Visible= true;
            uC_ReturnBook1.BringToFront();
        }

        private void btnCompleteBooksDetails_Click(object sender, EventArgs e)
        {
            uC_CompleteBookDetails1.Visible = true;
            uC_CompleteBookDetails1.BringToFront();
           
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       
    }
}
