using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFGoodFood.DataModel;
using WFGoodFood.GUI;

namespace WFGoodFood.Control
{
    public partial class UserControlCategory : UserControl
    {
        public UserControlCategory()
        {
            InitializeComponent();
        }

        private void btnCatBurg_Click(object sender, EventArgs e)
        {
            ProductAllForm allForm = new ProductAllForm();
            allForm.Show(); 
        }

        private void btnCatToast_Click(object sender, EventArgs e)
        {
            ToastForm toast = new ToastForm();
            toast.Show();
        }

        private void btnCatPizza_Click(object sender, EventArgs e)
        {

        }

        private void btnCatSalad_Click(object sender, EventArgs e)
        {

        }

        private void btnCatDrinks_Click(object sender, EventArgs e)
        {

        }

        private void btnCatDessert_Click(object sender, EventArgs e)
        {

        }
    }
}
