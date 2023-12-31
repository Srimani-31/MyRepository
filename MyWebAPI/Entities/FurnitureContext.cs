﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAPI.Entities
{
    public class FurnitureContext : DbContext
    {
        public FurnitureContext(DbContextOptions<FurnitureContext> options)
           : base(options)
        {
        }
       public DbSet<Furniture> Furnitures { get; set; } 
    }
}
