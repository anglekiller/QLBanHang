﻿using Microsoft.EntityFrameworkCore;
using QLBH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace QLBH.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
          DbContextOptions<ApplicationDbContext> options)
          : base(options)
        { }
        public DbSet<User> User { get; set; }
     
      
    }
   
}

