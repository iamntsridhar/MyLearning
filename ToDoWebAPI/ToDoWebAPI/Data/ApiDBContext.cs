using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoWebAPI.Models;

namespace ToDoWebAPI.Data
{
    public class ApiDBContext : DbContext
    {
        public virtual DbSet<ItemData> Items { get; set; }

        public ApiDBContext(DbContextOptions<ApiDBContext> Options) : base(Options)
        {

        }
    }
}
