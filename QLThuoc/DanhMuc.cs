using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuoc
{
    public partial class DanhMuc : Form
    {
        public DanhMuc()
        {
            InitializeComponent();
        }

        private void DanhMuc_Load(object sender, EventArgs e)
        {
            PictureBox pb = new PictureBox();
            pb.ImageLocation = "Resources/logo1.png";
            pb.SizeMode = PictureBoxSizeMode.AutoSize; 
        }
    }
}
