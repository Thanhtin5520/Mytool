
namespace Mytool
{
    partial class Capcode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtNc = new System.Windows.Forms.DateTimePicker();
            this.cbNc = new System.Windows.Forms.ComboBox();
            this.nguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data = new Mytool.Data();
            this.cbTypeC = new System.Windows.Forms.ComboBox();
            this.btnAddcp = new System.Windows.Forms.Button();
            this.DtgCP = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tbTenndx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMACODE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nguoiDungTableAdapter = new Mytool.DataTableAdapters.NguoiDungTableAdapter();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbPt = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cbSheet = new System.Windows.Forms.ComboBox();
            this.tbFilename = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgCP)).BeginInit();
            this.SuspendLayout();
            // 
            // dtNc
            // 
            this.dtNc.Location = new System.Drawing.Point(633, 277);
            this.dtNc.Name = "dtNc";
            this.dtNc.Size = new System.Drawing.Size(193, 20);
            this.dtNc.TabIndex = 35;
            // 
            // cbNc
            // 
            this.cbNc.DataSource = this.nguoiDungBindingSource;
            this.cbNc.DisplayMember = "MAND";
            this.cbNc.FormattingEnabled = true;
            this.cbNc.Location = new System.Drawing.Point(633, 199);
            this.cbNc.Name = "cbNc";
            this.cbNc.Size = new System.Drawing.Size(182, 21);
            this.cbNc.TabIndex = 34;
            this.cbNc.ValueMember = "MAND";
            // 
            // nguoiDungBindingSource
            // 
            this.nguoiDungBindingSource.DataMember = "NguoiDung";
            this.nguoiDungBindingSource.DataSource = this.data;
            // 
            // data
            // 
            this.data.DataSetName = "Data";
            this.data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbTypeC
            // 
            this.cbTypeC.FormattingEnabled = true;
            this.cbTypeC.Items.AddRange(new object[] {
            "Cấp Code Giảm Giá Nội Bộ NV",
            "Cấp Code Giảm Giá Nội Bộ BOD"});
            this.cbTypeC.Location = new System.Drawing.Point(235, 205);
            this.cbTypeC.Name = "cbTypeC";
            this.cbTypeC.Size = new System.Drawing.Size(182, 21);
            this.cbTypeC.TabIndex = 33;
            // 
            // btnAddcp
            // 
            this.btnAddcp.Location = new System.Drawing.Point(841, 136);
            this.btnAddcp.Name = "btnAddcp";
            this.btnAddcp.Size = new System.Drawing.Size(67, 61);
            this.btnAddcp.TabIndex = 32;
            this.btnAddcp.Text = "Lưu";
            this.btnAddcp.UseVisualStyleBackColor = true;
            this.btnAddcp.Click += new System.EventHandler(this.btnAddcp_Click);
            // 
            // DtgCP
            // 
            this.DtgCP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgCP.Location = new System.Drawing.Point(31, 318);
            this.DtgCP.Name = "DtgCP";
            this.DtgCP.Size = new System.Drawing.Size(898, 183);
            this.DtgCP.TabIndex = 31;
            this.DtgCP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgCP_CellClick);
            this.DtgCP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgCP_CellContentClick);
            this.DtgCP.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgCP_CellValueChanged);
            this.DtgCP.Click += new System.EventHandler(this.DtgCP_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 43);
            this.button1.TabIndex = 20;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbTenndx
            // 
            this.tbTenndx.Location = new System.Drawing.Point(633, 139);
            this.tbTenndx.Name = "tbTenndx";
            this.tbTenndx.Size = new System.Drawing.Size(182, 20);
            this.tbTenndx.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.OrangeRed;
            this.label9.Location = new System.Drawing.Point(350, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(294, 31);
            this.label9.TabIndex = 21;
            this.label9.Text = "CẤP CODE GIẢM GIÁ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.OrangeRed;
            this.label8.Location = new System.Drawing.Point(50, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 22);
            this.label8.TabIndex = 22;
            this.label8.Text = "Mã Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(38, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "Loại Code Giảm Giá";
            // 
            // tbMACODE
            // 
            this.tbMACODE.Location = new System.Drawing.Point(235, 138);
            this.tbMACODE.MaxLength = 20;
            this.tbMACODE.Name = "tbMACODE";
            this.tbMACODE.Size = new System.Drawing.Size(182, 20);
            this.tbMACODE.TabIndex = 28;
            this.tbMACODE.TextChanged += new System.EventHandler(this.tbMACODE_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(36, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 22);
            this.label6.TabIndex = 24;
            this.label6.Text = "Phần Trăm Giảm giá";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.OrangeRed;
            this.label12.Location = new System.Drawing.Point(465, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 22);
            this.label12.TabIndex = 27;
            this.label12.Text = "Ngày cấp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.OrangeRed;
            this.label10.Location = new System.Drawing.Point(465, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 22);
            this.label10.TabIndex = 25;
            this.label10.Text = "Tên Người đề xuất";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.OrangeRed;
            this.label11.Location = new System.Drawing.Point(465, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 22);
            this.label11.TabIndex = 26;
            this.label11.Text = "Người cấp";
            // 
            // nguoiDungTableAdapter
            // 
            this.nguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // BtnXoa
            // 
            this.BtnXoa.Location = new System.Drawing.Point(914, 136);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(67, 61);
            this.BtnXoa.TabIndex = 36;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            this.BtnXoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(914, 205);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(67, 61);
            this.btnSua.TabIndex = 37;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(841, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 61);
            this.button2.TabIndex = 38;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // cbPt
            // 
            this.cbPt.FormattingEnabled = true;
            this.cbPt.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "30",
            "40",
            "50"});
            this.cbPt.Location = new System.Drawing.Point(235, 273);
            this.cbPt.Name = "cbPt";
            this.cbPt.Size = new System.Drawing.Size(182, 21);
            this.cbPt.TabIndex = 39;
            this.cbPt.Text = "10";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(854, 277);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 39);
            this.button4.TabIndex = 41;
            this.button4.Text = "Xuất excell";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(668, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 39);
            this.button3.TabIndex = 42;
            this.button3.Text = "Nhập excell";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // cbSheet
            // 
            this.cbSheet.FormattingEnabled = true;
            this.cbSheet.Location = new System.Drawing.Point(749, 50);
            this.cbSheet.Name = "cbSheet";
            this.cbSheet.Size = new System.Drawing.Size(131, 21);
            this.cbSheet.TabIndex = 43;
            // 
            // tbFilename
            // 
            this.tbFilename.Location = new System.Drawing.Point(749, 22);
            this.tbFilename.Name = "tbFilename";
            this.tbFilename.Size = new System.Drawing.Size(159, 20);
            this.tbFilename.TabIndex = 44;
            // 
            // Capcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 637);
            this.Controls.Add(this.tbFilename);
            this.Controls.Add(this.cbSheet);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cbPt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.dtNc);
            this.Controls.Add(this.cbNc);
            this.Controls.Add(this.cbTypeC);
            this.Controls.Add(this.btnAddcp);
            this.Controls.Add(this.DtgCP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbTenndx);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbMACODE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Name = "Capcode";
            this.Text = "Capcode";
            this.Load += new System.EventHandler(this.Capcode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgCP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtNc;
        private System.Windows.Forms.ComboBox cbNc;
        private System.Windows.Forms.ComboBox cbTypeC;
        private System.Windows.Forms.Button btnAddcp;
        private System.Windows.Forms.DataGridView DtgCP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbTenndx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMACODE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Data data;
        private System.Windows.Forms.BindingSource nguoiDungBindingSource;
        private DataTableAdapters.NguoiDungTableAdapter nguoiDungTableAdapter;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbPt;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbSheet;
        private System.Windows.Forms.TextBox tbFilename;
    }
}