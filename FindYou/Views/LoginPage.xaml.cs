using System;
using System.Collections.Generic;
using AppServiceHelpers.Abstractions;

using Xamarin.Forms;

namespace FindYou
{
	public partial class LoginPage : ContentPage
	{
		
		public LoginPage(IEasyMobileServiceClient client)
		{
			InitializeComponent();
			BindingContext = new LoginViewModel(client);


			NavigationPage.SetHasNavigationBar(this, false);

			buttonLogin.Clicked += async (object sender, EventArgs e) =>
			{
				await Navigation.PushAsync(new FindYouPage(client));
			};

		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			var vm = (LoginViewModel)BindingContext;
			vm.RefreshCommand.Execute(null);

		}


	}


}

