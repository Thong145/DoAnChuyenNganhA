using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using Newtonsoft.Json;

namespace DoAnChuyenNganhA
{
    public partial class database_admin : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "FszuRvZPyejVLF3WuuRG7a0rzwRGpXPWrCP3M28y",
            BasePath = "https://doanchuyennganha-test-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        public database_admin()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            new login().Show();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            #region draft (nháp)
            
            #region DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Chi phí dự phòng");
            dt.Columns.Add("Chi phí dự phòng rủi ro tín dụng");
            dt.Columns.Add("Chi phí hoạt động");
            dt.Columns.Add("Chi phí hoạt động dịch vụ");
            dt.Columns.Add("Chi phí hoạt động khác");
            dt.Columns.Add("Chi phí hoạt động khác_1");
            dt.Columns.Add("Chi phí khấu hao");
            dt.Columns.Add("Chi phí lãi và các khoản chi phí tương tự");
            dt.Columns.Add("Chi phí nhân viên");
            dt.Columns.Add("Chi phí thuế TNDN");
            dt.Columns.Add("Chi phí thuế hiện hành");
            dt.Columns.Add("Chi phí thuế hoãn lại");
            dt.Columns.Add("Các khoản xử lý theo đề tài cấu trúc Ngân hàng");
            dt.Columns.Add("Dự phòng chung cho các khoản cam kết và nợ tiềm tàng");
            dt.Columns.Add("Dự phòng giảm giá chứng khoán");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán đầu tư");
            dt.Columns.Add("Lãi lỗ trong công ty liên kết, liên doanh");
            dt.Columns.Add("Lãi cơ bản trên cổ phiếu");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động dịch vụ");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động kinh doanh ngoại hối và vàng");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán kinh doanh");
            dt.Columns.Add("Lãi suy giảm trên cổ phiếu");
            dt.Columns.Add("Lãi thuần từ hoạt động khác");
            dt.Columns.Add("Lợi nhuận ròng từ hoạt động kinh doanh trước chi phí dự phòng");
            dt.Columns.Add("Lợi nhuận sau thuế");
            dt.Columns.Add("Lợi nhuận sau thuế của cổ đông công ty mẹ");
            dt.Columns.Add("Lợi nhuận được hưởng từ các công ty liên kết và liên doanh");
            dt.Columns.Add("Lợi ích của cổ đông thiểu số");
            dt.Columns.Add("Năm");
            dt.Columns.Add("Quý");
            dt.Columns.Add("Thu hồi nợ đã xử lý bằng nguồn dự phòng");
            dt.Columns.Add("Thu nhập hoạt động khác");
            dt.Columns.Add("Thu nhập lãi ròng");
            dt.Columns.Add("Thu nhập lãi và các khoản thu nhập tương tự");
            dt.Columns.Add("Thu nhập từ các khoản nợ khó đòi");
            dt.Columns.Add("Thu nhập từ góp vốn, mua cổ phần");
            dt.Columns.Add("Thu nhập từ hoạt động dịch vụ");
            dt.Columns.Add("Tổng lợi nhuận kế toán");
            dt.Columns.Add("Tổng lợi nhuận trước thuế");
            dt.Columns.Add("Tổng thu nhập kinh doanh");
            #endregion

            dtg_data.Rows.Clear();
            //FirebaseResponse response = client.Get(@"Counter");
            //int Counter = int.Parse(response.ResultAs<string>());
            for(int i =0; i <= 43; i++)
            {
                FirebaseResponse res1 = client.Get("data/BIDV/" +i );
                //string n = res1.ResultAs<string>();
                //string n = i.ToString();
                //i = res1.ResultAs<int>();

                //var res2 = client.Get()
                dtg_data.AutoGenerateColumns = true;
                Data d = res1.ResultAs <Data>();
                if (d.Nam != "") // lailoTHUan = chung khoan kinh doanh, lailotumuaCK= chung khoan dau tu
                {
                    dt.Rows.Add(d.Nam, d.Quy,d.ThuNhapLaiRong, d.ThuNhapLaiVaCacKhoanThuNhap, d.ChiPhiLaiVaKhoanChiPhiTuongTu
                        , d.LaiLoRongTuHDDichVu, d.ThuNhapTuDV, d.ChiPhiHoatDongDichVu, d.LaiLoTuKDNgoaiHoi, d.LaiLoThuanTuMuaBanChungKhoanDauTu
                        , d.LaiLoTuMuaChungKhoanKD, d.LaiTuHoatDongKhac, d.ThuNhapHDKhac, d.ChiPhiHoatDongKhac, d.ThuNhapTuGopVon
                        , d.TongThuNhapKD, d.LaiLoCongTyLienKetLienDoanh, d.ChiPhiHoatDong, d.ChiPhiNhanVien, d.ChiPhiKhauHao
                        , d.ChiPhiHoatDongKhac01, d.LoiNhuanRongTuHDKinhDoanh, d.ChiPhiDuPhong, d.ChiPhiDuPhongRuiRoTinDung, d.KhoanXuLytheoCauTrucNganHang, d.DuPhongChungCacKhoanCamKetVaNo
                        , d.DuPhongGiamGiaChungKhoan, d.ThuHoiNoDaXuLy, d.TongLoiNhuanKeToan, d.ThuNhapTuCacKhoanNo, d.LoiNhuanTuCacCTLienKet, d.TongLoiNhuanTruocThue, d.ChiPhiThueTNDN
                        , d.ChiPhiThueHienThanh, d.ChiPhiThueHoanLai, d.LoiNhuanSauThue, d.LoiIchCoDongThieuSo, d.LoiNhuanSauThueCoDongCTme, d.LaiCoBanCoPhieu
                        , d.LaiLoSuyGiamCoPhieu);
                }
            }

            foreach(DataRow item in dt.Rows)
            {
                dtg_data.Rows.Add(item.ItemArray);
            }
            
            #endregion
            /*
            FirebaseResponse response = client.Get("data/BIDV/");
            Dictionary<string, Data> data = JsonConvert.DeserializeObject<Dictionary<string, Data>>(response.Body.ToString());
            PopulateDatagrid(data);
            */
        }

        void PopulateDatagrid(Dictionary<string, Data> record)
        {
            dtg_data.Rows.Clear();
            dtg_data.Columns.Clear();
            #region DataTable
            //DataTable dt = new DataTable();
            dtg_data.Columns.Add("sno", "Sno");
            dtg_data.Columns.Add("Chi phí dự phòng" , "ChiPhiDuPhong");
            dtg_data.Columns.Add("Chi phí dự phòng rủi ro tín dụng", "ChiPhiDuPhongRuiRoTinDung");
            dtg_data.Columns.Add("Chi phí hoạt động", "ChiPhiHoatDong");
            dtg_data.Columns.Add("Chi phí hoạt động dịch vụ", "ChiPhiHoatDongDichVu");
            dtg_data.Columns.Add("Chi phí hoạt động khác", "ChiPhiHoatDongKhac");
            dtg_data.Columns.Add("Chi phí hoạt động khác_1", "ChiPhiHoatDongKhac01");
            dtg_data.Columns.Add("Chi phí khấu hao", "ChiPhiKhauHao");
            dtg_data.Columns.Add("Chi phí lãi và các khoản chi phí tương tự", "ChiPhiLaiVaKhoanChiPhiTuongTu");
            dtg_data.Columns.Add("Chi phí nhân viên", "ChiPhiNhanVien");
            dtg_data.Columns.Add("Chi phí thuế TNDN", "ChiPhiThueTNDN");
            dtg_data.Columns.Add("Chi phí thuế hiện hành", "ChiPhiThueHienThanh");
            dtg_data.Columns.Add("Chi phí thuế hoãn lại", "ChiPhiThueHoanLai");
            dtg_data.Columns.Add("Các khoản xử lý theo đề tài cấu trúc Ngân hàng", "KhoanXuLytheoCauTrucNganHang");
            dtg_data.Columns.Add("Dự phòng chung cho các khoản cam kết và nợ tiềm tàng", "DuPhongChungCacKhoanCamKetVaNo");
            dtg_data.Columns.Add("Dự phòng giảm giá chứng khoán", "DuPhongGiamGiaChungKhoan");
            dtg_data.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán đầu tư", "LaiLoThuanTuMuaBanChungKhoan");
            dtg_data.Columns.Add("Lãi lỗ trong công ty liên kết, liên doanh", "LaiLoCongTyLienKetLienDoanh");
            dtg_data.Columns.Add("Lãi cơ bản trên cổ phiếu", "LaiCoBanCoPhieu");
            dtg_data.Columns.Add("Lãi lỗ ròng từ hoạt động dịch vụ", "LaiLoRongTuHDDichVu");
            dtg_data.Columns.Add("Lãi lỗ ròng từ hoạt động kinh doanh ngoại hối và vàng", "LaiLoTuKDNgoaiHoi");
            dtg_data.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán kinh doanh", "LaiLoTuMuaChungKhoan");
            dtg_data.Columns.Add("Lãi suy giảm trên cổ phiếu", "LaiLoSuyGiamCoPhieu");
            dtg_data.Columns.Add("Lãi thuần từ hoạt động khác", "LaiTuHoatDongKhac");
            dtg_data.Columns.Add("Lợi nhuận ròng từ hoạt động kinh doanh trước chi phí dự phòng", "LoiNhuanRongTuHDKinhDoanh");
            dtg_data.Columns.Add("Lợi nhuận sau thuế", "LoiNhuanSauThue");
            dtg_data.Columns.Add("Lợi nhuận sau thuế của cổ đông công ty mẹ", "LoiNhuanSauThueCoDongCTme");
            dtg_data.Columns.Add("Lợi nhuận được hưởng từ các công ty liên kết và liên doanh", "LoiNhuanTuCacCTLienKet");
            dtg_data.Columns.Add("Lợi ích của cổ đông thiểu số", "LoiIchCoDongThieuSo");
            dtg_data.Columns.Add("Năm", "Nam");
            dtg_data.Columns.Add("Quý", "Quy");
            dtg_data.Columns.Add("Thu hồi nợ đã xử lý bằng nguồn dự phòng", "ThuHoiNoDaXuLy");
            dtg_data.Columns.Add("Thu nhập hoạt động khác", "ThuNhapHDKhac");
            dtg_data.Columns.Add("Thu nhập lãi ròng", "ThuNhapLaiRong");
            dtg_data.Columns.Add("Thu nhập lãi và các khoản thu nhập tương tự", "ThuNhapLaiVaCacKhoanThuNhap");
            dtg_data.Columns.Add("Thu nhập từ các khoản nợ khó đòi", "ThuNhapTuCacKhoanNo");
            dtg_data.Columns.Add("Thu nhập từ góp vốn, mua cổ phần", "ThuNhapTuGopVon");
            dtg_data.Columns.Add("Thu nhập từ hoạt động dịch vụ", "ThuNhapTuDV");
            dtg_data.Columns.Add("Tổng lợi nhuận kế toán", "TongLoiNhuanKeToan");
            dtg_data.Columns.Add("Tổng lợi nhuận trước thuế", "TongLoiNhuanTruocThue");
            dtg_data.Columns.Add("Tổng thu nhập kinh doanh", "TongThuNhapKD");
            #endregion

            
                foreach (var item in record)
                {
                    dtg_data.Rows.Add(item.Key, item.Value.ChiPhiDuPhong, item.Value.ChiPhiDuPhongRuiRoTinDung, item.Value.ChiPhiHoatDong, item.Value.ChiPhiHoatDongDichVu, item.Value.ChiPhiHoatDongKhac
                            , item.Value.ChiPhiHoatDongKhac01, item.Value.ChiPhiKhauHao, item.Value.ChiPhiLaiVaKhoanChiPhiTuongTu, item.Value.ChiPhiNhanVien, item.Value.ChiPhiThueHienThanh
                            , item.Value.ChiPhiThueHoanLai, item.Value.ChiPhiThueTNDN, item.Value.DuPhongChungCacKhoanCamKetVaNo, item.Value.DuPhongGiamGiaChungKhoan, item.Value.KhoanXuLytheoCauTrucNganHang
                            , item.Value.LaiCoBanCoPhieu, item.Value.LaiLoCongTyLienKetLienDoanh, item.Value.LaiLoRongTuHDDichVu, item.Value.LaiLoSuyGiamCoPhieu, item.Value.LaiLoThuanTuMuaBanChungKhoanDauTu
                            , item.Value.LaiLoTuKDNgoaiHoi, item.Value.LaiLoTuMuaChungKhoanKD, item.Value.LaiTuHoatDongKhac, item.Value.LoiIchCoDongThieuSo, item.Value.LoiNhuanRongTuHDKinhDoanh, item.Value.LoiNhuanSauThue
                            , item.Value.LoiNhuanSauThueCoDongCTme, item.Value.LoiNhuanTuCacCTLienKet, item.Value.Nam, item.Value.Quy, item.Value.ThuHoiNoDaXuLy, item.Value.ThuNhapHDKhac, item.Value.ThuNhapLaiRong
                            , item.Value.ThuNhapLaiVaCacKhoanThuNhap, item.Value.ThuNhapTuCacKhoanNo, item.Value.ThuNhapTuDV, item.Value.ThuNhapTuGopVon, item.Value.TongLoiNhuanKeToan, item.Value.TongLoiNhuanTruocThue
                            , item.Value.TongThuNhapKD);
                }
            
        }

        private void database_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                //lbl_clearfields.Text = "connected";
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            new ADD().Show();
            this.Hide();
        }
        #region Json Type Test
        /*
        private void btn_json_Click(object sender, EventArgs e)
        {

            FirebaseResponse response = client.Get(@"BIDV");
            Dictionary<string, Data> data = JsonConvert.DeserializeObject<Dictionary<string, Data>>(response.Body.ToString());
            PopulateJson(data);
        }
        
        void PopulateJson(Dictionary<string, Data> record)
        {
            richTextBox1.Clear();
            foreach(var item in record)
            {
                #region richtextbox data
                richTextBox1.Text += item.Key + "\n";
                richTextBox1.Text += "Chi phí dự phòng" + item.Value.ChiPhiDuPhong + "\n";
                richTextBox1.Text += "Chi phí dự phòng rủi ro tín dụng" + item.Value.ChiPhiDuPhongRuiRoTinDung + "\n";
                richTextBox1.Text += "Chi phí hoạt động" + item.Value.ChiPhiHoatDong + "\n";
                richTextBox1.Text += "Chi phí hoạt động dịch vụ" + item.Value.ChiPhiHoatDongDichVu + "\n";
                richTextBox1.Text += "Chi phí hoạt động khác" + item.Value.ChiPhiHoatDongKhac + "\n";
                richTextBox1.Text += "Chi phí hoạt động khác_1" + item.Value.ChiPhiHoatDongKhac01 + "\n";
                richTextBox1.Text += "Chi phí khấu hao" + item.Value.ChiPhiKhauHao + "\n";
                richTextBox1.Text += "Chi phí lãi và các khoản chi phí tương tự" + item.Value.ChiPhiLaiVaKhoanChiPhiTuongTu + "\n";
                richTextBox1.Text += "Chi phí nhân viên" + item.Value.ChiPhiNhanVien + "\n";
                richTextBox1.Text += "Chi phí thuế TNDN" + item.Value.ChiPhiThueTNDN + "\n";
                richTextBox1.Text += "Chi phí thuế hiện hành" + item.Value.ChiPhiThueHienThanh + "\n";
                richTextBox1.Text += "Chi phí thuế hoãn lại" + item.Value.ChiPhiThueHoanLai + "\n";
                richTextBox1.Text += "Các khoản xử lý theo đề tài cấu trúc Ngân hàng" + item.Value.KhoanXuLytheoCauTrucNganHang + "\n";
                richTextBox1.Text += "Dự phòng chung cho các khoản cam kết và nợ tiềm tàng" + item.Value.DuPhongChungCacKhoanCamKetVaNo + "\n";
                richTextBox1.Text += "Dự phòng giảm giá chứng khoán" + item.Value.DuPhongGiamGiaChungKhoan + "\n";
                richTextBox1.Text += "Lãi lỗ thuần từ mua bán chứng khoán đầu tư" + item.Value.LaiLoThuanTuMuaBanChungKhoan + "\n";
                richTextBox1.Text += "Lãi lỗ trong công ty liên kết, liên doanh" + item.Value.LaiLoCongTyLienKetLienDoanh + "\n";
                richTextBox1.Text += "Lãi cơ bản trên cổ phiếu" + item.Value.LaiCoBanCoPhieu + "\n";
                richTextBox1.Text += "Lãi lỗ ròng từ hoạt động dịch vụ" + item.Value.LaiLoRongTuHDDichVu + "\n";
                richTextBox1.Text += "Lãi lỗ ròng từ hoạt động kinh doanh ngoại hối và vàng" + item.Value.LaiLoTuKDNgoaiHoi + "\n";
                richTextBox1.Text += "Lãi lỗ thuần từ mua bán chứng khoán kinh doanh" + item.Value.LaiLoTuMuaChungKhoan + "\n";
                richTextBox1.Text += "Lãi suy giảm trên cổ phiếu" + item.Value.LaiLoSuyGiamCoPhieu + "\n";
                richTextBox1.Text += "Lãi thuần từ hoạt động khác" + item.Value.LaiTuHoatDongKhac + "\n";
                richTextBox1.Text += "Lợi nhuận ròng từ hoạt động kinh doanh trước chi phí dự phòng" + item.Value.LoiNhuanRongTuHDKinhDoanh + "\n";
                richTextBox1.Text += "Lợi nhuận sau thuế" + item.Value.LoiNhuanSauThue + "\n";
                richTextBox1.Text += "Lợi nhuận sau thuế của cổ đông công ty mẹ" + item.Value.LoiNhuanSauThueCoDongCTme + "\n";
                richTextBox1.Text += "Lợi nhuận được hưởng từ các công ty liên kết và liên doanh" + item.Value.LoiNhuanTuCacCTLienKet + "\n";
                richTextBox1.Text += "Lợi ích của cổ đông thiểu số" + item.Value.LoiIchCoDongThieuSo + "\n";
                richTextBox1.Text += "Năm" + item.Value.Nam + "\n";
                richTextBox1.Text += "Quý" + item.Value.Quy + "\n";
                richTextBox1.Text += "Thu hồi nợ đã xử lý bằng nguồn dự phòng" + item.Value.ThuHoiNoDaXuLy + "\n";
                richTextBox1.Text += "Thu nhập hoạt động khác" + item.Value.ThuNhapHDKhac + "\n";
                richTextBox1.Text += "Thu nhập lãi ròng" + item.Value.ThuNhapLaiRong + "\n";
                richTextBox1.Text += "Thu nhập lãi và các khoản thu nhập tương tự" + item.Value.ThuNhapLaiVaCacKhoanThuNhap + "\n";
                richTextBox1.Text += "Thu nhập từ các khoản nợ khó đòi" + item.Value.ThuNhapTuCacKhoanNo + "\n";
                richTextBox1.Text += "Thu nhập từ góp vốn, mua cổ phần" + item.Value.ThuNhapTuGopVon + "\n";
                richTextBox1.Text += "Thu nhập từ hoạt động dịch vụ" + item.Value.ThuNhapTuDV + "\n";
                richTextBox1.Text += "Tổng lợi nhuận kế toán" + item.Value.TongLoiNhuanKeToan + "\n";
                richTextBox1.Text += "Tổng lợi nhuận trước thuế" + item.Value.TongLoiNhuanTruocThue + "\n";
                richTextBox1.Text += "Tổng thu nhập kinh doanh" + item.Value.TongThuNhapKD + "\n";
                #endregion

            }
        }*/
        #endregion

        private void btn_fpt_Click(object sender, EventArgs e)
        {
            #region DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Chi phí dự phòng");
            dt.Columns.Add("Chi phí dự phòng rủi ro tín dụng");
            dt.Columns.Add("Chi phí hoạt động");
            dt.Columns.Add("Chi phí hoạt động dịch vụ");
            dt.Columns.Add("Chi phí hoạt động khác");
            dt.Columns.Add("Chi phí hoạt động khác_1");
            dt.Columns.Add("Chi phí khấu hao");
            dt.Columns.Add("Chi phí lãi và các khoản chi phí tương tự");
            dt.Columns.Add("Chi phí nhân viên");
            dt.Columns.Add("Chi phí thuế TNDN");
            dt.Columns.Add("Chi phí thuế hiện hành");
            dt.Columns.Add("Chi phí thuế hoãn lại");
            dt.Columns.Add("Các khoản xử lý theo đề tài cấu trúc Ngân hàng");
            dt.Columns.Add("Dự phòng chung cho các khoản cam kết và nợ tiềm tàng");
            dt.Columns.Add("Dự phòng giảm giá chứng khoán");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán đầu tư");
            dt.Columns.Add("Lãi lỗ trong công ty liên kết, liên doanh");
            dt.Columns.Add("Lãi cơ bản trên cổ phiếu");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động dịch vụ");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động kinh doanh ngoại hối và vàng");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán kinh doanh");
            dt.Columns.Add("Lãi suy giảm trên cổ phiếu");
            dt.Columns.Add("Lãi thuần từ hoạt động khác");
            dt.Columns.Add("Lợi nhuận ròng từ hoạt động kinh doanh trước chi phí dự phòng");
            dt.Columns.Add("Lợi nhuận sau thuế");
            dt.Columns.Add("Lợi nhuận sau thuế của cổ đông công ty mẹ");
            dt.Columns.Add("Lợi nhuận được hưởng từ các công ty liên kết và liên doanh");
            dt.Columns.Add("Lợi ích của cổ đông thiểu số");
            dt.Columns.Add("Năm");
            dt.Columns.Add("Quý");
            dt.Columns.Add("Thu hồi nợ đã xử lý bằng nguồn dự phòng");
            dt.Columns.Add("Thu nhập hoạt động khác");
            dt.Columns.Add("Thu nhập lãi ròng");
            dt.Columns.Add("Thu nhập lãi và các khoản thu nhập tương tự");
            dt.Columns.Add("Thu nhập từ các khoản nợ khó đòi");
            dt.Columns.Add("Thu nhập từ góp vốn, mua cổ phần");
            dt.Columns.Add("Thu nhập từ hoạt động dịch vụ");
            dt.Columns.Add("Tổng lợi nhuận kế toán");
            dt.Columns.Add("Tổng lợi nhuận trước thuế");
            dt.Columns.Add("Tổng thu nhập kinh doanh");
            #endregion

            dtg_data.Rows.Clear();
            //FirebaseResponse response = client.Get(@"Counter");
            //int Counter = int.Parse(response.ResultAs<string>());
            for (int i = 0; i <= 43; i++)
            {
                FirebaseResponse res1 = client.Get("data/FPT/" + i);
                //string n = res1.ResultAs<string>();
                //string n = i.ToString();
                //i = res1.ResultAs<int>();

                //var res2 = client.Get()
                dtg_data.AutoGenerateColumns = true;
                Data d = res1.ResultAs<Data>();
                if (d.Nam != "") // lailoTHUan = chung khoan kinh doanh, lailotumuaCK= chung khoan dau tu
                {
                    dt.Rows.Add(d.Nam, d.Quy, d.ThuNhapLaiRong, d.ThuNhapLaiVaCacKhoanThuNhap, d.ChiPhiLaiVaKhoanChiPhiTuongTu
                        , d.LaiLoRongTuHDDichVu, d.ThuNhapTuDV, d.ChiPhiHoatDongDichVu, d.LaiLoTuKDNgoaiHoi, d.LaiLoThuanTuMuaBanChungKhoanDauTu
                        , d.LaiLoTuMuaChungKhoanKD, d.LaiTuHoatDongKhac, d.ThuNhapHDKhac, d.ChiPhiHoatDongKhac, d.ThuNhapTuGopVon
                        , d.TongThuNhapKD, d.LaiLoCongTyLienKetLienDoanh, d.ChiPhiHoatDong, d.ChiPhiNhanVien, d.ChiPhiKhauHao
                        , d.ChiPhiHoatDongKhac01, d.LoiNhuanRongTuHDKinhDoanh, d.ChiPhiDuPhong, d.ChiPhiDuPhongRuiRoTinDung, d.KhoanXuLytheoCauTrucNganHang, d.DuPhongChungCacKhoanCamKetVaNo
                        , d.DuPhongGiamGiaChungKhoan, d.ThuHoiNoDaXuLy, d.TongLoiNhuanKeToan, d.ThuNhapTuCacKhoanNo, d.LoiNhuanTuCacCTLienKet, d.TongLoiNhuanTruocThue, d.ChiPhiThueTNDN
                        , d.ChiPhiThueHienThanh, d.ChiPhiThueHoanLai, d.LoiNhuanSauThue, d.LoiIchCoDongThieuSo, d.LoiNhuanSauThueCoDongCTme, d.LaiCoBanCoPhieu
                        , d.LaiLoSuyGiamCoPhieu);
                }
            }

            foreach (DataRow item in dt.Rows)
            {
                dtg_data.Rows.Add(item.ItemArray);
            }
        }

        private void btn_mbb_Click(object sender, EventArgs e)
        {
            #region DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Chi phí dự phòng");
            dt.Columns.Add("Chi phí dự phòng rủi ro tín dụng");
            dt.Columns.Add("Chi phí hoạt động");
            dt.Columns.Add("Chi phí hoạt động dịch vụ");
            dt.Columns.Add("Chi phí hoạt động khác");
            dt.Columns.Add("Chi phí hoạt động khác_1");
            dt.Columns.Add("Chi phí khấu hao");
            dt.Columns.Add("Chi phí lãi và các khoản chi phí tương tự");
            dt.Columns.Add("Chi phí nhân viên");
            dt.Columns.Add("Chi phí thuế TNDN");
            dt.Columns.Add("Chi phí thuế hiện hành");
            dt.Columns.Add("Chi phí thuế hoãn lại");
            dt.Columns.Add("Các khoản xử lý theo đề tài cấu trúc Ngân hàng");
            dt.Columns.Add("Dự phòng chung cho các khoản cam kết và nợ tiềm tàng");
            dt.Columns.Add("Dự phòng giảm giá chứng khoán");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán đầu tư");
            dt.Columns.Add("Lãi lỗ trong công ty liên kết, liên doanh");
            dt.Columns.Add("Lãi cơ bản trên cổ phiếu");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động dịch vụ");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động kinh doanh ngoại hối và vàng");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán kinh doanh");
            dt.Columns.Add("Lãi suy giảm trên cổ phiếu");
            dt.Columns.Add("Lãi thuần từ hoạt động khác");
            dt.Columns.Add("Lợi nhuận ròng từ hoạt động kinh doanh trước chi phí dự phòng");
            dt.Columns.Add("Lợi nhuận sau thuế");
            dt.Columns.Add("Lợi nhuận sau thuế của cổ đông công ty mẹ");
            dt.Columns.Add("Lợi nhuận được hưởng từ các công ty liên kết và liên doanh");
            dt.Columns.Add("Lợi ích của cổ đông thiểu số");
            dt.Columns.Add("Năm");
            dt.Columns.Add("Quý");
            dt.Columns.Add("Thu hồi nợ đã xử lý bằng nguồn dự phòng");
            dt.Columns.Add("Thu nhập hoạt động khác");
            dt.Columns.Add("Thu nhập lãi ròng");
            dt.Columns.Add("Thu nhập lãi và các khoản thu nhập tương tự");
            dt.Columns.Add("Thu nhập từ các khoản nợ khó đòi");
            dt.Columns.Add("Thu nhập từ góp vốn, mua cổ phần");
            dt.Columns.Add("Thu nhập từ hoạt động dịch vụ");
            dt.Columns.Add("Tổng lợi nhuận kế toán");
            dt.Columns.Add("Tổng lợi nhuận trước thuế");
            dt.Columns.Add("Tổng thu nhập kinh doanh");
            #endregion

            dtg_data.Rows.Clear();
            //FirebaseResponse response = client.Get(@"Counter");
            //int Counter = int.Parse(response.ResultAs<string>());
            for (int i = 0; i <= 43; i++)
            {
                FirebaseResponse res1 = client.Get("data/MB Bank/" + i);
                //string n = res1.ResultAs<string>();
                //string n = i.ToString();
                //i = res1.ResultAs<int>();

                //var res2 = client.Get()
                dtg_data.AutoGenerateColumns = true;
                Data d = res1.ResultAs<Data>();
                if (d.Nam != "") // lailoTHUan = chung khoan kinh doanh, lailotumuaCK= chung khoan dau tu
                {
                    dt.Rows.Add(d.Nam, d.Quy, d.ThuNhapLaiRong, d.ThuNhapLaiVaCacKhoanThuNhap, d.ChiPhiLaiVaKhoanChiPhiTuongTu
                        , d.LaiLoRongTuHDDichVu, d.ThuNhapTuDV, d.ChiPhiHoatDongDichVu, d.LaiLoTuKDNgoaiHoi, d.LaiLoThuanTuMuaBanChungKhoanDauTu
                        , d.LaiLoTuMuaChungKhoanKD, d.LaiTuHoatDongKhac, d.ThuNhapHDKhac, d.ChiPhiHoatDongKhac, d.ThuNhapTuGopVon
                        , d.TongThuNhapKD, d.LaiLoCongTyLienKetLienDoanh, d.ChiPhiHoatDong, d.ChiPhiNhanVien, d.ChiPhiKhauHao
                        , d.ChiPhiHoatDongKhac01, d.LoiNhuanRongTuHDKinhDoanh, d.ChiPhiDuPhong, d.ChiPhiDuPhongRuiRoTinDung, d.KhoanXuLytheoCauTrucNganHang, d.DuPhongChungCacKhoanCamKetVaNo
                        , d.DuPhongGiamGiaChungKhoan, d.ThuHoiNoDaXuLy, d.TongLoiNhuanKeToan, d.ThuNhapTuCacKhoanNo, d.LoiNhuanTuCacCTLienKet, d.TongLoiNhuanTruocThue, d.ChiPhiThueTNDN
                        , d.ChiPhiThueHienThanh, d.ChiPhiThueHoanLai, d.LoiNhuanSauThue, d.LoiIchCoDongThieuSo, d.LoiNhuanSauThueCoDongCTme, d.LaiCoBanCoPhieu
                        , d.LaiLoSuyGiamCoPhieu);
                }
            }

            foreach (DataRow item in dt.Rows)
            {
                dtg_data.Rows.Add(item.ItemArray);
            }
        }

        private void btn_ocb_Click(object sender, EventArgs e)
        {
            #region DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Chi phí dự phòng");
            dt.Columns.Add("Chi phí dự phòng rủi ro tín dụng");
            dt.Columns.Add("Chi phí hoạt động");
            dt.Columns.Add("Chi phí hoạt động dịch vụ");
            dt.Columns.Add("Chi phí hoạt động khác");
            dt.Columns.Add("Chi phí hoạt động khác_1");
            dt.Columns.Add("Chi phí khấu hao");
            dt.Columns.Add("Chi phí lãi và các khoản chi phí tương tự");
            dt.Columns.Add("Chi phí nhân viên");
            dt.Columns.Add("Chi phí thuế TNDN");
            dt.Columns.Add("Chi phí thuế hiện hành");
            dt.Columns.Add("Chi phí thuế hoãn lại");
            dt.Columns.Add("Các khoản xử lý theo đề tài cấu trúc Ngân hàng");
            dt.Columns.Add("Dự phòng chung cho các khoản cam kết và nợ tiềm tàng");
            dt.Columns.Add("Dự phòng giảm giá chứng khoán");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán đầu tư");
            dt.Columns.Add("Lãi lỗ trong công ty liên kết, liên doanh");
            dt.Columns.Add("Lãi cơ bản trên cổ phiếu");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động dịch vụ");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động kinh doanh ngoại hối và vàng");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán kinh doanh");
            dt.Columns.Add("Lãi suy giảm trên cổ phiếu");
            dt.Columns.Add("Lãi thuần từ hoạt động khác");
            dt.Columns.Add("Lợi nhuận ròng từ hoạt động kinh doanh trước chi phí dự phòng");
            dt.Columns.Add("Lợi nhuận sau thuế");
            dt.Columns.Add("Lợi nhuận sau thuế của cổ đông công ty mẹ");
            dt.Columns.Add("Lợi nhuận được hưởng từ các công ty liên kết và liên doanh");
            dt.Columns.Add("Lợi ích của cổ đông thiểu số");
            dt.Columns.Add("Năm");
            dt.Columns.Add("Quý");
            dt.Columns.Add("Thu hồi nợ đã xử lý bằng nguồn dự phòng");
            dt.Columns.Add("Thu nhập hoạt động khác");
            dt.Columns.Add("Thu nhập lãi ròng");
            dt.Columns.Add("Thu nhập lãi và các khoản thu nhập tương tự");
            dt.Columns.Add("Thu nhập từ các khoản nợ khó đòi");
            dt.Columns.Add("Thu nhập từ góp vốn, mua cổ phần");
            dt.Columns.Add("Thu nhập từ hoạt động dịch vụ");
            dt.Columns.Add("Tổng lợi nhuận kế toán");
            dt.Columns.Add("Tổng lợi nhuận trước thuế");
            dt.Columns.Add("Tổng thu nhập kinh doanh");
            #endregion

            dtg_data.Rows.Clear();
            //FirebaseResponse response = client.Get(@"Counter");
            //int Counter = int.Parse(response.ResultAs<string>());
            for (int i = 0; i <= 43; i++)
            {
                FirebaseResponse res1 = client.Get("data/OCB Bank/" + i);
                //string n = res1.ResultAs<string>();
                //string n = i.ToString();
                //i = res1.ResultAs<int>();

                //var res2 = client.Get()
                dtg_data.AutoGenerateColumns = true;
                Data d = res1.ResultAs<Data>();
                if (d.Nam != "") // lailoTHUan = chung khoan kinh doanh, lailotumuaCK= chung khoan dau tu
                {
                    dt.Rows.Add(d.Nam, d.Quy, d.ThuNhapLaiRong, d.ThuNhapLaiVaCacKhoanThuNhap, d.ChiPhiLaiVaKhoanChiPhiTuongTu
                        , d.LaiLoRongTuHDDichVu, d.ThuNhapTuDV, d.ChiPhiHoatDongDichVu, d.LaiLoTuKDNgoaiHoi, d.LaiLoThuanTuMuaBanChungKhoanDauTu
                        , d.LaiLoTuMuaChungKhoanKD, d.LaiTuHoatDongKhac, d.ThuNhapHDKhac, d.ChiPhiHoatDongKhac, d.ThuNhapTuGopVon
                        , d.TongThuNhapKD, d.LaiLoCongTyLienKetLienDoanh, d.ChiPhiHoatDong, d.ChiPhiNhanVien, d.ChiPhiKhauHao
                        , d.ChiPhiHoatDongKhac01, d.LoiNhuanRongTuHDKinhDoanh, d.ChiPhiDuPhong, d.ChiPhiDuPhongRuiRoTinDung, d.KhoanXuLytheoCauTrucNganHang, d.DuPhongChungCacKhoanCamKetVaNo
                        , d.DuPhongGiamGiaChungKhoan, d.ThuHoiNoDaXuLy, d.TongLoiNhuanKeToan, d.ThuNhapTuCacKhoanNo, d.LoiNhuanTuCacCTLienKet, d.TongLoiNhuanTruocThue, d.ChiPhiThueTNDN
                        , d.ChiPhiThueHienThanh, d.ChiPhiThueHoanLai, d.LoiNhuanSauThue, d.LoiIchCoDongThieuSo, d.LoiNhuanSauThueCoDongCTme, d.LaiCoBanCoPhieu
                        , d.LaiLoSuyGiamCoPhieu);
                }
            }

            foreach (DataRow item in dt.Rows)
            {
                dtg_data.Rows.Add(item.ItemArray);
            }
        }

        private void btn_scb_Click(object sender, EventArgs e)
        {
            #region DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Chi phí dự phòng");
            dt.Columns.Add("Chi phí dự phòng rủi ro tín dụng");
            dt.Columns.Add("Chi phí hoạt động");
            dt.Columns.Add("Chi phí hoạt động dịch vụ");
            dt.Columns.Add("Chi phí hoạt động khác");
            dt.Columns.Add("Chi phí hoạt động khác_1");
            dt.Columns.Add("Chi phí khấu hao");
            dt.Columns.Add("Chi phí lãi và các khoản chi phí tương tự");
            dt.Columns.Add("Chi phí nhân viên");
            dt.Columns.Add("Chi phí thuế TNDN");
            dt.Columns.Add("Chi phí thuế hiện hành");
            dt.Columns.Add("Chi phí thuế hoãn lại");
            dt.Columns.Add("Các khoản xử lý theo đề tài cấu trúc Ngân hàng");
            dt.Columns.Add("Dự phòng chung cho các khoản cam kết và nợ tiềm tàng");
            dt.Columns.Add("Dự phòng giảm giá chứng khoán");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán đầu tư");
            dt.Columns.Add("Lãi lỗ trong công ty liên kết, liên doanh");
            dt.Columns.Add("Lãi cơ bản trên cổ phiếu");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động dịch vụ");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động kinh doanh ngoại hối và vàng");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán kinh doanh");
            dt.Columns.Add("Lãi suy giảm trên cổ phiếu");
            dt.Columns.Add("Lãi thuần từ hoạt động khác");
            dt.Columns.Add("Lợi nhuận ròng từ hoạt động kinh doanh trước chi phí dự phòng");
            dt.Columns.Add("Lợi nhuận sau thuế");
            dt.Columns.Add("Lợi nhuận sau thuế của cổ đông công ty mẹ");
            dt.Columns.Add("Lợi nhuận được hưởng từ các công ty liên kết và liên doanh");
            dt.Columns.Add("Lợi ích của cổ đông thiểu số");
            dt.Columns.Add("Năm");
            dt.Columns.Add("Quý");
            dt.Columns.Add("Thu hồi nợ đã xử lý bằng nguồn dự phòng");
            dt.Columns.Add("Thu nhập hoạt động khác");
            dt.Columns.Add("Thu nhập lãi ròng");
            dt.Columns.Add("Thu nhập lãi và các khoản thu nhập tương tự");
            dt.Columns.Add("Thu nhập từ các khoản nợ khó đòi");
            dt.Columns.Add("Thu nhập từ góp vốn, mua cổ phần");
            dt.Columns.Add("Thu nhập từ hoạt động dịch vụ");
            dt.Columns.Add("Tổng lợi nhuận kế toán");
            dt.Columns.Add("Tổng lợi nhuận trước thuế");
            dt.Columns.Add("Tổng thu nhập kinh doanh");
            #endregion

            dtg_data.Rows.Clear();
            //FirebaseResponse response = client.Get(@"Counter");
            //int Counter = int.Parse(response.ResultAs<string>());
            for (int i = 0; i <= 43; i++)
            {
                FirebaseResponse res1 = client.Get("data/SCB/" + i);
                //string n = res1.ResultAs<string>();
                //string n = i.ToString();
                //i = res1.ResultAs<int>();

                //var res2 = client.Get()
                dtg_data.AutoGenerateColumns = true;
                Data d = res1.ResultAs<Data>();
                if (d.Nam != "") // lailoTHUan = chung khoan kinh doanh, lailotumuaCK= chung khoan dau tu
                {
                    dt.Rows.Add(d.Nam, d.Quy, d.ThuNhapLaiRong, d.ThuNhapLaiVaCacKhoanThuNhap, d.ChiPhiLaiVaKhoanChiPhiTuongTu
                        , d.LaiLoRongTuHDDichVu, d.ThuNhapTuDV, d.ChiPhiHoatDongDichVu, d.LaiLoTuKDNgoaiHoi, d.LaiLoThuanTuMuaBanChungKhoanDauTu
                        , d.LaiLoTuMuaChungKhoanKD, d.LaiTuHoatDongKhac, d.ThuNhapHDKhac, d.ChiPhiHoatDongKhac, d.ThuNhapTuGopVon
                        , d.TongThuNhapKD, d.LaiLoCongTyLienKetLienDoanh, d.ChiPhiHoatDong, d.ChiPhiNhanVien, d.ChiPhiKhauHao
                        , d.ChiPhiHoatDongKhac01, d.LoiNhuanRongTuHDKinhDoanh, d.ChiPhiDuPhong, d.ChiPhiDuPhongRuiRoTinDung, d.KhoanXuLytheoCauTrucNganHang, d.DuPhongChungCacKhoanCamKetVaNo
                        , d.DuPhongGiamGiaChungKhoan, d.ThuHoiNoDaXuLy, d.TongLoiNhuanKeToan, d.ThuNhapTuCacKhoanNo, d.LoiNhuanTuCacCTLienKet, d.TongLoiNhuanTruocThue, d.ChiPhiThueTNDN
                        , d.ChiPhiThueHienThanh, d.ChiPhiThueHoanLai, d.LoiNhuanSauThue, d.LoiIchCoDongThieuSo, d.LoiNhuanSauThueCoDongCTme, d.LaiCoBanCoPhieu
                        , d.LaiLoSuyGiamCoPhieu);
                }
            }

            foreach (DataRow item in dt.Rows)
            {
                dtg_data.Rows.Add(item.ItemArray);
            }
        }

        private void btn_techcom_Click(object sender, EventArgs e)
        {
            #region DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Chi phí dự phòng");
            dt.Columns.Add("Chi phí dự phòng rủi ro tín dụng");
            dt.Columns.Add("Chi phí hoạt động");
            dt.Columns.Add("Chi phí hoạt động dịch vụ");
            dt.Columns.Add("Chi phí hoạt động khác");
            dt.Columns.Add("Chi phí hoạt động khác_1");
            dt.Columns.Add("Chi phí khấu hao");
            dt.Columns.Add("Chi phí lãi và các khoản chi phí tương tự");
            dt.Columns.Add("Chi phí nhân viên");
            dt.Columns.Add("Chi phí thuế TNDN");
            dt.Columns.Add("Chi phí thuế hiện hành");
            dt.Columns.Add("Chi phí thuế hoãn lại");
            dt.Columns.Add("Các khoản xử lý theo đề tài cấu trúc Ngân hàng");
            dt.Columns.Add("Dự phòng chung cho các khoản cam kết và nợ tiềm tàng");
            dt.Columns.Add("Dự phòng giảm giá chứng khoán");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán đầu tư");
            dt.Columns.Add("Lãi lỗ trong công ty liên kết, liên doanh");
            dt.Columns.Add("Lãi cơ bản trên cổ phiếu");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động dịch vụ");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động kinh doanh ngoại hối và vàng");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán kinh doanh");
            dt.Columns.Add("Lãi suy giảm trên cổ phiếu");
            dt.Columns.Add("Lãi thuần từ hoạt động khác");
            dt.Columns.Add("Lợi nhuận ròng từ hoạt động kinh doanh trước chi phí dự phòng");
            dt.Columns.Add("Lợi nhuận sau thuế");
            dt.Columns.Add("Lợi nhuận sau thuế của cổ đông công ty mẹ");
            dt.Columns.Add("Lợi nhuận được hưởng từ các công ty liên kết và liên doanh");
            dt.Columns.Add("Lợi ích của cổ đông thiểu số");
            dt.Columns.Add("Năm");
            dt.Columns.Add("Quý");
            dt.Columns.Add("Thu hồi nợ đã xử lý bằng nguồn dự phòng");
            dt.Columns.Add("Thu nhập hoạt động khác");
            dt.Columns.Add("Thu nhập lãi ròng");
            dt.Columns.Add("Thu nhập lãi và các khoản thu nhập tương tự");
            dt.Columns.Add("Thu nhập từ các khoản nợ khó đòi");
            dt.Columns.Add("Thu nhập từ góp vốn, mua cổ phần");
            dt.Columns.Add("Thu nhập từ hoạt động dịch vụ");
            dt.Columns.Add("Tổng lợi nhuận kế toán");
            dt.Columns.Add("Tổng lợi nhuận trước thuế");
            dt.Columns.Add("Tổng thu nhập kinh doanh");
            #endregion

            dtg_data.Rows.Clear();
            //FirebaseResponse response = client.Get(@"Counter");
            //int Counter = int.Parse(response.ResultAs<string>());
            for (int i = 0; i <= 43; i++)
            {
                FirebaseResponse res1 = client.Get("data/Techcom Bank/" + i);
                //string n = res1.ResultAs<string>();
                //string n = i.ToString();
                //i = res1.ResultAs<int>();

                //var res2 = client.Get()
                dtg_data.AutoGenerateColumns = true;
                Data d = res1.ResultAs<Data>();
                if (d.Nam != "") // lailoTHUan = chung khoan kinh doanh, lailotumuaCK= chung khoan dau tu
                {
                    dt.Rows.Add(d.Nam, d.Quy, d.ThuNhapLaiRong, d.ThuNhapLaiVaCacKhoanThuNhap, d.ChiPhiLaiVaKhoanChiPhiTuongTu
                        , d.LaiLoRongTuHDDichVu, d.ThuNhapTuDV, d.ChiPhiHoatDongDichVu, d.LaiLoTuKDNgoaiHoi, d.LaiLoThuanTuMuaBanChungKhoanDauTu
                        , d.LaiLoTuMuaChungKhoanKD, d.LaiTuHoatDongKhac, d.ThuNhapHDKhac, d.ChiPhiHoatDongKhac, d.ThuNhapTuGopVon
                        , d.TongThuNhapKD, d.LaiLoCongTyLienKetLienDoanh, d.ChiPhiHoatDong, d.ChiPhiNhanVien, d.ChiPhiKhauHao
                        , d.ChiPhiHoatDongKhac01, d.LoiNhuanRongTuHDKinhDoanh, d.ChiPhiDuPhong, d.ChiPhiDuPhongRuiRoTinDung, d.KhoanXuLytheoCauTrucNganHang, d.DuPhongChungCacKhoanCamKetVaNo
                        , d.DuPhongGiamGiaChungKhoan, d.ThuHoiNoDaXuLy, d.TongLoiNhuanKeToan, d.ThuNhapTuCacKhoanNo, d.LoiNhuanTuCacCTLienKet, d.TongLoiNhuanTruocThue, d.ChiPhiThueTNDN
                        , d.ChiPhiThueHienThanh, d.ChiPhiThueHoanLai, d.LoiNhuanSauThue, d.LoiIchCoDongThieuSo, d.LoiNhuanSauThueCoDongCTme, d.LaiCoBanCoPhieu
                        , d.LaiLoSuyGiamCoPhieu);
                }
            }

            foreach (DataRow item in dt.Rows)
            {
                dtg_data.Rows.Add(item.ItemArray);
            }
        }

        private void btn_vp_Click(object sender, EventArgs e)
        {
            #region DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Chi phí dự phòng");
            dt.Columns.Add("Chi phí dự phòng rủi ro tín dụng");
            dt.Columns.Add("Chi phí hoạt động");
            dt.Columns.Add("Chi phí hoạt động dịch vụ");
            dt.Columns.Add("Chi phí hoạt động khác");
            dt.Columns.Add("Chi phí hoạt động khác_1");
            dt.Columns.Add("Chi phí khấu hao");
            dt.Columns.Add("Chi phí lãi và các khoản chi phí tương tự");
            dt.Columns.Add("Chi phí nhân viên");
            dt.Columns.Add("Chi phí thuế TNDN");
            dt.Columns.Add("Chi phí thuế hiện hành");
            dt.Columns.Add("Chi phí thuế hoãn lại");
            dt.Columns.Add("Các khoản xử lý theo đề tài cấu trúc Ngân hàng");
            dt.Columns.Add("Dự phòng chung cho các khoản cam kết và nợ tiềm tàng");
            dt.Columns.Add("Dự phòng giảm giá chứng khoán");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán đầu tư");
            dt.Columns.Add("Lãi lỗ trong công ty liên kết, liên doanh");
            dt.Columns.Add("Lãi cơ bản trên cổ phiếu");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động dịch vụ");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động kinh doanh ngoại hối và vàng");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán kinh doanh");
            dt.Columns.Add("Lãi suy giảm trên cổ phiếu");
            dt.Columns.Add("Lãi thuần từ hoạt động khác");
            dt.Columns.Add("Lợi nhuận ròng từ hoạt động kinh doanh trước chi phí dự phòng");
            dt.Columns.Add("Lợi nhuận sau thuế");
            dt.Columns.Add("Lợi nhuận sau thuế của cổ đông công ty mẹ");
            dt.Columns.Add("Lợi nhuận được hưởng từ các công ty liên kết và liên doanh");
            dt.Columns.Add("Lợi ích của cổ đông thiểu số");
            dt.Columns.Add("Năm");
            dt.Columns.Add("Quý");
            dt.Columns.Add("Thu hồi nợ đã xử lý bằng nguồn dự phòng");
            dt.Columns.Add("Thu nhập hoạt động khác");
            dt.Columns.Add("Thu nhập lãi ròng");
            dt.Columns.Add("Thu nhập lãi và các khoản thu nhập tương tự");
            dt.Columns.Add("Thu nhập từ các khoản nợ khó đòi");
            dt.Columns.Add("Thu nhập từ góp vốn, mua cổ phần");
            dt.Columns.Add("Thu nhập từ hoạt động dịch vụ");
            dt.Columns.Add("Tổng lợi nhuận kế toán");
            dt.Columns.Add("Tổng lợi nhuận trước thuế");
            dt.Columns.Add("Tổng thu nhập kinh doanh");
            #endregion

            dtg_data.Rows.Clear();
            //FirebaseResponse response = client.Get(@"Counter");
            //int Counter = int.Parse(response.ResultAs<string>());
            for (int i = 0; i <= 43; i++)
            {
                FirebaseResponse res1 = client.Get("data/VP Bank/" + i);
                //string n = res1.ResultAs<string>();
                //string n = i.ToString();
                //i = res1.ResultAs<int>();

                //var res2 = client.Get()
                dtg_data.AutoGenerateColumns = true;
                Data d = res1.ResultAs<Data>();
                if (d.Nam != "") // lailoTHUan = chung khoan kinh doanh, lailotumuaCK= chung khoan dau tu
                {
                    dt.Rows.Add(d.Nam, d.Quy, d.ThuNhapLaiRong, d.ThuNhapLaiVaCacKhoanThuNhap, d.ChiPhiLaiVaKhoanChiPhiTuongTu
                        , d.LaiLoRongTuHDDichVu, d.ThuNhapTuDV, d.ChiPhiHoatDongDichVu, d.LaiLoTuKDNgoaiHoi, d.LaiLoThuanTuMuaBanChungKhoanDauTu
                        , d.LaiLoTuMuaChungKhoanKD, d.LaiTuHoatDongKhac, d.ThuNhapHDKhac, d.ChiPhiHoatDongKhac, d.ThuNhapTuGopVon
                        , d.TongThuNhapKD, d.LaiLoCongTyLienKetLienDoanh, d.ChiPhiHoatDong, d.ChiPhiNhanVien, d.ChiPhiKhauHao
                        , d.ChiPhiHoatDongKhac01, d.LoiNhuanRongTuHDKinhDoanh, d.ChiPhiDuPhong, d.ChiPhiDuPhongRuiRoTinDung, d.KhoanXuLytheoCauTrucNganHang, d.DuPhongChungCacKhoanCamKetVaNo
                        , d.DuPhongGiamGiaChungKhoan, d.ThuHoiNoDaXuLy, d.TongLoiNhuanKeToan, d.ThuNhapTuCacKhoanNo, d.LoiNhuanTuCacCTLienKet, d.TongLoiNhuanTruocThue, d.ChiPhiThueTNDN
                        , d.ChiPhiThueHienThanh, d.ChiPhiThueHoanLai, d.LoiNhuanSauThue, d.LoiIchCoDongThieuSo, d.LoiNhuanSauThueCoDongCTme, d.LaiCoBanCoPhieu
                        , d.LaiLoSuyGiamCoPhieu);
                }
            }

            foreach (DataRow item in dt.Rows)
            {
                dtg_data.Rows.Add(item.ItemArray);
            }
        }

        private void btn_vietcom_Click(object sender, EventArgs e)
        {
            #region DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Chi phí dự phòng");
            dt.Columns.Add("Chi phí dự phòng rủi ro tín dụng");
            dt.Columns.Add("Chi phí hoạt động");
            dt.Columns.Add("Chi phí hoạt động dịch vụ");
            dt.Columns.Add("Chi phí hoạt động khác");
            dt.Columns.Add("Chi phí hoạt động khác_1");
            dt.Columns.Add("Chi phí khấu hao");
            dt.Columns.Add("Chi phí lãi và các khoản chi phí tương tự");
            dt.Columns.Add("Chi phí nhân viên");
            dt.Columns.Add("Chi phí thuế TNDN");
            dt.Columns.Add("Chi phí thuế hiện hành");
            dt.Columns.Add("Chi phí thuế hoãn lại");
            dt.Columns.Add("Các khoản xử lý theo đề tài cấu trúc Ngân hàng");
            dt.Columns.Add("Dự phòng chung cho các khoản cam kết và nợ tiềm tàng");
            dt.Columns.Add("Dự phòng giảm giá chứng khoán");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán đầu tư");
            dt.Columns.Add("Lãi lỗ trong công ty liên kết, liên doanh");
            dt.Columns.Add("Lãi cơ bản trên cổ phiếu");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động dịch vụ");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động kinh doanh ngoại hối và vàng");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán kinh doanh");
            dt.Columns.Add("Lãi suy giảm trên cổ phiếu");
            dt.Columns.Add("Lãi thuần từ hoạt động khác");
            dt.Columns.Add("Lợi nhuận ròng từ hoạt động kinh doanh trước chi phí dự phòng");
            dt.Columns.Add("Lợi nhuận sau thuế");
            dt.Columns.Add("Lợi nhuận sau thuế của cổ đông công ty mẹ");
            dt.Columns.Add("Lợi nhuận được hưởng từ các công ty liên kết và liên doanh");
            dt.Columns.Add("Lợi ích của cổ đông thiểu số");
            dt.Columns.Add("Năm");
            dt.Columns.Add("Quý");
            dt.Columns.Add("Thu hồi nợ đã xử lý bằng nguồn dự phòng");
            dt.Columns.Add("Thu nhập hoạt động khác");
            dt.Columns.Add("Thu nhập lãi ròng");
            dt.Columns.Add("Thu nhập lãi và các khoản thu nhập tương tự");
            dt.Columns.Add("Thu nhập từ các khoản nợ khó đòi");
            dt.Columns.Add("Thu nhập từ góp vốn, mua cổ phần");
            dt.Columns.Add("Thu nhập từ hoạt động dịch vụ");
            dt.Columns.Add("Tổng lợi nhuận kế toán");
            dt.Columns.Add("Tổng lợi nhuận trước thuế");
            dt.Columns.Add("Tổng thu nhập kinh doanh");
            #endregion

            dtg_data.Rows.Clear();
            //FirebaseResponse response = client.Get(@"Counter");
            //int Counter = int.Parse(response.ResultAs<string>());
            for (int i = 0; i <= 43; i++)
            {
                FirebaseResponse res1 = client.Get("data/Vietcom Bank/" + i);
                //string n = res1.ResultAs<string>();
                //string n = i.ToString();
                //i = res1.ResultAs<int>();

                //var res2 = client.Get()
                dtg_data.AutoGenerateColumns = true;
                Data d = res1.ResultAs<Data>();
                if (d.Nam != "") // lailoTHUan = chung khoan kinh doanh, lailotumuaCK= chung khoan dau tu
                {
                    dt.Rows.Add(d.Nam, d.Quy, d.ThuNhapLaiRong, d.ThuNhapLaiVaCacKhoanThuNhap, d.ChiPhiLaiVaKhoanChiPhiTuongTu
                        , d.LaiLoRongTuHDDichVu, d.ThuNhapTuDV, d.ChiPhiHoatDongDichVu, d.LaiLoTuKDNgoaiHoi, d.LaiLoThuanTuMuaBanChungKhoanDauTu
                        , d.LaiLoTuMuaChungKhoanKD, d.LaiTuHoatDongKhac, d.ThuNhapHDKhac, d.ChiPhiHoatDongKhac, d.ThuNhapTuGopVon
                        , d.TongThuNhapKD, d.LaiLoCongTyLienKetLienDoanh, d.ChiPhiHoatDong, d.ChiPhiNhanVien, d.ChiPhiKhauHao
                        , d.ChiPhiHoatDongKhac01, d.LoiNhuanRongTuHDKinhDoanh, d.ChiPhiDuPhong, d.ChiPhiDuPhongRuiRoTinDung, d.KhoanXuLytheoCauTrucNganHang, d.DuPhongChungCacKhoanCamKetVaNo
                        , d.DuPhongGiamGiaChungKhoan, d.ThuHoiNoDaXuLy, d.TongLoiNhuanKeToan, d.ThuNhapTuCacKhoanNo, d.LoiNhuanTuCacCTLienKet, d.TongLoiNhuanTruocThue, d.ChiPhiThueTNDN
                        , d.ChiPhiThueHienThanh, d.ChiPhiThueHoanLai, d.LoiNhuanSauThue, d.LoiIchCoDongThieuSo, d.LoiNhuanSauThueCoDongCTme, d.LaiCoBanCoPhieu
                        , d.LaiLoSuyGiamCoPhieu);
                }
            }

            foreach (DataRow item in dt.Rows)
            {
                dtg_data.Rows.Add(item.ItemArray);
            }
        }

        private void btn_vietin_Click(object sender, EventArgs e)
        {
            #region DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Chi phí dự phòng");
            dt.Columns.Add("Chi phí dự phòng rủi ro tín dụng");
            dt.Columns.Add("Chi phí hoạt động");
            dt.Columns.Add("Chi phí hoạt động dịch vụ");
            dt.Columns.Add("Chi phí hoạt động khác");
            dt.Columns.Add("Chi phí hoạt động khác_1");
            dt.Columns.Add("Chi phí khấu hao");
            dt.Columns.Add("Chi phí lãi và các khoản chi phí tương tự");
            dt.Columns.Add("Chi phí nhân viên");
            dt.Columns.Add("Chi phí thuế TNDN");
            dt.Columns.Add("Chi phí thuế hiện hành");
            dt.Columns.Add("Chi phí thuế hoãn lại");
            dt.Columns.Add("Các khoản xử lý theo đề tài cấu trúc Ngân hàng");
            dt.Columns.Add("Dự phòng chung cho các khoản cam kết và nợ tiềm tàng");
            dt.Columns.Add("Dự phòng giảm giá chứng khoán");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán đầu tư");
            dt.Columns.Add("Lãi lỗ trong công ty liên kết, liên doanh");
            dt.Columns.Add("Lãi cơ bản trên cổ phiếu");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động dịch vụ");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động kinh doanh ngoại hối và vàng");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán kinh doanh");
            dt.Columns.Add("Lãi suy giảm trên cổ phiếu");
            dt.Columns.Add("Lãi thuần từ hoạt động khác");
            dt.Columns.Add("Lợi nhuận ròng từ hoạt động kinh doanh trước chi phí dự phòng");
            dt.Columns.Add("Lợi nhuận sau thuế");
            dt.Columns.Add("Lợi nhuận sau thuế của cổ đông công ty mẹ");
            dt.Columns.Add("Lợi nhuận được hưởng từ các công ty liên kết và liên doanh");
            dt.Columns.Add("Lợi ích của cổ đông thiểu số");
            dt.Columns.Add("Năm");
            dt.Columns.Add("Quý");
            dt.Columns.Add("Thu hồi nợ đã xử lý bằng nguồn dự phòng");
            dt.Columns.Add("Thu nhập hoạt động khác");
            dt.Columns.Add("Thu nhập lãi ròng");
            dt.Columns.Add("Thu nhập lãi và các khoản thu nhập tương tự");
            dt.Columns.Add("Thu nhập từ các khoản nợ khó đòi");
            dt.Columns.Add("Thu nhập từ góp vốn, mua cổ phần");
            dt.Columns.Add("Thu nhập từ hoạt động dịch vụ");
            dt.Columns.Add("Tổng lợi nhuận kế toán");
            dt.Columns.Add("Tổng lợi nhuận trước thuế");
            dt.Columns.Add("Tổng thu nhập kinh doanh");
            #endregion

            dtg_data.Rows.Clear();
            //FirebaseResponse response = client.Get(@"Counter");
            //int Counter = int.Parse(response.ResultAs<string>());
            for (int i = 0; i <= 43; i++)
            {
                FirebaseResponse res1 = client.Get("data/Vietin Bank/" + i);
                //string n = res1.ResultAs<string>();
                //string n = i.ToString();
                //i = res1.ResultAs<int>();

                //var res2 = client.Get()
                dtg_data.AutoGenerateColumns = true;
                Data d = res1.ResultAs<Data>();
                if (d.Nam != "") // lailoTHUan = chung khoan kinh doanh, lailotumuaCK= chung khoan dau tu
                {
                    dt.Rows.Add(d.Nam, d.Quy, d.ThuNhapLaiRong, d.ThuNhapLaiVaCacKhoanThuNhap, d.ChiPhiLaiVaKhoanChiPhiTuongTu
                        , d.LaiLoRongTuHDDichVu, d.ThuNhapTuDV, d.ChiPhiHoatDongDichVu, d.LaiLoTuKDNgoaiHoi, d.LaiLoThuanTuMuaBanChungKhoanDauTu
                        , d.LaiLoTuMuaChungKhoanKD, d.LaiTuHoatDongKhac, d.ThuNhapHDKhac, d.ChiPhiHoatDongKhac, d.ThuNhapTuGopVon
                        , d.TongThuNhapKD, d.LaiLoCongTyLienKetLienDoanh, d.ChiPhiHoatDong, d.ChiPhiNhanVien, d.ChiPhiKhauHao
                        , d.ChiPhiHoatDongKhac01, d.LoiNhuanRongTuHDKinhDoanh, d.ChiPhiDuPhong, d.ChiPhiDuPhongRuiRoTinDung, d.KhoanXuLytheoCauTrucNganHang, d.DuPhongChungCacKhoanCamKetVaNo
                        , d.DuPhongGiamGiaChungKhoan, d.ThuHoiNoDaXuLy, d.TongLoiNhuanKeToan, d.ThuNhapTuCacKhoanNo, d.LoiNhuanTuCacCTLienKet, d.TongLoiNhuanTruocThue, d.ChiPhiThueTNDN
                        , d.ChiPhiThueHienThanh, d.ChiPhiThueHoanLai, d.LoiNhuanSauThue, d.LoiIchCoDongThieuSo, d.LoiNhuanSauThueCoDongCTme, d.LaiCoBanCoPhieu
                        , d.LaiLoSuyGiamCoPhieu);
                }
            }

            foreach (DataRow item in dt.Rows)
            {
                dtg_data.Rows.Add(item.ItemArray);
            }
        }

        private void btn_vinamilk_Click(object sender, EventArgs e)
        {
            #region DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Chi phí dự phòng");
            dt.Columns.Add("Chi phí dự phòng rủi ro tín dụng");
            dt.Columns.Add("Chi phí hoạt động");
            dt.Columns.Add("Chi phí hoạt động dịch vụ");
            dt.Columns.Add("Chi phí hoạt động khác");
            dt.Columns.Add("Chi phí hoạt động khác_1");
            dt.Columns.Add("Chi phí khấu hao");
            dt.Columns.Add("Chi phí lãi và các khoản chi phí tương tự");
            dt.Columns.Add("Chi phí nhân viên");
            dt.Columns.Add("Chi phí thuế TNDN");
            dt.Columns.Add("Chi phí thuế hiện hành");
            dt.Columns.Add("Chi phí thuế hoãn lại");
            dt.Columns.Add("Các khoản xử lý theo đề tài cấu trúc Ngân hàng");
            dt.Columns.Add("Dự phòng chung cho các khoản cam kết và nợ tiềm tàng");
            dt.Columns.Add("Dự phòng giảm giá chứng khoán");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán đầu tư");
            dt.Columns.Add("Lãi lỗ trong công ty liên kết, liên doanh");
            dt.Columns.Add("Lãi cơ bản trên cổ phiếu");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động dịch vụ");
            dt.Columns.Add("Lãi lỗ ròng từ hoạt động kinh doanh ngoại hối và vàng");
            dt.Columns.Add("Lãi lỗ thuần từ mua bán chứng khoán kinh doanh");
            dt.Columns.Add("Lãi suy giảm trên cổ phiếu");
            dt.Columns.Add("Lãi thuần từ hoạt động khác");
            dt.Columns.Add("Lợi nhuận ròng từ hoạt động kinh doanh trước chi phí dự phòng");
            dt.Columns.Add("Lợi nhuận sau thuế");
            dt.Columns.Add("Lợi nhuận sau thuế của cổ đông công ty mẹ");
            dt.Columns.Add("Lợi nhuận được hưởng từ các công ty liên kết và liên doanh");
            dt.Columns.Add("Lợi ích của cổ đông thiểu số");
            dt.Columns.Add("Năm");
            dt.Columns.Add("Quý");
            dt.Columns.Add("Thu hồi nợ đã xử lý bằng nguồn dự phòng");
            dt.Columns.Add("Thu nhập hoạt động khác");
            dt.Columns.Add("Thu nhập lãi ròng");
            dt.Columns.Add("Thu nhập lãi và các khoản thu nhập tương tự");
            dt.Columns.Add("Thu nhập từ các khoản nợ khó đòi");
            dt.Columns.Add("Thu nhập từ góp vốn, mua cổ phần");
            dt.Columns.Add("Thu nhập từ hoạt động dịch vụ");
            dt.Columns.Add("Tổng lợi nhuận kế toán");
            dt.Columns.Add("Tổng lợi nhuận trước thuế");
            dt.Columns.Add("Tổng thu nhập kinh doanh");
            #endregion

            dtg_data.Rows.Clear();
            //FirebaseResponse response = client.Get(@"Counter");
            //int Counter = int.Parse(response.ResultAs<string>());
            for (int i = 0; i <= 43; i++)
            {
                FirebaseResponse res1 = client.Get("data/BIDV/" + i);
                //string n = res1.ResultAs<string>();
                //string n = i.ToString();
                //i = res1.ResultAs<int>();

                //var res2 = client.Get()
                dtg_data.AutoGenerateColumns = true;
                Data d = res1.ResultAs<Data>();
                if (d.Nam != "") // lailoTHUan = chung khoan kinh doanh, lailotumuaCK= chung khoan dau tu
                {
                    dt.Rows.Add(d.Nam, d.Quy, d.ThuNhapLaiRong, d.ThuNhapLaiVaCacKhoanThuNhap, d.ChiPhiLaiVaKhoanChiPhiTuongTu
                        , d.LaiLoRongTuHDDichVu, d.ThuNhapTuDV, d.ChiPhiHoatDongDichVu, d.LaiLoTuKDNgoaiHoi, d.LaiLoThuanTuMuaBanChungKhoanDauTu
                        , d.LaiLoTuMuaChungKhoanKD, d.LaiTuHoatDongKhac, d.ThuNhapHDKhac, d.ChiPhiHoatDongKhac, d.ThuNhapTuGopVon
                        , d.TongThuNhapKD, d.LaiLoCongTyLienKetLienDoanh, d.ChiPhiHoatDong, d.ChiPhiNhanVien, d.ChiPhiKhauHao
                        , d.ChiPhiHoatDongKhac01, d.LoiNhuanRongTuHDKinhDoanh, d.ChiPhiDuPhong, d.ChiPhiDuPhongRuiRoTinDung, d.KhoanXuLytheoCauTrucNganHang, d.DuPhongChungCacKhoanCamKetVaNo
                        , d.DuPhongGiamGiaChungKhoan, d.ThuHoiNoDaXuLy, d.TongLoiNhuanKeToan, d.ThuNhapTuCacKhoanNo, d.LoiNhuanTuCacCTLienKet, d.TongLoiNhuanTruocThue, d.ChiPhiThueTNDN
                        , d.ChiPhiThueHienThanh, d.ChiPhiThueHoanLai, d.LoiNhuanSauThue, d.LoiIchCoDongThieuSo, d.LoiNhuanSauThueCoDongCTme, d.LaiCoBanCoPhieu
                        , d.LaiLoSuyGiamCoPhieu);
                }
            }

            foreach (DataRow item in dt.Rows)
            {
                dtg_data.Rows.Add(item.ItemArray);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            new UPDATE().Show();
            this.Hide();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
