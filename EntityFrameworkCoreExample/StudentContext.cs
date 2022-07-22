using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreExample 
{
    // EF Core Starting Info:
    // https://docs.microsoft.com/en-us/ef/core/get-started/overview/install
    public class StudentContext : DbContext
    {
        public StudentContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Connection String Information:
            // https://docs.microsoft.com/en-us/ef/core/miscellaneous/connection-strings#aspnet-core

            // Server = The server we are connecting to. LocalDb is included with Visual Studio.
            // Database = The desired name for the database.
            // Trusted_Connection = Indicates that our windows account should be used.
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFCoreExample;Trusted_Connection=True;");
        }
    }
}
