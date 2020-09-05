using System;
using System.Collections.Generic;
using DWThemeplate.Core;
using Microsoft.EntityFrameworkCore;

namespace DWThemeplate.Data
{
    class DWThemeplateDbContext : DbContext
    {
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}