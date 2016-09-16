using System;
using AppServiceHelpers;
using AppServiceHelpers.Abstractions;
using AppServiceHelpers.Utils;
using AppServiceHelpers.Helpers;
using AppServiceHelpers.Tables;
using AppServiceHelpers.Forms;
using Xamarin.Forms;

namespace FindYou
{
	public class PersonsViewModel : BaseAzureViewModel<Person>
	{
		IEasyMobileServiceClient client;

		public PersonsViewModel(IEasyMobileServiceClient client): base(client)
		{
			this.client = client;
			Title = "Person Around";
			
		}
	}
}

