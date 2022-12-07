using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mytool
{
    public partial class Home : Form

    {
        
        DataTable TbResult = new DataTable();
        static ConnectDatabase condb = new ConnectDatabase();
        public Home()
        {
            InitializeComponent();

        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data.NguoiDung' table. You can move, or remove it, as needed.
            this.nguoiDungTableAdapter1.Fill(this.data.NguoiDung);
            // TODO: This line of code loads data into the 'toolLoDataSet5.CP' table. You can move, or remove it, as needed.
     
            // TODO: This line of code loads data into the 'toolLoDataSet4.NguoiDung' table. You can move, or remove it, as needed.
     
            // TODO: This line of code loads data into the 'toolLoDataSet2.CP' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'toolLoDataSet1.CP' table. You can move, or remove it, as needed.
   
            Dangnhap frm = new Dangnhap();
            frm.ShowDialog();
        

           label3.Text = "Xin chào: " + frm.GetU();
        } 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pntest_Paint(object sender, PaintEventArgs e)
        {
            //string sql = "select * from CP";
            //TbResult = ConnectDatabase.getDataTable(sql);
        }

   
        private void DtgCP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string sql = "INSERT INTO CP VALUES('" +tbMACODE.Text + "','" + cbTypeC.Text + "','" + tbPercentdis.Text + "','" + tbTenndx.Text + "','" + cbNc.Text + "','" + dtNc.Text + "')";
           

            //condb.ExecuteNonQuery(sql);

            //MessageBox.Show("Done");

            //showData();
        }

        private void tbMACODE_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnCapcode_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKHBH_Click(object sender, EventArgs e)
        {
            Capcode frm = new Capcode();
            frm.ShowDialog();
            

        }
    }
}
