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
    public partial class UC_ViewBooks : UserControl
    {
        Function fun = new Function();
        String query;
        public UC_ViewBooks()
        {
            InitializeComponent();
        }

        private void UC_ViewBooks_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            query = "select * from NewBook";
            DataSet ds=fun.getData(query);
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
            query = "select * from NewBook where Bid="+bid+"";
            DataSet ds=fun.getData(query);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtBookName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtAuthorName.Text = ds.Tables[0].Rows[0][2].ToString();
            txtPublication.Text = ds.Tables[0].Rows[0][3].ToString();
            PublicationDate.Text = ds.Tables[0].Rows[0][4].ToString();
            txtPrice.Text = ds.Tables[0].Rows[0][5].ToString();
            txtQuantity.Text = ds.Tables[0].Rows[0][6].ToString();            
        }

        private void txtSearchBook_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchBook.Text!="")
            {
                query = "select * from NewBook where Bname LIKE '" + txtSearchBook.Text + "%'";
                DataSet ds = fun.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];

            }
            else
            {
                query = "select * from NewBook";
                DataSet ds= fun.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];//uper ni codition false thay to pachhu aakhu table show thai jase. 
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearchBook.Clear();
            panel1.Visible = false;
            UC_ViewBooks_Load(this, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Data Will Be Updated Confirm ?","Success",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                String bname = txtBookName.Text;
                String aname = txtAuthorName.Text;
                String pname = txtPublication.Text;
                String pdate = PublicationDate.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                String quantity = txtQuantity.Text;

                query = "Update NewBook set Bname='"+bname+"',Bauthor='"+aname+"',Bpublication='"+pname+"',Bpublicationdate='"+pdate+"',Bprice="+price+",Bquantity='"+quantity+"' where Bid="+rowid+"";
                fun.setData(query, "Update Successfully!!!");
                UC_ViewBooks_Load(this, null);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Data Will Be Deleted Confirm ?","Success",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                query="delete from NewBook where Bid="+rowid+"";
                fun.setData(query, "Delete Successfully!!!");
                UC_ViewBooks_Load(this, null);
            }
        }

        private void txtSearchBook_Click(object sender, EventArgs e)
        {
            UC_ViewBooks_Load(this, null);
        }
    }
}
