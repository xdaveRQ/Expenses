using Expenses.MVVM.Repository;

namespace Expenses;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
