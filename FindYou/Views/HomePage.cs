using System;
using System.Threading.Tasks;
using AppServiceHelpers.Abstractions;
using AppServiceHelpers;


using Xamarin.Forms;

namespace FindYou
{
	public class HomePage : TabbedPage
	{
		IEasyMobileServiceClient client;

		public HomePage(IEasyMobileServiceClient client)
		{
			Title = "FindYou";
			this.Children.Add(new FindYouPage(client));
			this.Children.Add(new TextPage(client));


		}
	}
}


