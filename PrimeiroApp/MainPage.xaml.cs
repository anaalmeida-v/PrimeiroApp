namespace PrimeiroApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    private void btnVerificar_Clicked(object sender, EventArgs e)
    {

		string texto = $"O nome tem {txtNome.Text.Length} caracteres";

		DisplayAlert("Mensagem", texto, "Ok");

    }

    private async void btnLimpar_Clicked(object sender, EventArgs e)
    {
		if(await DisplayAlert("Pergunta", "Deseja realmente limpar a tela", "Yes", "No"))
		{
			txtNome.Text = string.Empty;
		}
    }

    private async void btnVerificarDiasVIvidos_Clicked(object sender, EventArgs e)
    {
		int diasVividos = DateTime.Now.Subtract(txtDtNascimento.Date).Days;

		await Application.Current.MainPage.DisplayAlert("Mensagem", $"Você já viveu {diasVividos} dias", "Ok");
    }

    private void btnAtualizarInformacoes_Clicked(object sender, EventArgs e)
    {
        string informacoes = string.Empty;

        if (Preferences.ContainsKey("AcaoInicial"))
            informacoes += Preferences.Get("AcaoInicial", string.Empty);//string.empty --> valor default.

        if (Preferences.ContainsKey("AcaoStart"))
            informacoes += Preferences.Get("AcaoStart", string.Empty);

        if (Preferences.ContainsKey("AcaoSleep"))
            informacoes += Preferences.Get("AcaoSleep", string.Empty);

        if (Preferences.ContainsKey("AcaoResume"))
            informacoes += Preferences.Get("AcaoResume", string.Empty);

        lblInformacoes.Text = informacoes;
    }
}

