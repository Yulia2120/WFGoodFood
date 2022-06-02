using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFGoodFood.Control
{
    public partial class UserControlItem : UserControl
    {
        public UserControlItem()
        {
        }

        public UserControlItem(string ProductName, decimal Price, string ImageUrl)
        {
            InitializeComponent();

            lbNameItem.Text = ProductName;
            lbPriceItem.Text = Price.ToString();
            pBoxItem.Image = Image.FromFile(ImageUrl);
        }


    }
}
