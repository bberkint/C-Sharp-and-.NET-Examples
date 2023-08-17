using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("server = BERKINPC\\SQLEXPRESS;database = CoreBlogDb: integrated security = true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Context>().HasNoKey();
            // Diğer varlık tanımlamaları veya yapılandırmaları
        }



        public DbSet<About> AboutS { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Comment> Comments { get; set; }

        public DbSet<Context> Contexts { get; set; }

        public DbSet<Writer> Writers { get; set; }

    }


}
