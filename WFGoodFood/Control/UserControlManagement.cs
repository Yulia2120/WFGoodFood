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
            try
            {

                if (obj != null)
                    pBoxImg.Image = Image.FromFile(obj.ImageUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        #region Burger table
       

        private void btnBrowseBurg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opf = new OpenFileDialog()
            { Filter = "Choose Image(*.JPG; *.PNG;*.GIF)|*.jpg; *.png; *.gif" })
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pBoxImage.Image = Image.FromFile(opf.FileName);
                    Burger obj = burgerBindingSource.Current as Burger;
                    if (obj != null)
                        obj.ImageUrl = opf.FileName;
                }

        }

        private void btnAddBurger_Click(object sender, EventArgs e)
        {
            pBoxImage.Image = null;
            burgerBindingSource.Add(new Burger());
            burgerBindingSource.MoveLast();
            txtBoxProdNameBurg.Focus();
        }

        private void tabPage4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                burgerBindingSource.DataSource = db.BurgerList.ToList();
            }
            Burger obj = burgerBindingSource.Current as Burger;
            if (obj != null)
                pBoxImage.Image = Image.FromFile(obj.ImageUrl);
        }

        private void btnEditBurger_Click(object sender, EventArgs e)
        {
            txtBoxProdNameBurg.Enabled = true;
            txtBoxDescripBurg.Enabled = true;
            txtBoxProdNameBurg.Focus();
        }

        private void btnCancelBurger_Click(object sender, EventArgs e)
        {
            burgerBindingSource.ResetBindings(false);
        }

        private void btnDeleteBurger_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (ModelContext db = new ModelContext())
                {
                    Burger obj = burgerBindingSource.Current as Burger;
                    if (obj != null)
                    {
                        if (db.Entry<Burger>(obj).State == System.Data.Entity.EntityState.Detached)
                            db.Set<Burger>().Attach(obj);
                        db.Entry<Burger>(obj).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        burgerBindingSource.RemoveCurrent();
                        pBoxImage.Image = null;

                    }
                }
            }
        }

        private void btnSaveBurger_Click(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                Burger obj = burgerBindingSource.Current as Burger;
                if (obj != null)
                {
                    if (db.Entry<Burger>(obj).State == System.Data.Entity.EntityState.Detached)
                        db.Set<Burger>().Attach(obj);
                    if (obj.Id == 0)
                        db.Entry<Burger>(obj).State = System.Data.Entity.EntityState.Added;
                    else
                        db.Entry<Burger>(obj).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    dataGridViewBurger.Refresh();

                }
            }
        }

        private void dataGridViewBurger_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Burger obj = burgerBindingSource.Current as Burger;
            try
            {

            if (obj != null)
                pBoxImage.Image = Image.FromFile(obj.ImageUrl);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Toast table

        private void btnBrowseToast_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opf = new OpenFileDialog()
            { Filter = "Choose Image(*.JPG; *.PNG;*.GIF)|*.jpg; *.png; *.gif" })
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pBoxImgToast.Image = Image.FromFile(opf.FileName);
                    Toast obj = toastBindingSource.Current as Toast;
                    if (obj != null)
                        obj.ImageUrl = opf.FileName;
                }

        }

        private void btnAddtoast_Click(object sender, EventArgs e)
        {
            pBoxImgToast.Image = null;
            toastBindingSource.Add(new Toast());
            toastBindingSource.MoveLast();
            txtBoxProdToast.Focus();
        }

        private void btnEditToast_Click(object sender, EventArgs e)
        {
            txtBoxProdToast.Enabled = true;
            txtBoxDesToast.Enabled = true;
            txtBoxProdToast.Focus();
        }

        private void dataGridViewToast_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Toast obj = toastBindingSource.Current as Toast;
            try
            {

                if (obj != null)
                    pBoxImgToast.Image = Image.FromFile(obj.ImageUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabPage5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                toastBindingSource.DataSource = db.ToastList.ToList();
            }
            Toast obj = toastBindingSource.Current as Toast;
            if (obj != null)
                pBoxImgToast.Image = Image.FromFile(obj.ImageUrl);
        }

        private void btnCancelToast_Click(object sender, EventArgs e)
        {
            toastBindingSource.ResetBindings(false);
        }

        private void btnDeleteToast_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (ModelContext db = new ModelContext())
                {
                    Toast obj = toastBindingSource.Current as Toast;
                    if (obj != null)
                    {
                        if (db.Entry<Toast>(obj).State == System.Data.Entity.EntityState.Detached)
                            db.Set<Toast>().Attach(obj);
                        db.Entry<Toast>(obj).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        toastBindingSource.RemoveCurrent();
                        pBoxImgToast.Image = null;

                    }
                }
            }
        }

        private void btnSaveToast_Click(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                Toast obj = toastBindingSource.Current as Toast;
                if (obj != null)
                {
                    if (db.Entry<Toast>(obj).State == System.Data.Entity.EntityState.Detached)
                        db.Set<Toast>().Attach(obj);
                    if (obj.Id == 0)
                        db.Entry<Toast>(obj).State = System.Data.Entity.EntityState.Added;
                    else
                        db.Entry<Toast>(obj).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    dataGridViewToast.Refresh();

                }
            }
        }

        #endregion

        #region Pizzas table

        private void btnBrowsePizza_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opf = new OpenFileDialog()
            { Filter = "Choose Image(*.JPG; *.PNG;*.GIF)|*.jpg; *.png; *.gif" })
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pBoxImgPizza.Image = Image.FromFile(opf.FileName);
                    Pizzas obj = pizzasBindingSource.Current as Pizzas;
                    if (obj != null)
                        obj.ImageUrl = opf.FileName;
                }

        }

        private void btnAddPizza_Click(object sender, EventArgs e)
        {
            pBoxImgPizza.Image = null;
            pizzasBindingSource.Add(new Pizzas());
            pizzasBindingSource.MoveLast();
            txtBoxProdNamePizza.Focus();
        }

        private void btnEditPizza_Click(object sender, EventArgs e)
        {
            txtBoxProdNamePizza.Enabled = true;
            txtBoxDesPizza.Enabled = true;
            txtBoxProdNamePizza.Focus();
        }

        private void dataGridViewPizza_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Pizzas obj = pizzasBindingSource.Current as Pizzas;
            try
            {

                if (obj != null)
                    pBoxImgPizza.Image = Image.FromFile(obj.ImageUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabPage6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                pizzasBindingSource.DataSource = db.PizzasList.ToList();
            }
            Pizzas obj = pizzasBindingSource.Current as Pizzas;
            if (obj != null)
                pBoxImgPizza.Image = Image.FromFile(obj.ImageUrl);
        }

        private void btnCancelPizza_Click(object sender, EventArgs e)
        {
            pizzasBindingSource.ResetBindings(false);
        }

        private void btnDeletePizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (ModelContext db = new ModelContext())
                {
                    Pizzas obj = pizzasBindingSource.Current as Pizzas;
                    if (obj != null)
                    {
                        if (db.Entry<Pizzas>(obj).State == System.Data.Entity.EntityState.Detached)
                            db.Set<Pizzas>().Attach(obj);
                        db.Entry<Pizzas>(obj).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        pizzasBindingSource.RemoveCurrent();
                        pBoxImgPizza.Image = null;

                    }
                }
            }
        }

        private void btnSavePizza_Click(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                Pizzas obj = pizzasBindingSource.Current as Pizzas;
                if (obj != null)
                {
                    if (db.Entry<Pizzas>(obj).State == System.Data.Entity.EntityState.Detached)
                        db.Set<Pizzas>().Attach(obj);
                    if (obj.Id == 0)
                        db.Entry<Pizzas>(obj).State = System.Data.Entity.EntityState.Added;
                    else
                        db.Entry<Pizzas>(obj).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    dataGridViewPizza.Refresh();

                }
            }
        }


        #endregion

        #region Salad table
        private void btnBrowseSalad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opf = new OpenFileDialog()
            { Filter = "Choose Image(*.JPG; *.PNG;*.GIF)|*.jpg; *.png; *.gif" })
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pBoxImgSalad.Image = Image.FromFile(opf.FileName);
                    Salad obj = saladBindingSource.Current as Salad;
                    if (obj != null)
                        obj.ImageUrl = opf.FileName;
                }

        }

        private void btnAddSalad_Click(object sender, EventArgs e)
        {
            pBoxImgSalad.Image = null;
            saladBindingSource.Add(new Salad());
            saladBindingSource.MoveLast();
            txtBoxProdNameSalad.Focus();
        }

        private void btnEditSalad_Click(object sender, EventArgs e)
        {
            txtBoxProdNameSalad.Enabled = true;
            txtBoxDesSalad.Enabled = true;
            txtBoxProdNameSalad.Focus();
        }

        private void btnCancelSalad_Click(object sender, EventArgs e)
        {
            saladBindingSource.ResetBindings(false);
        }

        private void dataGridViewSalad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Salad obj = saladBindingSource.Current as Salad;
            try
            {

                if (obj != null)
                    pBoxImgSalad.Image = Image.FromFile(obj.ImageUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabPage7_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                saladBindingSource.DataSource = db.SaladList.ToList();
            }
            Salad obj = saladBindingSource.Current as Salad;
            if (obj != null)
                pBoxImgSalad.Image = Image.FromFile(obj.ImageUrl);
        }

        private void btnDeleteSalad_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (ModelContext db = new ModelContext())
                {
                    Salad obj = saladBindingSource.Current as Salad;
                    if (obj != null)
                    {
                        if (db.Entry<Salad>(obj).State == System.Data.Entity.EntityState.Detached)
                            db.Set<Salad>().Attach(obj);
                        db.Entry<Salad>(obj).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        saladBindingSource.RemoveCurrent();
                        pBoxImgSalad.Image = null;

                    }
                }
            }
        }

        private void btnSaveSalad_Click(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                Salad obj = saladBindingSource.Current as Salad;
                if (obj != null)
                {
                    if (db.Entry<Salad>(obj).State == System.Data.Entity.EntityState.Detached)
                        db.Set<Salad>().Attach(obj);
                    if (obj.Id == 0)
                        db.Entry<Salad>(obj).State = System.Data.Entity.EntityState.Added;
                    else
                        db.Entry<Salad>(obj).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    dataGridViewSalad.Refresh();

                }
            }
        }


        #endregion
        #region Drink table
        private void btnBrowseDrink_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opf = new OpenFileDialog()
            { Filter = "Choose Image(*.JPG; *.PNG;*.GIF)|*.jpg; *.png; *.gif" })
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pBoxImgDrink.Image = Image.FromFile(opf.FileName);
                    Drink obj = drinkBindingSource.Current as Drink;
                    if (obj != null)
                        obj.ImageUrl = opf.FileName;
                }
        }

        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            pBoxImgDrink.Image = null;
            drinkBindingSource.Add(new Drink());
            drinkBindingSource.MoveLast();
            txtBoxProdNameDrink.Focus();
        }

        private void btnEditDrink_Click(object sender, EventArgs e)
        {
            txtBoxProdNameDrink.Enabled = true;
            txtBoxDesDrink.Enabled = true;
            txtBoxProdNameDrink.Focus();
        }

        private void btnCancelDrink_Click(object sender, EventArgs e)
        {
            drinkBindingSource.ResetBindings(false);
        }

        private void dataGridViewDrink_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Drink obj = drinkBindingSource.Current as Drink;
            try
            {

                if (obj != null)
                    pBoxImgDrink.Image = Image.FromFile(obj.ImageUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabPage8_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                drinkBindingSource.DataSource = db.DrinkList.ToList();
            }
            Drink obj = drinkBindingSource.Current as Drink;
            if (obj != null)
                pBoxImgDrink.Image = Image.FromFile(obj.ImageUrl);
        }

        private void btnDeleteDrink_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (ModelContext db = new ModelContext())
                {
                    Drink obj = drinkBindingSource.Current as Drink;
                    if (obj != null)
                    {
                        if (db.Entry<Drink>(obj).State == System.Data.Entity.EntityState.Detached)
                            db.Set<Drink>().Attach(obj);
                        db.Entry<Drink>(obj).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        drinkBindingSource.RemoveCurrent();
                        pBoxImgDrink.Image = null;

                    }
                }
            }
        }

        private void btnSaveDrink_Click(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                Drink obj = drinkBindingSource.Current as Drink;
                if (obj != null)
                {
                    if (db.Entry<Drink>(obj).State == System.Data.Entity.EntityState.Detached)
                        db.Set<Drink>().Attach(obj);
                    if (obj.Id == 0)
                        db.Entry<Drink>(obj).State = System.Data.Entity.EntityState.Added;
                    else
                        db.Entry<Drink>(obj).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    dataGridViewDrink.Refresh();

                }
            }
        }
    #endregion
    }
}
