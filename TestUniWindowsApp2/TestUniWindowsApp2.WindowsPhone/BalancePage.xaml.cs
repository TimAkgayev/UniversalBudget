using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace TestUniWindowsApp2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BalancePage : Page
    {
        public BalancePage()
        {
            this.InitializeComponent();
            this._row = new BudgetRow(1, 5, 2017, 4, 54);
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void AddBalanceRow()
        {
       
            BlanceGrid.Children.Add(Row.ExpenseTitle);
            BlanceGrid.Children.Add(Row.ExpenseAmount);
            //BlanceGrid.Children.Add(Row.ExpenseDate.ToString());
            BlanceGrid.Children.Add(Row.SubmitButton);
            BlanceGrid.Children.Add(Row.DeleteButton);
        }

        public SolidColorBrush Brush1 = new SolidColorBrush(Colors.Red);
        private BudgetRow _row;
        public BudgetRow Row { get { return this._row; } set { this._row = value; }
    }

 
}
