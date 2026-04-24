using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Design;

namespace BudgetAppV2.Models
{
     public class Transaction
     {
          public int Id { get; set; }
          public decimal Amount { get; set; }
          public DateTime Date { get; set; }
          public int CategoryId { get; set; }
          public string Description { get; set; } = "";
          public Category? Category { get; set; }
          public override string ToString()
          {
               string categoryName = Category != null ? Category.Name : "Unknown Category"; // Safety net if there is no name stored in Category object
               return $"{Date.ToShortDateString()} | {categoryName} | {Amount:C} | {Description}";
          }

     }
}
