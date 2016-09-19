using System;
using AppServiceHelpers;
using AppServiceHelpers.Abstractions;
using AppServiceHelpers.Utils;
using AppServiceHelpers.Helpers;
using AppServiceHelpers.Tables;
using AppServiceHelpers.Forms;
using Xamarin.Forms;
using System.Linq;

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

		Person selectedPerson;
		public Person SelectedPerson
		{
			get { return selectedPerson; }
			set
			{
				selectedPerson = value;
				OnPropertyChanged("SelectedItem");

				if (selectedPerson != null)
				{
					var navigation = Application.Current.MainPage as NavigationPage;
					navigation.PushAsync(new PersonDetail(client, selectedPerson));
					SelectedPerson = null;
				}
			}
		}


	}
}

