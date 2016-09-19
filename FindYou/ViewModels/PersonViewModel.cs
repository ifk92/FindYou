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
	public class PersonViewModel : BaseAzureViewModel<Person>
	{
		IEasyMobileServiceClient client;
		Person person;

		public PersonViewModel(IEasyMobileServiceClient client, Person person): base(client)
		{
			this.client = client;
			this.person = person;

			Title = person.Id == null ? "Add To Do" : "Edit To Do";
		}

		public string UserName 
		{ 
			get
			{
				return person.UserName;
			}
			set
			{
				person.UserName = value;
			}
		}

		public string PhotoFileName
		{ 
			get
			{
				return person.PhotoFileName;
			}
			set
			{
				person.PhotoFileName = value;
			}
		}

		public Uri ImageUri
		{
			get { 
				
				return new System.Uri(PhotoFileName); 
			}

		}


		public string Status 
		{
			get
			{
				return person.Status;
			}
			set
			{
				person.Status = value;
			} 
		}


	}


}
