using PrimeiroApp.ViewModel;

namespace PrimeiroApp.Views;

public partial class UsuarioView : ContentPage
{
	public UsuarioView()
	{
		InitializeComponent();
		BindingContext = new UsuarioViewModel();

		


	}
}