using Expenses.MVVM.Repository;
using Expenses.MVVM.ViewModel;
using Microsoft.Extensions.DependencyInjection;

namespace Expenses.MVVM.View;

public partial class IncomeView : ContentPage
{
    public IncomeView(IncomeRepository repo)
	{
		InitializeComponent();
		BindingContext = new IncomeViewModel(repo);
	}
}