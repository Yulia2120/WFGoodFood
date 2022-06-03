using System;
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
            PizzaForm pizzaForm = new PizzaForm();
            pizzaForm.Show();
        }

        private void btnCatSalad_Click(object sender, EventArgs e)
        {
            SaladForm saladForm = new SaladForm();
            saladForm.Show();
        }

        private void btnCatDrinks_Click(object sender, EventArgs e)
        {
            DrinkForm drinkForm = new DrinkForm();
            drinkForm.Show();
        }

        private void btnCatDessert_Click(object sender, EventArgs e)
        {
            DesertForm desertForm = new DesertForm();
            desertForm.Show();
        }
    }
}
