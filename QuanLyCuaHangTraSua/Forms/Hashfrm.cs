using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangTraSua.Forms
{
    public partial class Hashfrm : Form
    {
        public Hashfrm()
        {
            InitializeComponent();
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            string hash = BCrypt.Net.BCrypt.HashPassword("1111");
            Clipboard.SetText(hash);
            MessageBox.Show("Đã copy hash vào clipboard");
        }

        private void Hashfrm_Load(object sender, EventArgs e)
        {

        }
    }
}
