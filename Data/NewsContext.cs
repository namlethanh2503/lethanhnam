using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LeThanhNam.Models;

    public class NewsContext : DbContext
    {
        public NewsContext (DbContextOptions<NewsContext> options)
            : base(options)
        {
        }

        public DbSet<LeThanhNam.Models.News> News { get; set; }
    }
