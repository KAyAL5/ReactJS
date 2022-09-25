using Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Presistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions option) : base(option)
        {

        }

        public DbSet<Activity> Activities { get; set; }
    }
}
