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
using System.Configuration;




namespace Mytool
{
    public partial class Dangnhap : Form
    {
        DataTable TbResult = new DataTable();


        public Dangnhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(@"Data Source=WS30206\MSSQLSERVER01;Initial Catalog=Tool;Integrated Security=True");

            try
            {
                //conn.Open();
                string TK = tbTK.Text;
                string MK = tbMK.Text;
                string sql = "SELECT * FROM NguoiDung where MAND= '" + TK+"' and MATKHAU= '"+MK+"'";

                TbResult = ConnectDatabase.getDataTable(sql);

                if(TbResult.Rows.Count == 1)
                {
                    MessageBox.Show("Đăng Nhập Thành Công","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                   
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi Kết Nối");
            }
          
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát hay không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(tb ==DialogResult.OK)
            Application.Exit();
        }

        public  string GetU()
        {
            string Name = string.Empty;
            if (TbResult.Rows.Count == 1)
                Name = TbResult.Rows[0]["HOTEN"].ToString();

            return Name;
        }
    }
}
