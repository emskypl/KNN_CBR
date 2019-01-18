using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace KNN
{
    class BazaDanychStruktura : DbContext
    {
        public DbSet<Irises> Irises { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlite("Data Source=Iris.db");
            
            base.OnConfiguring(dbContextOptionsBuilder);
            
        }


    }
}
