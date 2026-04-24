using Microsoft.EntityFrameworkCore;
using BudgetAppV2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetAppV2.Data
{
     public class BudgetAppContext : DbContext
     {
          public DbSet<Category> Categories { get; set; }  // Creates categories table
          public DbSet<Transaction> Transactions { get; set; }  // Creates Transactions table
          public DbSet<PeriodBudget> PeriodBudgets { get; set; } // Creates PeriodBudgets table
          public DbSet<CategoryBudget> CategoryBudgets { get; set; }

          // Method EF Core calls when it needs to set up the DbContext's option
          // Replaces the base OnConfiguring
          protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          {
               if (!optionsBuilder.IsConfigured)  // Checks if it was already configured
               {
                    optionsBuilder.UseSqlite("Data Source=budgetapp.db");  //Sets EF core to use the SQLite database provider
               }
          }

          protected override void OnModelCreating(ModelBuilder modelBuilder)
          {
               modelBuilder.Entity<Transaction>()
                    .HasOne(t => t.Category)  // Transaction has 1 category
                    .WithMany(c => c.Transactions)  // A category has many transactions
                    .HasForeignKey(t => t.CategoryId)  // CategoryId stores the connection
                    .OnDelete(DeleteBehavior.Restrict);  // No deleting category if transactions are being used

               modelBuilder.Entity<Category>()
                    .Property(c => c.Name)  // Category name is required
                    .IsRequired();

               modelBuilder.Entity<CategoryBudget>()
                    .HasOne(c => c.PeriodBudget) // CategoryBudget has 1 PeriodBudget
                    .WithMany(p => p.CategoryBudgets)  // A Periodbudget had many CategoryBudgets
                    .HasForeignKey(c => c.PeriodBudgetId) // PeriodBudgetId stores the connection
                    .OnDelete(DeleteBehavior.Restrict);  // No deleting PeriodBudget if CategoryBusget is being used

               modelBuilder.Entity<CategoryBudget>()
                   .HasOne(cb => cb.Category)  // CategoryBudget has 1 Category
                   .WithMany(c => c.CategoryBudgets)  // Category has many CategoryBudgets
                   .HasForeignKey(cb => cb.CategoryId)  // CategoryId stores the connection
                   .OnDelete(DeleteBehavior.Restrict);  // No deleting Category if CategoryBudget is being used

               // Prevent duplicate category per PeriodBudget
               modelBuilder.Entity<CategoryBudget>()
                   .HasIndex(cb => new { cb.CategoryId, cb.PeriodBudgetId }) 
                   .IsUnique();

          }
     }
}
