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
            userControlHome1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlSide.Height = btnHome.Height;
            pnlRed.Top = btnHome.Top;
            userControlHome1.BringToFront();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            pnlSide.Height = btnCategory.Height;
            pnlRed.Top= btnCategory.Top;
            userControlCategory1.BringToFront();
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

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            pnlSide.Height = btnDelivery.Height;
            pnlRed.Top = btnDelivery.Top;
            userControlDelivery2.BringToFront();
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            pnlSide.Height = btnManagement.Height;
            pnlRed.Top = btnManagement.Top;
            userControlManagement1.BringToFront();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            pnlSide.Height = btnProducts.Height;
            pnlRed.Top = btnProducts.Top;
            userControlBurger.BringToFront();
        }
    }
}
