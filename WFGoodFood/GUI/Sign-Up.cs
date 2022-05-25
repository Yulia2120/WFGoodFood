using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using WFGoodFood.DataModel;

namespace WFGoodFood.GUI
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
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
        public bool IsEmpty()
        {
            if(txtBoxUserNameSign.Text.Trim() == "" || txtBoxEmail.Text.Trim() == "" || txtBoxPassSign.Text.Trim() == "" 
                || txtBoxPhone.Text.Trim() == "")
            {
                return true;
            }
            else { return false; }
        }
        private void btnSign_Click(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                if (!IsEmpty())
                {
                    User obj = new User();
                    obj.UserName = txtBoxUserNameSign.Text;
                    obj.Email = txtBoxEmail.Text;
                    obj.Password = txtBoxPassSign.Text;
                    obj.Phone = txtBoxPhone.Text;

                    db.Set<User>().Add(obj);
                    db.SaveChanges();
                    MessageBox.Show("Success!");
                }
                else
                {
                    MessageBox.Show("Empty Fields are not allowed!");
                }

            }             
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            Hide();
            login.Show();
        }
    }
}
