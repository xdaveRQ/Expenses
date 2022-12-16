using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.MVVM.Model
{
    public class IncomeModel
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public float Amount { get; set; }

        public bool Active { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
