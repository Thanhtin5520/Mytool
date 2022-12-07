
namespace Mytool
{
    partial class Home
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnCcode = new System.Windows.Forms.Button();
            this.btnKHBH = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnCapcode = new System.Windows.Forms.Panel();
            this.nguoiDungBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.data = new Mytool.Data();
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nguoiDungTableAdapter1 = new Mytool.DataTableAdapters.NguoiDungTableAdapter();
            this.cPBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cPBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pnCapcode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(53, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Xin chào ,    ";
            // 
            // btnCcode
            // 
            this.btnCcode.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCcode.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCcode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCcode.Location = new System.Drawing.Point(119, 117);
            this.btnCcode.Name = "btnCcode";
            this.btnCcode.Size = new System.Drawing.Size(136, 91);
            this.btnCcode.TabIndex = 4;
            this.btnCcode.Text = "Cấp Code";
            this.btnCcode.UseVisualStyleBackColor = false;
            this.btnCcode.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKHBH
            // 
            this.btnKHBH.BackColor = System.Drawing.Color.Red;
            this.btnKHBH.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKHBH.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKHBH.Location = new System.Drawing.Point(387, 117);
            this.btnKHBH.Name = "btnKHBH";
            this.btnKHBH.Size = new System.Drawing.Size(136, 91);
            this.btnKHBH.TabIndex = 5;
            this.btnKHBH.Text = "Kích Hoạt BHDT";
            this.btnKHBH.UseVisualStyleBackColor = false;
            this.btnKHBH.Click += new System.EventHandler(this.btnKHBH_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(653, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 91);
            this.button2.TabIndex = 6;
            this.button2.Text = "Hủy Kích Hoạt BHDT";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pnCapcode
            // 
            this.pnCapcode.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnCapcode.Controls.Add(this.button2);
            this.pnCapcode.Controls.Add(this.label3);
            this.pnCapcode.Controls.Add(this.btnCcode);
            this.pnCapcode.Controls.Add(this.btnKHBH);
            this.pnCapcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCapcode.Location = new System.Drawing.Point(0, 0);
            this.pnCapcode.Name = "pnCapcode";
            this.pnCapcode.Size = new System.Drawing.Size(927, 524);
            this.pnCapcode.TabIndex = 7;
            this.pnCapcode.Paint += new System.Windows.Forms.PaintEventHandler(this.pnCapcode_Paint);
            // 
            // nguoiDungBindingSource1
            // 
            this.nguoiDungBindingSource1.DataMember = "NguoiDung";
            this.nguoiDungBindingSource1.DataSource = this.data;
            // 
            // data
            // 
            this.data.DataSetName = "Data";
            this.data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataBindingSource
            // 
            this.dataBindingSource.DataSource = this.data;
            this.dataBindingSource.Position = 0;
            // 
            // nguoiDungTableAdapter1
            // 
            this.nguoiDungTableAdapter1.ClearBeforeFill = true;
            // 
            // cPBindingSource1
            // 
            this.cPBindingSource1.DataMember = "CP";
            // 
            // cPBindingSource
            // 
            this.cPBindingSource.DataMember = "CP";
            // 
            // nguoiDungBindingSource
            // 
            this.nguoiDungBindingSource.DataMember = "NguoiDung";
            // 
            // cPBindingSource2
            // 
            this.cPBindingSource2.DataMember = "CP";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(927, 524);
            this.Controls.Add(this.pnCapcode);
            this.MinimizeBox = false;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.pnCapcode.ResumeLayout(false);
            this.pnCapcode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCcode;
        private System.Windows.Forms.Button btnKHBH;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnCapcode;
    
        private System.Windows.Forms.BindingSource cPBindingSource;
 
        private System.Windows.Forms.BindingSource cPBindingSource1;
       
        private System.Windows.Forms.BindingSource nguoiDungBindingSource;
   
        private System.Windows.Forms.BindingSource cPBindingSource2;
  
        private System.Windows.Forms.BindingSource dataBindingSource;
        private Data data;
        private System.Windows.Forms.BindingSource nguoiDungBindingSource1;
        private DataTableAdapters.NguoiDungTableAdapter nguoiDungTableAdapter1;
    }
}