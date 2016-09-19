using System;
using AppServiceHelpers;
using AppServiceHelpers.Abstractions;
using AppServiceHelpers.Utils;
using AppServiceHelpers.Helpers;
using AppServiceHelpers.Tables;
using AppServiceHelpers.Forms;
using Acr.UserDialogs;

namespace FindYou
{
	public class TextViewModel: BaseAzureViewModel<Person>
	{
		IEasyMobileServiceClient client;

		public TextViewModel(IEasyMobileServiceClient client) : base(client)
		{
			this.client = client;
			Title = "Parametrage Texte";

		}
	}
}

