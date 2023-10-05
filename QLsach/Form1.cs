using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLsach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=NGUYENMINH;Initial Catalog=qlsach;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into bang values('"+txtmasach.Text+ "','"+txttensach.Text+ "','"+Convert.ToDouble(txtgia.Text)+ "','"+Convert.ToInt16(txtsoluong.Text)+"')", conn);
            conn.Open();
            int ret=cmd.ExecuteNonQuery();
            if (ret == 1) {
                MessageBox.Show ("them du lieu thanh cong");
            }
            conn.Close();
        }

        private void txttensach_TextChanged(object sender, EventArgs e)
        {
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=NGUYENMINH;Initial Catalog=qlsach;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("update bang set tensach='" + txttensach.Text + "',gia='" + Convert.ToDouble(txtgia.Text) + "',soluong='" + Convert.ToInt16(txtsoluong.Text) + "'where masach='" + txtmasach.Text + "'", conn);
            conn.Open();
            int ret = cmd.ExecuteNonQuery();
            if (ret == 1)
            {
                MessageBox.Show("cap nhat du lieu thanh cong");
            }
            conn.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=NGUYENMINH;Initial Catalog=qlsach;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("delete from bang where masach='" + txtmasach.Text + "'", conn);
            conn.Open();
            int ret = cmd.ExecuteNonQuery();
            if (ret == 1)
            {
                MessageBox.Show("xoa du lieu thanh cong");
            }
            conn.Close();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
