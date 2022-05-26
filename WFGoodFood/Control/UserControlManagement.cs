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

namespace WFGoodFood.Control
{
    public partial class UserControlManagement : UserControl
    {
        public UserControlManagement()
        {
            InitializeComponent();
        }

        #region User table
        private void tabPage1_MouseDoubleClick(object sender, MouseEventArgs e)
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
            txtPhone.Enabled = true;    
            txtUserName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            userBindingSource.ResetBindings(false);
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

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            User obj = userBindingSource.Current as User;
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
       

        #endregion

        #region Admin table
        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
                adminBindingSource.Add(new Admin());
                adminBindingSource.MoveLast();
                txtLoginAdmin.Focus();
        }

        private void btnEditAdmin_Click(object sender, EventArgs e)
        {
               txtPasswordAdmin.Enabled = true;
               txtLoginAdmin.Focus();
        }

        private void btnCancelAdmin_Click(object sender, EventArgs e)
        {
            adminBindingSource.ResetBindings(false);
        }

        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (ModelContext db = new ModelContext())
                {
                    Admin obj = adminBindingSource.Current as Admin;
                    if (obj != null)
                    {
                        if (db.Entry<Admin>(obj).State == System.Data.Entity.EntityState.Detached)
                            db.Set<Admin>().Attach(obj);
                        db.Entry<Admin>(obj).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        adminBindingSource.RemoveCurrent();

                    }
                }
            }
        }

        private void dataGridViewAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Admin obj = adminBindingSource.Current as Admin;
        }

        private void btnSaveAdmin_Click(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                Admin obj = adminBindingSource.Current as Admin;
                if (obj != null)
                {
                    if (db.Entry<Admin>(obj).State == System.Data.Entity.EntityState.Detached)
                        db.Set<Admin>().Attach(obj);
                    if (obj.Id == 0)
                        db.Entry<Admin>(obj).State = System.Data.Entity.EntityState.Added;
                    else
                        db.Entry<Admin>(obj).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    dataGridViewAdmin.Refresh();

                }
            }
        }

        private void tabPage2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                 adminBindingSource.DataSource = db.AdminList.ToList();
            }
        }

        #endregion

        #region Category table
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opf = new OpenFileDialog()
            { Filter = "Choose Image(*.JPG; *.PNG;*.GIF)|*.jpg; *.png; *.gif" })
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pBoxImg.Image = Image.FromFile(opf.FileName);
                    Category obj = categoryBindingSource.Current as Category;
                    if (obj != null)
                        obj.ImageUrl = opf.FileName;
                }
        }

        private void tabPage3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                categoryBindingSource.DataSource = db.CategoryList.ToList();
            }
            Category obj = categoryBindingSource.Current as Category;
            if (obj != null)
                pBoxImg.Image = Image.FromFile(obj.ImageUrl);
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            pBoxImg.Image = null;
            categoryBindingSource.Add(new Category());
            categoryBindingSource.MoveLast();
            txtBoxProdName.Focus();
        }

        private void btnEditCat_Click(object sender, EventArgs e)
        {
            txtBoxProdName.Enabled = true;
            txtBoxDescript.Enabled = true;
            txtBoxProdName.Focus();

        }

        private void btnCancelCat_Click(object sender, EventArgs e)
        {
            categoryBindingSource.ResetBindings(false);
          
        }

        private void btnDeleteCat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (ModelContext db = new ModelContext())
                {
                    Category obj = categoryBindingSource.Current as Category;
                    if (obj != null)
                    {
                        if (db.Entry<Category>(obj).State == System.Data.Entity.EntityState.Detached)
                            db.Set<Category>().Attach(obj);
                        db.Entry<Category>(obj).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        categoryBindingSource.RemoveCurrent();
                        pBoxImg.Image = null;

                    }
                }
            }
        }

        private void dataGridViewCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Category obj = categoryBindingSource.Current as Category;
            if (obj != null)
                pBoxImg.Image = Image.FromFile(obj.ImageUrl);
        }

        private void btnSaveCat_Click(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                Category obj = categoryBindingSource.Current as Category;
                if (obj != null)
                {
                    if (db.Entry<Category>(obj).State == System.Data.Entity.EntityState.Detached)
                        db.Set<Category>().Attach(obj);
                    if (obj.Id == 0)
                        db.Entry<Category>(obj).State = System.Data.Entity.EntityState.Added;
                    else
                        db.Entry<Category>(obj).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    dataGridViewCategory.Refresh();

                }
            }
        }
        #endregion


    }
}
