using Expenses.MVVM.Model;
using Expenses.MVVM.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Expenses.MVVM.ViewModel
{
    internal class IncomeViewModel
    {
        private static IncomeRepository incomeDatabase;
        public ICommand CommandCreateIncome => new Command( async () => await createIncome());

        public IncomeViewModel(IncomeRepository _incomeDatabase)
        {
            incomeDatabase = _incomeDatabase;
        }

        private async Task createIncome()
        {
            IncomeModel income = new IncomeModel() { Id = 0, Active = true, Name = "jaja"};
            long new_income = await incomeDatabase.SaveIncome(income);
            return;
        }
    }
}
