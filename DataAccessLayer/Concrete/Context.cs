﻿using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
   public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("workstation id=CoreLibraryDb.mssql.somee.com;packet size=4096;user id=Terabithia1572_SQLLogin_1;pwd=iu41lvwnlk;data source=CoreLibraryDb.mssql.somee.com;persist security info=False;initial catalog=CoreLibraryDb; ");

        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdminRole> AdminRoles { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookSummary> BookSummaries { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<RewardPoint> RewardPoints { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
