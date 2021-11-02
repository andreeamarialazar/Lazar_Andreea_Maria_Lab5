using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lazar_Andreea_Maria_Lab5.Models
{
    public class ExpenseContext:DbContext
    {
        public ExpenseContext(DbContextOptions<ExpenseContext> options)
 : base(options)
        {
        }
        public DbSet<Expense> Expense { get; set; }
    }
}
