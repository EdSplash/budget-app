using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetAppV2.Models
{
     public class PeriodBudget
     {
          public int Id { get; set; }
          public decimal TotalLimit { get; set; }
          public DateTime PeriodStartDate { get; set; }
          public DateTime PeriodEndDate { get; set; }
          public List<CategoryBudget> CategoryBudgets { get; set; } = new(); // new() Creates empty list

          public override string ToString()
          {
               return $"{PeriodStartDate.ToShortDateString()} - {PeriodEndDate.ToShortDateString()} | {TotalLimit:C} ";
          }
         
     }
}
