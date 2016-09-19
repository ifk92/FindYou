using System;
using System.Collections.Generic;
using AppServiceHelpers.Abstractions;

using Xamarin.Forms;

namespace FindYou
{
	public partial class PersonDetail : ContentPage
	{
		public PersonDetail(IEasyMobileServiceClient client, Person person=null)
		{
			InitializeComponent();

			var vm = new PersonViewModel(client,person);
			BindingContext = vm;
		}
	}
}
