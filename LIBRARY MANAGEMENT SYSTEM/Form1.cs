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
    public partial class Form1 : Form
    {
        Function fun = new Function();
        String query;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExitt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            query = "select * from Login where username='" + txtUsername.Text + "' and pasword='" + txtPassword.Text + "'";
            DataSet ds = fun.getData(query);

            if (ds.Tables[0].Rows.Count!=0)
            {
                this.Hide();
                Dashboard dsa= new Dashboard();
                dsa.Show();
            }
            else
            {
                MessageBox.Show("Please Enter Username OR Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
