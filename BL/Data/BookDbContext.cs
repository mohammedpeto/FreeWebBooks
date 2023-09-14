﻿using Domain.Entity;
using Infrastructure.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
  public  class BookDbContext : IdentityDbContext<ApplicationUser>
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.Entity<Category>().Property(x => x.Id).HasDefaultValueSql("(newid()");
            //builder.Entity<LogCategory>().Property(x => x.Id).HasDefaultValueSql("(newid()");
            //builder.Entity<SubCategory>().Property(x => x.Id).HasDefaultValueSql("(newid()");
            //builder.Entity<LogSubCategory>().Property(x => x.Id).HasDefaultValueSql("(newid()");
            //builder.Entity<Book>().Property(x => x.Id).HasDefaultValueSql("(newid()");
            //builder.Entity<LogBook>().Property(x => x.Id).HasDefaultValueSql("(newid()");

            //builder.Entity<Book>()
            //    .HasOne(e => e.SubCategory)
            //    .WithMany(r => r.Books)
            //    .OnDelete(DeleteBehavior.Restrict);

          

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<LogCategory> LogCategories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<LogSubCategory> LogSubCategories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<LogBook> LogBooks { get; set; }

    }
}
