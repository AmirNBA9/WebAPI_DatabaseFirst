using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DB_First_API.Models.DB;

#nullable disable

namespace DB_First_API.Models.DB
{
    public partial class DB_Demo_APIContext : DbContext
    {
        public DB_Demo_APIContext()
        {
        }

        public DB_Demo_APIContext(DbContextOptions<DB_Demo_APIContext> options)
            : base(options)
        {
        }

        public DbSet<DB_First_API.Models.DB.output> output { get; set; }

    }
}