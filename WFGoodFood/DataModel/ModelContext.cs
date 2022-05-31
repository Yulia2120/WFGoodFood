using System;
using System.Collections.Generic;
using System.Data.Entity;


namespace WFGoodFood.DataModel
{
    public class ModelContext:DbContext
    {
        public ModelContext()
       : base("name=cs") { }

        public virtual DbSet<User> UserList { get; set; }
        public virtual DbSet<Admin> AdminList { get; set; }
        public virtual DbSet<Category> CategoryList { get; set; }
        public virtual DbSet<Burger> BurgerList { get; set; }
        public virtual DbSet<Toast> ToastList { get; set; }
        public virtual DbSet<Pizzas> PizzasList { get; set; }
        public IEnumerable<object> Users { get; internal set; }
        public IEnumerable<object> Admins { get; internal set; }
        public IEnumerable<object> Categorys { get; internal set; }
        public IEnumerable<object> Burgers { get; internal set; }
        public IEnumerable<object> Toasts { get; internal set; }
        public IEnumerable<object> Pizzas { get; internal set; }


    }
}
