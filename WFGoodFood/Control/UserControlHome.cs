using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFGoodFood.GUI;

namespace WFGoodFood.Control
{
    public partial class UserControlHome : UserControl
    {
        public UserControlHome()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            FormShopping_cart cart = new FormShopping_cart();
            cart.Show();
        }
    }
}
