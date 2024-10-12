namespace Calculadora;

public partial class ResultView : ContentPage
{
	public ResultView(string result)
	{
		InitializeComponent();
		lblResult.Text = result;
	}

	private void close_view(object sender, EventArgs e) {
		Application.Current.MainPage = new AppShell();
	}
}