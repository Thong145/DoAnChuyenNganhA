namespace DoAnChuyenNganhA
{
    partial class Test2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test2));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_data1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_data2 = new System.Windows.Forms.DataGridView();
            this.cbx_congty = new System.Windows.Forms.ComboBox();
            this.cbx_nam = new System.Windows.Forms.ComboBox();
            this.lbl_congty = new System.Windows.Forms.Label();
            this.lbl_nam = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_data = new System.Windows.Forms.Label();
            this.btn_show = new System.Windows.Forms.Button();
            this.dataSet1 = new DoAnChuyenNganhA.DataSet1();
            this.bIDVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bIDVTableAdapter = new DoAnChuyenNganhA.DataSet1TableAdapters.BIDVTableAdapter();
            this.btn_import = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIDVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(26, 151);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(938, 496);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_data1);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(930, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hiển thị tất cả";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_data1
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.dgv_data1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_data1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_data1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_data1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_data1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_data1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_data1.EnableHeadersVisualStyles = false;
            this.dgv_data1.Location = new System.Drawing.Point(3, 6);
            this.dgv_data1.Name = "dgv_data1";
            this.dgv_data1.RowTemplate.Height = 24;
            this.dgv_data1.Size = new System.Drawing.Size(927, 442);
            this.dgv_data1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_data2);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(930, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chỉ thông tin quan trọng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_data2
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.dgv_data2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_data2.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_data2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_data2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_data2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_data2.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_data2.EnableHeadersVisualStyles = false;
            this.dgv_data2.Location = new System.Drawing.Point(3, 6);
            this.dgv_data2.Name = "dgv_data2";
            this.dgv_data2.RowTemplate.Height = 24;
            this.dgv_data2.Size = new System.Drawing.Size(927, 442);
            this.dgv_data2.TabIndex = 0;
            // 
            // cbx_congty
            // 
            this.cbx_congty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_congty.FormattingEnabled = true;
            this.cbx_congty.Location = new System.Drawing.Point(180, 107);
            this.cbx_congty.Name = "cbx_congty";
            this.cbx_congty.Size = new System.Drawing.Size(145, 30);
            this.cbx_congty.TabIndex = 1;
            this.cbx_congty.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // cbx_nam
            // 
            this.cbx_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_nam.FormattingEnabled = true;
            this.cbx_nam.Items.AddRange(new object[] {
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cbx_nam.Location = new System.Drawing.Point(463, 107);
            this.cbx_nam.Name = "cbx_nam";
            this.cbx_nam.Size = new System.Drawing.Size(147, 30);
            this.cbx_nam.TabIndex = 2;
            this.cbx_nam.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // lbl_congty
            // 
            this.lbl_congty.AutoSize = true;
            this.lbl_congty.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_congty.Location = new System.Drawing.Point(31, 112);
            this.lbl_congty.Name = "lbl_congty";
            this.lbl_congty.Size = new System.Drawing.Size(126, 22);
            this.lbl_congty.TabIndex = 3;
            this.lbl_congty.Text = "Chọn công ty";
            // 
            // lbl_nam
            // 
            this.lbl_nam.AutoSize = true;
            this.lbl_nam.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nam.Location = new System.Drawing.Point(345, 112);
            this.lbl_nam.Name = "lbl_nam";
            this.lbl_nam.Size = new System.Drawing.Size(100, 22);
            this.lbl_nam.TabIndex = 4;
            this.lbl_nam.Text = "Chọn năm";
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(699, 655);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(249, 44);
            this.btn_exit.TabIndex = 30;
            this.btn_exit.Text = "Đăng xuất";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_data
            // 
            this.lbl_data.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_data.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_data.Location = new System.Drawing.Point(-5, 19);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(988, 42);
            this.lbl_data.TabIndex = 31;
            this.lbl_data.Text = "Bảng dữ liệu báo cáo tài chính";
            this.lbl_data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_show
            // 
            this.btn_show.AutoSize = true;
            this.btn_show.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.Image = ((System.Drawing.Image)(resources.GetObject("btn_show.Image")));
            this.btn_show.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_show.Location = new System.Drawing.Point(616, 101);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(353, 46);
            this.btn_show.TabIndex = 36;
            this.btn_show.Text = "Danh sách các công ty theo...";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bIDVBindingSource
            // 
            this.bIDVBindingSource.DataMember = "BIDV";
            this.bIDVBindingSource.DataSource = this.dataSet1;
            // 
            // bIDVTableAdapter
            // 
            this.bIDVTableAdapter.ClearBeforeFill = true;
            // 
            // btn_import
            // 
            this.btn_import.AutoSize = true;
            this.btn_import.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_import.Image = ((System.Drawing.Image)(resources.GetObject("btn_import.Image")));
            this.btn_import.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_import.Location = new System.Drawing.Point(35, 655);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(299, 40);
            this.btn_import.TabIndex = 37;
            this.btn_import.Text = "Import Excel data";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // Test2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 711);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_nam);
            this.Controls.Add(this.lbl_congty);
            this.Controls.Add(this.cbx_nam);
            this.Controls.Add(this.cbx_congty);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Test2";
            this.Text = "Test2";
            this.Load += new System.EventHandler(this.Test2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIDVBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbx_congty;
        private System.Windows.Forms.ComboBox cbx_nam;
        private System.Windows.Forms.Label lbl_congty;
        private System.Windows.Forms.Label lbl_nam;
        private System.Windows.Forms.DataGridView dgv_data1;
        private System.Windows.Forms.DataGridView dgv_data2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Button btn_show;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource bIDVBindingSource;
        private DataSet1TableAdapters.BIDVTableAdapter bIDVTableAdapter;
        private System.Windows.Forms.Button btn_import;
    }
}