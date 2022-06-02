﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFGoodFood.DataModel;

namespace WFGoodFood.GUI
{
    public partial class FormShopping_cart : Form
    {
        public FormShopping_cart()
        {
            InitializeComponent();
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            FormShopping_cart cart = new FormShopping_cart();
            cart.Close();
            this.Hide();
        }

        private void lbClose_MouseEnter(object sender, EventArgs e)
        {
            lbClose.ForeColor = Color.Red;
        }

        private void lbClose_MouseLeave(object sender, EventArgs e)
        {
            lbClose.ForeColor = Color.Black;
        }
      
        private void btnOrderShop_Click(object sender, EventArgs e)
        {
        
            using (ModelContext db = new ModelContext())
            {
                if (txtBoxDelivShop.Text != string.Empty && txtBoxNameShop.Text != string.Empty && txtBoxPhoneShop.Text != string.Empty && txtBoxQuantity.Text != string.Empty)
                {
                    Order obj = new Order();
                    obj.CustomerId = txtBoxNameShop.Text;
                    obj.Phone = txtBoxPhoneShop.Text;
                    obj.Address = txtBoxDelivShop.Text;
                    obj.Quantity = int.Parse(txtBoxQuantity.Text);
                    obj.Total = int.Parse(txtBoxQuantity.Text);
                    obj.CreatedDate = DateTime.Now;

                    db.Set<Order>().Add(obj);
                    db.SaveChanges();
                    MessageBox.Show("Order accepted! Have a good day!");
                }


                else MessageBox.Show("Please fill in the empty fields!");



            }

        }

       
    }
}
