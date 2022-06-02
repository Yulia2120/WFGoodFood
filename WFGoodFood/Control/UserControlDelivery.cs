using DGVPrinterHelper;
using System;
using System.Windows.Forms;
using WFGoodFood.GUI;

namespace WFGoodFood.Control
{
    public partial class UserControlDelivery : UserControl
    {
        public UserControlDelivery()
        {
            InitializeComponent();
          
        }

        private void btnOrdersDeliv_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
        }
    }
}
