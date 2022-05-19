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

namespace WFGoodFood
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                userBindingSource.DataSource = db.UserList.ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            userBindingSource.Add(new User());
            userBindingSource.MoveLast();
            txtUserName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtEmail.Enabled = true;
            txtPassword.Enabled = true;
            txtUserName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            userBindingSource.ResetBindings(false);
            tabPage1_Click(sender, e);
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            User obj = userBindingSource.Current as User;

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (ModelContext db = new ModelContext())
                {
                    User obj = userBindingSource.Current as User;
                    if (obj != null)
                    {
                        if (db.Entry<User>(obj).State == System.Data.Entity.EntityState.Detached)
                            db.Set<User>().Attach(obj);
                        db.Entry<User>(obj).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        userBindingSource.RemoveCurrent();

                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                User obj = userBindingSource.Current as User;
                if (obj != null)
                {
                    if (db.Entry<User>(obj).State == System.Data.Entity.EntityState.Detached)
                        db.Set<User>().Attach(obj);
                    if (obj.Id == 0)
                        db.Entry<User>(obj).State = System.Data.Entity.EntityState.Added;
                    else
                        db.Entry<User>(obj).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    dataGridView.Refresh();

                }
            }
        }
    }
}