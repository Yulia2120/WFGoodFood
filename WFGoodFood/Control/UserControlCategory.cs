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
    }
}
