using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetAppV2.Models
{
     public enum CategoryType
     {
          Income,
          Expense
     }
     public class Category
     {
          public int Id { get; set; }
          public string Name { get; set; } = "";  // "" so it isn't null
          public CategoryType Type { get; set; }

          // A category has a list of transactions associated with it
          public List<Transaction> Transactions { get; set; } = new(); // new() Creates empty list
          public List<CategoryBudget> CategoryBudgets { get; set; } = new(); // new() Creates empty list

          public override string ToString()
          {
               return $"{Name} - {Type}";
          }

          public string DisplayText
          {
               get
               {
                    return $"{Name} - {Type}";

               }
          }

     }
}
