using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;

namespace DoAnChuyenNganhA
{
    public partial class ImportData : Form
    {
        string strCon = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;

        public ImportData()
        {
            InitializeComponent();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Title = "Select File";
            f.FileName = txt_file.Text;
            f.Filter = "Excel Sheet (*.xlsx)|*.xlsx|All Files(*.*)|*.*";
            f.FilterIndex = 1;
            f.RestoreDirectory = true;
            if (f.ShowDialog() == DialogResult.OK)
            {
                txt_file.Text = f.FileName;
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            OleDbConnection dbConnection = new OleDbConnection(@"provider=Microsoft.ACE.OLEDB.12.0;data source = '" + 
                txt_file.Text + "'; Extended Properties=Excel 12.0;");

            dbConnection.Open();
            OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter("Select * from[Sheet2$]", dbConnection);
            DataSet DS = new DataSet();
            DataTable dataTable = new DataTable();
            dbDataAdapter.Fill(dataTable);
            this.dgv_data.DataSource = dataTable.DefaultView;
        }

        void fillGrid()
        {
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Imported", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_data.DataSource = dt;
            con.Close();
        }

        private void ImportData_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            for (int i=0;i<dgv_data.Rows.Count;i++)
            {
                SqlCommand cmd = new SqlCommand("insert into Imported (Nam,Quy,ThuNhapLaiRong,ThuNhapLaiVaCacKhoanThuNhap,ChiPhiLaiVaKhoanChiPhiTuongTu" +
                    ",LaiLoRongTuHDDichVu,ThuNhapTuDV,ChiPhiHoatDongDichVu,LaiLoTuKDNgoaiHoi,LaiLoTuMuaChungKhoanKD,LaiLoThuanTuMuaBanChungKhoanDauTu" +
                    ",LaiTuHoatDongKhac,ThuNhapHDKhac,ChiPhiHoatDongKhac,ThuNhapTuGopVon,TongThuNhapKD,LaiLoCongTyLienKetLienDoanh,ChiPhiHoatDong" +
                    ",ChiPhiNhanVien,ChiPhiKhauHao,ChiPhiHoatDongKhac01,LoiNhuanRongTuHDKinhDoanh,ChiPhiDuPhong,ChiPhiDuPhongRuiRoTinDung,KhoanXuLytheoCauTrucNganHang" +
                    ",DuPhongChungCacKhoanCamKetVaNo,DuPhongGiamGiaChungKhoan,ThuHoiNoDaXuLy,TongLoiNhuanKeToan,ThuNhapTuCacKhoanNo,LoiNhuanTuCacCTLienKet,TongLoiNhuanTruocThue" +
                    ",ChiPhiThueTNDN,ChiPhiThueHienThanh,ChiPhiThueHoanLai,LoiNhuanSauThue,LoiIchCoDongThieuSo,LoiNhuanSauThueCoDongCTme,LaiCoBanCoPhieu" +
                    ",LaiLoSuyGiamCoPhieu) values('"+ dgv_data.Rows[i].Cells[0].Value+ "','" + dgv_data.Rows[i].Cells[1].Value + "','" + dgv_data.Rows[i].Cells[2].Value + "','" + dgv_data.Rows[i].Cells[3].Value + "','" + dgv_data.Rows[i].Cells[4].Value + "','" + dgv_data.Rows[i].Cells[5].Value + "','" + dgv_data.Rows[i].Cells[6].Value + "','" + dgv_data.Rows[i].Cells[7].Value + "','" + dgv_data.Rows[i].Cells[8].Value + "','" + dgv_data.Rows[i].Cells[9].Value + "','" + dgv_data.Rows[i].Cells[10].Value + "','" + dgv_data.Rows[i].Cells[11].Value + "','" + dgv_data.Rows[i].Cells[12].Value + "','" + dgv_data.Rows[i].Cells[13].Value + "','" + dgv_data.Rows[i].Cells[14].Value + "','" + dgv_data.Rows[i].Cells[15].Value + "','" + dgv_data.Rows[i].Cells[16].Value + "','" + dgv_data.Rows[i].Cells[17].Value + "','" + dgv_data.Rows[i].Cells[18].Value + "','" + dgv_data.Rows[i].Cells[19].Value + "','" + dgv_data.Rows[i].Cells[20].Value + "','" + dgv_data.Rows[i].Cells[21].Value + "'," +
                    "'" + dgv_data.Rows[i].Cells[22].Value + "','" + dgv_data.Rows[i].Cells[23].Value + "','" + dgv_data.Rows[i].Cells[24].Value + "','" + dgv_data.Rows[i].Cells[25].Value + "','" + dgv_data.Rows[i].Cells[26].Value + "','" + dgv_data.Rows[i].Cells[27].Value + "','" + dgv_data.Rows[i].Cells[28].Value + "','" + dgv_data.Rows[i].Cells[29].Value + "','" + dgv_data.Rows[i].Cells[30].Value + "','" + dgv_data.Rows[i].Cells[31].Value + "','" + dgv_data.Rows[i].Cells[32].Value + "','" + dgv_data.Rows[i].Cells[33].Value + "','" + dgv_data.Rows[i].Cells[34].Value + "','" + dgv_data.Rows[i].Cells[35].Value + "','" + dgv_data.Rows[i].Cells[36].Value + "','" + dgv_data.Rows[i].Cells[37].Value + "','" + dgv_data.Rows[i].Cells[38].Value + "','" + dgv_data.Rows[i].Cells[39].Value +"')", con);
                cmd.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("Saved...");
            fillGrid();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Test2().Show();
        }
    }
}
