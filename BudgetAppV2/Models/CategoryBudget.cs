using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetAppV2.Models
{
     public class CategoryBudget
     {
          public int Id { get; set; }
          public int PeriodBudgetId { get; set; }
          public int CategoryId { get; set; }
          public decimal Limit { get; set; }
          public PeriodBudget? PeriodBudget { get; set; }
          public Category? Category { get; set; }

          public override string ToString()
          {
               // ? is ternary operator
               // Equivalent to if else statement
               string categoryName = Category != null ? Category.Name : "Unknown Category";

               string period = PeriodBudget != null
                    ? $"{PeriodBudget.PeriodStartDate.ToShortDateString()} - {PeriodBudget.PeriodEndDate.ToShortDateString()}"
                    : "Unknown Period";

               return $"{Limit:C} | {categoryName} | {period}";
          }
     }
}
