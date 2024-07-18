using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnChuyenNganhA
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            List<Data03> tenVT = new DataBUS().GetAll03();
            cbx_loLai.DataSource = tenVT;
            cbx_loLai.DisplayMember = "LaiLo";
            cbx_chiphi.DataSource = tenVT;
            cbx_chiphi.DisplayMember = "Chiphi";
            cbx_LoiNhuan.DataSource = tenVT;
            cbx_LoiNhuan.DisplayMember = "LoiNhuan";


            cbx_loLai.Text = "Lỗ lãi từ...";
            cbx_chiphi.Text = "Chi phí...";
            cbx_LoiNhuan.Text = "Loi Nhuận từ...";
        }

        

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Test2().Show();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if (cbx_LoiNhuan.Text !=null && cbx_loLai.Text !=null && cbx_chiphi.Text != null)
            {
                string giatri= txt_giatri.Text;
                List<Data02> tt = new DataBUS().GetDetails(giatri);
                dgv_data.DataSource = tt;
                           
            }
        }
    }
}
