using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WFGoodFood.DataModel;

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

        private void btnlogin_Click(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
            string username = txtboxUserName.Text;
            string password = txtboxPassword.Text;
            var rec = db.Set<User>().Where(a => a.UserName == username && a.Password == password).FirstOrDefault();
                if (rec != null)
                {
                    MessageBox.Show("Login Success");
                }
                if(rec != null)
                {
                 ProductForm frm = new ProductForm();
                    Hide();
                   frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("login Fail");
                }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Sign_Up sign = new Sign_Up();
            Hide();
            sign.Show();
        }
    }
}
