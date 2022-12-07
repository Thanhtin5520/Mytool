using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using ExcelDataReader;

namespace Mytool
{
    public partial class Capcode : Form
    {
        DataTable TbResult = new DataTable();
        string strNc = string.Empty;
        string strDelete = string.Empty;
        string strSua = string.Empty;
        static ConnectDatabase condb = new ConnectDatabase();

        public Capcode()
        {
            InitializeComponent();
        }
        /* private void ToExcel(DataGridView dataGridView1, string fileName)
         {
             //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
             Microsoft.Office.Interop.Excel.Application excel;
             Microsoft.Office.Interop.Excel.Workbook workbook;
             Microsoft.Office.Interop.Excel.Worksheet worksheet;
             try
             {
                 //Tạo đối tượng COM.
                 excel = new Microsoft.Office.Interop.Excel.Application();
                 excel.Visible = false;
                 excel.DisplayAlerts = false;
                 //tạo mới một Workbooks bằng phương thức add()
                 workbook = excel.Workbooks.Add(Type.Missing);
                 worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                 //đặt tên cho sheet
                 worksheet.Name = "Quản lý học sinh";

                 // export header trong DataGridView
                 for (int i = 0; i < dataGridView1.ColumnCount; i++)
                 {
                     worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                 }
                 // export nội dung trong DataGridView
                 for (int i = 0; i < dataGridView1.RowCount; i++)
                 {
                     for (int j = 0; j < dataGridView1.ColumnCount; j++)
                     {
                         worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                     }
                 }
                 // sử dụng phương thức SaveAs() để lưu workbook với filename
                 workbook.SaveAs(fileName);
                 //đóng workbook
                 workbook.Close();
                 excel.Quit();
                 MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
             finally
             {
                 workbook = null;
                 worksheet = null;
             }
         }*/
        private void Capcode_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data.NguoiDung' table. You can move, or remove it, as needed.
            this.nguoiDungTableAdapter.Fill(this.data.NguoiDung);
            showData();

        }
        public void showData()
        {
            string sql = "select MAND,MACODE,TYPEC,PERCENTDIS,TENNDX,NGAYCAP from CP order by NGAYCAP";


            DataView dv = new DataView(ConnectDatabase.getDataTable(sql));
            DtgCP.DataSource = dv;
            DtgCP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnAddcp_Click(object sender, EventArgs e)
        {

            try
            {
                if (tbMACODE.Text == "" || cbTypeC.Text == "" || cbNc.Text == "" || tbTenndx.Text == "" || cbNc.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                }
                else
                {
                    strNc = dtNc.Value.ToString("yyyy-MM-dd");
                    string sql = "INSERT INTO CP VALUES('" + cbNc.Text.Trim() + "','" + tbMACODE.Text + "', N'" + cbTypeC.Text + "','" + cbPt.Text.Trim() + "','" + tbTenndx.Text + "','" + strNc + "')";


                    condb.ExecuteNonQuery(sql);

                    MessageBox.Show("Đã thêm mới thành công");

                    showData();
                }
            }
            catch (Exception loi)
            {
                MessageBox.Show("Mã CP đã tồn tại");
            }
        }
        /* abc
        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex > -1 & e.ColumnIndex > -1)
            {
                if (string.IsNullOrEmpty(DtgCP[0, e.RowIndex].FormattedValue.ToString()))
                {
                    MessageBox.Show("Product Name must not be empty");
                    DtgCP.CurrentCell = DtgCP[0, e.RowIndex];
                    e.Cancel = true;
                }
            }
        }
        */
        private void button2_Click(object sender, EventArgs e)
        {
            if (strDelete == "")
            {
                MessageBox.Show("Vui lòng chọn dòng muốn xóa");
                return;
            }
            string sql = "DELETE from CP where MACODE='" + strDelete + "'";

            if (MessageBox.Show("Bạn chắn chắn xoa CP " + strDelete, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                condb.ExecuteNonQuery(sql);

                MessageBox.Show("Done");

                showData();
            }
            else
            {
                showData();

            }



        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Reset();
        }
        void Reset()
        {
            tbMACODE.Clear();
            cbPt.Text = "0";
            tbTenndx.Clear();
            cbNc.Text = "";
            cbTypeC.Text = "";
        }

        private void DtgCP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(DtgCP.CurrentCell.Value.ToString());

            //MessageBox.Show(DT.ToString("MM/dd/yyyy"));



            //DateTime dt = DateTime.ParseExact(DtgCP.CurrentCell.Value.ToString(), "mm/dd/yyyy", CultureInfo.InvariantCulture);
            //dtNc.Value = dt;
        }

        private void DtgCP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DtgCP_Click(object sender, EventArgs e)
        {
            int rows = Convert.ToInt32(DtgCP.CurrentRow.Index);
            strDelete = DtgCP.Rows[rows].Cells[2].Value.ToString();
            dtNc.Format = DateTimePickerFormat.Custom;
            dtNc.CustomFormat = "dd/MM/yyyy";

            int index = DtgCP.CurrentRow.Index;
            tbMACODE.Text = DtgCP.Rows[index].Cells[1].Value.ToString();
            cbTypeC.Text = DtgCP.Rows[index].Cells[2].Value.ToString();
            cbPt.Text = DtgCP.Rows[index].Cells[3].Value.ToString();
            tbTenndx.Text = DtgCP.Rows[index].Cells[4].Value.ToString();
            cbNc.Text = DtgCP.Rows[index].Cells[0].Value.ToString();
            dtNc.Text = DtgCP.Rows[index].Cells[5].Value.ToString();
            //  MessageBox.Show(DtgCP.Rows[index].Cells[5].Value.ToString());
            //DateTime DT = DateTime.Parse(DtgCP.Rows[index].Cells[6].Value.ToString());
            //dtNc.Text = DT.ToString("MM/dd/yyyy");

        }

        private void tbPercentdis_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar <= 100))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }


        }

        private void tbMACODE_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dtNc.Format = DateTimePickerFormat.Custom;
            dtNc.CustomFormat = "dd/MM/yyyy";
            if (tbMACODE.Text == "" || cbTypeC.Text == "" || cbNc.Text == "" || tbTenndx.Text == "" || cbNc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }

            else
            {
                string sql = "UPDATE CP SET MAND =N'" + cbNc.Text.Trim() + "',TYPEC=N'" + cbTypeC.Text.Trim() + "',PERCENTDIS='" + cbPt.Text.Trim() + "',TENNDX='" + tbTenndx.Text.Trim() + "',NGAYCAP='" + dtNc.Value.ToString("yyyy-MM-dd") + "' WHERE MACODE='" + tbMACODE.Text + "'";
                if (MessageBox.Show("Bạn chắn chắn sửa CP " + strSua, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    condb.ExecuteNonQuery(sql);
                    MessageBox.Show("Đã cập nhật dữ lệu");
                    showData();
                }
                else
                {
                    showData();

                }
            }



        }

        private void DtgCP_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string path = string.Empty;

            String Filename = "Báo cáo coupon";

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Title = "Báo cáo coupoun",
                FileName = Filename + DateTime.Now.ToString("_dd.MM.yyyy") + ".xlsx",
                DefaultExt = "xlsx",
                Filter = "Tập tin Excel (*.xlsx)|*.xlsx"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    path = saveDialog.FileName;

                    FileInfo fNewFile = new FileInfo(saveDialog.FileName);
                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                    ExcelPackage package = new ExcelPackage(fNewFile);

                    package.Workbook.Properties.Author = "Thành Tín";
                    package.Workbook.Worksheets.Add("Bao_cao_coupon");

                    package.SaveAs(fNewFile);
                    ExcelWorksheet wsCP = package.Workbook.Worksheets["Bao_cao_coupon"];
                    string sql = "select * from CP";
                    wsCP.Cells.Style.Font.Size = 11;
                    wsCP.Cells.Style.Font.Name = "Times New Roman";
                    MessageBox.Show("Đã xuất dữ liệu");

                    // lấy ra số lượng cột cần dùng dựa vào số lượng header


                    // merge các column lại từ column 1 đến số column header
                    // gán giá trị cho cell vừa merge là Thống kê thông tni User Kteam
                    wsCP.Cells[1, 1].Value = "Thống kê thông tin User Kteam";

                    DataTable TbHeader = ConnectDatabase.getDataTable("SELECT N'ID_ND' [1], N'Mã ND' [MAND], N'Mã Code'[MACODE],N'Loại Code'[TYPEC],N'Phần trăm giảm giá'[PERCENTDIS],N'Người đề xuất'[TENNDX],N'Ngày Cấp'[NGAYCAP]");
                    for (int i = 0; i < TbHeader.Columns.Count; i++)
                    {
                        wsCP.Cells[2, i + 1].Value = TbHeader.Rows[0][i].ToString();
                    }

                    wsCP.Cells[3, 1].LoadFromDataTable(ConnectDatabase.getDataTable(sql), false);
                    wsCP.Cells[1, 1, 1, 7].Merge = true;
                    // in đậm
                    wsCP.Cells[1, 1, 1, 7].Style.Font.Bold = true;
                    Color colFromHex = System.Drawing.ColorTranslator.FromHtml("#B7DEE8");
                    wsCP.Cells[1, 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    wsCP.Cells[2, 1, 2, 7].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    wsCP.Cells[1, 1].Style.Fill.BackgroundColor.SetColor(colFromHex);
                    wsCP.Cells[2, 1, 2, 7].Style.Fill.BackgroundColor.SetColor(colFromHex);
                    wsCP.Cells[2, 1, 2, 7].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    //wsCP.Cells[2, 1, 2, 7].Style.Fill.BackgroundColor.SetColor(colFromHex);

                    // căn giữa
                    wsCP.Cells[1, 1, 1, 7].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    package.SaveAs(fNewFile);
                }
                catch (Exception loi)
                {
                    MessageBox.Show("Lỗi này tính sau");
                }



            }
        }
        DataTableCollection tableCollection;

        private void button3_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tbFilename.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            cbSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cbSheet.Items.Add(table.TableName);

                        }
                    }
                }
            }
        


            }
        }
    }

