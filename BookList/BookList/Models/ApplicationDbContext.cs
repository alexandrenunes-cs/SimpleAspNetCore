using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookList.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        //public string ConnectionString { get; set; }

        //public ApplicationDbContext(string connectionString)
        //{
        //    this.ConnectionString = connectionString;
        //}

        //private MySqlConnection GetConnection()
        //{
        //    return new MySqlConnection(ConnectionString);
        //}

        public DbSet<Book> Books { get; set; }
    }
}
