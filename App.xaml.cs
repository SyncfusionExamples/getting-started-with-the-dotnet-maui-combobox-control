namespace MAUIExample;

public partial class App : Application
{
	public App()
	{
		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTA1ODc0OUAzMjMwMmUzNDJlMzBQRm51MkMrSW00cUxkTHJwZWNaS2VMMlpzWUtwd0dUWk0vT3dZL3E4cDZBPQ==");
		InitializeComponent();

		MainPage = new AppShell();
	}
}
