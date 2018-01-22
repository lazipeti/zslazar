﻿using ListingTodos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }    
        public DbSet<User> Users { get; set; }
    }
}