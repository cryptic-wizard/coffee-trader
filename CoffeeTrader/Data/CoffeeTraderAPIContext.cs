using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoffeeTraderAPI.Models;

namespace CoffeeTraderAPI.Data
{
    public class CoffeeTraderAPIContext : DbContext
    {
        public CoffeeTraderAPIContext (DbContextOptions<CoffeeTraderAPIContext> options)
            : base(options)
        {

        }

        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
    }
}
