using System;
using System.Collections.Generic;
using AppServiceHelpers;
using AppServiceHelpers.Abstractions;


using Xamarin.Forms;

namespace FindYou
{
	public partial class TextPage : ContentPage
	{
		public TextPage(IEasyMobileServiceClient client)
		{
			InitializeComponent();
			BindingContext = new TextViewModel(client);
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			var vm = (TextViewModel)BindingContext;
			//vm.RefreshCommand.Execute(null);

		}



	}
}

