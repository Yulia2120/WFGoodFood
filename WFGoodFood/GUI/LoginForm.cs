using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFGoodFood.GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lbClose_MouseEnter(object sender, EventArgs e)
        {
            lbClose.ForeColor = Color.Red;
        }

        private void lbClose_MouseLeave(object sender, EventArgs e)
        {
            lbClose.ForeColor = Color.Black;
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbClear_MouseEnter(object sender, EventArgs e)
        {
            lbClear.ForeColor = Color.Red;
        }

        private void lbClear_MouseLeave(object sender, EventArgs e)
        {
            lbClear.ForeColor = Color.FromArgb(85, 115, 0);
        }

        private void lbClear_Click(object sender, EventArgs e)
        {
            txtboxUserName.Clear();
            txtboxPassword.Clear();
        }

       
    }
}
