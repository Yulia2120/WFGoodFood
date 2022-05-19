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
        public IEnumerable<object> Users { get; internal set; }
    }
}
