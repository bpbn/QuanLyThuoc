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
using System.Data;

namespace QLThuoc
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_Sell_Click(object sender, EventArgs e)
        {
            ChonThuoc f = new ChonThuoc();
            f.Show();
        }

        private void btn_Category_Click(object sender, EventArgs e)
        {
            DanhMuc f = new DanhMuc();
            this.Hide();
            f.Show();
        }

        

        
    }
}
