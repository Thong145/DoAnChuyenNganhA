namespace DoAnChuyenNganhA
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_exit = new System.Windows.Forms.Button();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.cbx_loLai = new System.Windows.Forms.ComboBox();
            this.cbx_chiphi = new System.Windows.Forms.ComboBox();
            this.txt_giatri = new System.Windows.Forms.TextBox();
            this.btn_show = new System.Windows.Forms.Button();
            this.cbx_LoiNhuan = new System.Windows.Forms.ComboBox();
            this.lbl_data = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(355, 611);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(320, 56);
            this.btn_exit.TabIndex = 29;
            this.btn_exit.Text = "Về lại trang báo cáo";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // dgv_data
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.dgv_data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_data.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_data.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_data.EnableHeadersVisualStyles = false;
            this.dgv_data.Location = new System.Drawing.Point(51, 139);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.RowTemplate.Height = 24;
            this.dgv_data.Size = new System.Drawing.Size(923, 446);
            this.dgv_data.TabIndex = 31;
            // 
            // cbx_loLai
            // 
            this.cbx_loLai.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_loLai.FormattingEnabled = true;
            this.cbx_loLai.Location = new System.Drawing.Point(61, 71);
            this.cbx_loLai.Name = "cbx_loLai";
            this.cbx_loLai.Size = new System.Drawing.Size(167, 30);
            this.cbx_loLai.TabIndex = 32;
            // 
            // cbx_chiphi
            // 
            this.cbx_chiphi.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_chiphi.FormattingEnabled = true;
            this.cbx_chiphi.Location = new System.Drawing.Point(251, 71);
            this.cbx_chiphi.Name = "cbx_chiphi";
            this.cbx_chiphi.Size = new System.Drawing.Size(190, 30);
            this.cbx_chiphi.TabIndex = 33;
            // 
            // txt_giatri
            // 
            this.txt_giatri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giatri.Location = new System.Drawing.Point(676, 71);
            this.txt_giatri.Name = "txt_giatri";
            this.txt_giatri.Size = new System.Drawing.Size(164, 30);
            this.txt_giatri.TabIndex = 34;
            // 
            // btn_show
            // 
            this.btn_show.AutoSize = true;
            this.btn_show.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.Image = ((System.Drawing.Image)(resources.GetObject("btn_show.Image")));
            this.btn_show.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_show.Location = new System.Drawing.Point(858, 68);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(116, 40);
            this.btn_show.TabIndex = 35;
            this.btn_show.Text = "SHOW";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // cbx_LoiNhuan
            // 
            this.cbx_LoiNhuan.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_LoiNhuan.FormattingEnabled = true;
            this.cbx_LoiNhuan.Location = new System.Drawing.Point(459, 71);
            this.cbx_LoiNhuan.Name = "cbx_LoiNhuan";
            this.cbx_LoiNhuan.Size = new System.Drawing.Size(190, 30);
            this.cbx_LoiNhuan.TabIndex = 36;
            // 
            // lbl_data
            // 
            this.lbl_data.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_data.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_data.Location = new System.Drawing.Point(16, 9);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(988, 42);
            this.lbl_data.TabIndex = 37;
            this.lbl_data.Text = "Danh sách các công ty theo lợi nhuận, chi phí, lỗ lãi\r\n";
            this.lbl_data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 693);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.cbx_LoiNhuan);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.txt_giatri);
            this.Controls.Add(this.cbx_chiphi);
            this.Controls.Add(this.cbx_loLai);
            this.Controls.Add(this.dgv_data);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.ComboBox cbx_loLai;
        private System.Windows.Forms.ComboBox cbx_chiphi;
        private System.Windows.Forms.TextBox txt_giatri;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.ComboBox cbx_LoiNhuan;
        private System.Windows.Forms.Label lbl_data;
    }
}