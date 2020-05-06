using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong4_Bai1
{
    public partial class frmtinhtong : Form
    {
        public frmtinhtong()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            if (txta.Text == "")
            {
                MessageBox.Show("bạn chưa nhập số a");
                txta.Focus();
                return;
            }
            if (txtb.Text == "")
            {
                MessageBox.Show("bạn chưa nhập số b");
                txta.Focus();
                return;
            }
            
            double a = Convert.ToDouble(txta.Text);
            double b = Convert.ToDouble(txtb.Text);
            double tong1;
            double tong2;
            tong1 = ((a + b) / 2) * (b - a + 1);
            tong2 = ((a + b) / 2) * (a - b + 1);
           

            if (a<b)
            {
                MessageBox.Show("tổng từ " + txta.Text + " đến " + txtb.Text + " là " + tong1);
                
            }    
            else if(a>b)
            {
                MessageBox.Show("tổng từ " + txtb.Text + " đến " + txta.Text + " là "  + tong2);
            }    
            
                



           
            
        }

        private void frmtinhtong_Load(object sender, EventArgs e)
        {
            MessageBox.Show("bạn đã bật form tính tổng");
        }

        private void txta_KeyPress(object sender, KeyPressEventArgs e)
        {
            

                if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
                (e.KeyChar == '-') || (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8)
                || (Convert.ToInt32(e.KeyChar) == 13))

                    e.Handled = false;

                else e.Handled = true;

            
        }

        private void txtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            

                if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
                (e.KeyChar == '-') || (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8)
                || (Convert.ToInt32(e.KeyChar) == 13))

                    e.Handled = false;

                else e.Handled = true;


                
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            txta.Text = "";
            txtb.Text = "";
        }
    }
}
