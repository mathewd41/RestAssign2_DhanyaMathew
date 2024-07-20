using Microsoft.EntityFrameworkCore;
using RestAssign2_DhanyaMathew.Entities;
using System.Collections.Generic;

namespace RestAssign2_DhanyaMathew.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
    }
}