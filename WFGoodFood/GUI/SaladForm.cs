using System;
using System.Drawing;
using System.Windows.Forms;
using WFGoodFood.Control;
using WFGoodFood.DataModel;

namespace WFGoodFood.GUI
{
    public partial class SaladForm : Form
    {
        public SaladForm()
        {
            InitializeComponent();
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            Close();
            Hide();
        }

        private void lbClose_MouseEnter(object sender, EventArgs e)
        {
            lbClose.ForeColor = Color.Red;
        }

        private void lbClose_MouseLeave(object sender, EventArgs e)
        {
            lbClose.ForeColor = Color.Black;
        }

        private void SaladForm_Load(object sender, EventArgs e)
        {
            int x = 15, y = 40;

            using (ModelContext db = new ModelContext())
            {

                foreach (var item in db.SaladList)
                {
                    this.Controls.Add(new UserControlItem(item.ProductName, item.Price, item.ImageUrl)
                    { Location = new Point(x, y) });
                    x += 215;

                    if (x / 215 >= 4)
                    {
                        y += 140;
                        x = 15;
                    }
                }
            }
        }
    }
}
