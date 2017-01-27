using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace TestUniWindowsApp2
{
    public class BudgetRow
    {
        public BudgetRow(int month, int day, int year, int hour, int minutes)
        {
            ExpenseDate = new DateTime(year, month, day, hour, minutes, 0);
            SubmitButton.Content = "ok";
            SubmitButton.Width = 20;
            DeleteButton.Content = "x";
            DeleteButton.Width = 20;

        }

        public string OneString() { return "We are bound! "; }

        public TextBox ExpenseTitle { get; set; }
        public TextBox ExpenseAmount { get; set; }
        public DateTime ExpenseDate { get; set; }

        public Button SubmitButton { get; set; }
        public Button DeleteButton { get; set; }
    }
}
