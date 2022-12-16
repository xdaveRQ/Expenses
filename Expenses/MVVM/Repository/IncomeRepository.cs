using Expenses.MVVM.Model;
using Microsoft.VisualBasic;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.MVVM.Repository
{
    public class IncomeRepository
    {
        SQLiteAsyncConnection Database;

        public IncomeRepository() { }

        async Task Init()
        {
            if (Database is not null)
                return;

            Database = new SQLiteAsyncConnection(DatabaseConfig.DatabasePath, DatabaseConfig.Flags);
            var result = await Database.CreateTableAsync<IncomeModel>();
        }

        public async Task<int> SaveIncome(IncomeModel income)
        {
            await Init();
            if (income.Id != 0)
                return await Database.UpdateAsync(income);
            else
                return await Database.InsertAsync(income);
        }
    }
}
