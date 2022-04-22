using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LeThanhNam.Models;

    public class MyContext : DbContext
    {
        public MyContext (DbContextOptions<MyContext> options)
            : base(options)
        {
        }

        public DbSet<LeThanhNam.Models.Category> Category { get; set; }

        public DbSet<LeThanhNam.Models.News> News { get; set; }

        public DbSet<LeThanhNam.Models.Comment> Comment { get; set; }
    }
