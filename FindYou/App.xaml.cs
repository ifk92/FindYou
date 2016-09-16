using Xamarin.Forms;
using System.Threading.Tasks;
using AppServiceHelpers.Abstractions;
using AppServiceHelpers;



namespace FindYou
{
	public partial class App : Application
	{
		// Add the client
		IEasyMobileServiceClient client;

		public App()
		{
			InitializeComponent();

			client = new EasyMobileServiceClient();
			client.Initialize("http://talkoral.azurewebsites.net");
			client.RegisterTable<Person>();
			client.RegisterTable<User>();
			client.FinalizeSchema();

			// Add Client in argument
			MainPage = new NavigationPage(new HomePage(client));


		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

