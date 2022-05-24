using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFGoodFood
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
            pnlSide.Height = btnHome.Height;
            pnlRed.Top = btnHome.Top;
            userControlHome.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlSide.Height = btnHome.Height;
            pnlRed.Top = btnHome.Top;
            userControlHome.BringToFront();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            pnlSide.Height = btnCategory.Height;
            pnlRed.Top= btnCategory.Top;
            userControlCategory.BringToFront();
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbClose_MouseEnter(object sender, EventArgs e)
        {
            lbClose.ForeColor = Color.Red;
        }

        private void lbClose_MouseLeave(object sender, EventArgs e)
        {
            lbClose.ForeColor = Color.Black;
        }
    }
}
