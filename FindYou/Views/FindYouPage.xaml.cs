using Xamarin.Forms;
using AppServiceHelpers;
using AppServiceHelpers.Abstractions;


namespace FindYou
{
	public partial class FindYouPage : ContentPage
	{
		public FindYouPage(IEasyMobileServiceClient client)
		{
			InitializeComponent();
			BindingContext = new PersonsViewModel(client);
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			var vm = (PersonsViewModel)BindingContext;
			if (vm.Items.Count > 0 || vm.IsBusy)
				return;

			vm.RefreshCommand.Execute(null);

		}


	}
}

