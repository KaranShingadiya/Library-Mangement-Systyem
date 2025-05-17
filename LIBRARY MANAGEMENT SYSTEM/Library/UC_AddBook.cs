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
    public partial class UC_AddBook : UserControl
    {
        Function fun = new Function();
        String query;

        public UC_AddBook()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtBookName.Text!="" && txtAuthorName.Text!="" && txtPublication.Text!="" && PublicationDate.Text!="" && txtPrice.Text!="" && txtQuantity.Text!="")
            {
                String bname = txtBookName.Text;
                String bauthor = txtAuthorName.Text;
                String bpublication = txtPublication.Text;
                String bpubdate = PublicationDate.Text;
                Int64 bprice = Int64.Parse(txtPrice.Text);
                Int64 bquantity = Int64.Parse(txtQuantity.Text);

                query = "insert into NewBook(Bname,Bauthor,Bpublication,Bpublicationdate,Bprice,Bquantity) values('"+bname+"','"+bauthor+"','"+bpublication+"','"+bpubdate+"',"+bprice+","+bquantity+")";
                fun.setData(query, "Insert Data SuccessFully !!!");
                ClearALL();
            }
            else
            {
                MessageBox.Show("Please Fill The Field !!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        public void ClearALL()
        {
            txtBookName.Clear();
            txtAuthorName.Clear();
            txtPublication.Clear();
            PublicationDate.ResetText();   
            txtPrice.Clear();
            txtQuantity.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This Will Delete Your Unsaved Data", "Are You Sure ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) 
            {
                ClearALL();
            }
        }

        private void UC_AddBook_Leave(object sender, EventArgs e)
        {
            ClearALL();
        }
    }
    
}
