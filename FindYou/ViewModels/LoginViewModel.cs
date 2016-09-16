using System;
using AppServiceHelpers;
using AppServiceHelpers.Abstractions;
using AppServiceHelpers.Utils;
using AppServiceHelpers.Helpers;
using AppServiceHelpers.Tables;
using AppServiceHelpers.Forms;

namespace FindYou
{
	public class LoginViewModel:BaseAzureViewModel<User>
	{
		IEasyMobileServiceClient client;

		public LoginViewModel(IEasyMobileServiceClient client) : base(client)
		{
			this.client = client;
			Title = "Login";


		}
	}
}

