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
    public partial class UC_CompleteBookDetails : UserControl
    {
        Function fun= new Function();
        String query;

        public UC_CompleteBookDetails()
        {
            InitializeComponent();
        }

        private void UC_CompleteBookDetails_Load(object sender, EventArgs e)
        {
            query = "select * from IssueReturnBook where book_return_date is null";
            DataSet ds = fun.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

            


            query = "select * from IssueReturnBook where book_return_date is not null";
            DataSet ds1 = fun.getData(query);
            guna2DataGridView2.DataSource = ds1.Tables[0];
        }
    }
}
