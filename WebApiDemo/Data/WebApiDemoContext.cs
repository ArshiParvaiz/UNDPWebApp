﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApiDemo.Models
{
    public class WebApiDemoContext : DbContext
    {
        public WebApiDemoContext (DbContextOptions<WebApiDemoContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiDemo.Models.Product> Product { get; set; }
    }
}
