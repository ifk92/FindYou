using System;
using AppServiceHelpers;
using AppServiceHelpers.Models;


namespace FindYou
{
	public class Person:EntityData
	{
		public string UserName { get; set; }

		public string PhotoFileName { get; set; }

		public Uri ImageUri
		{
			get { return new System.Uri(PhotoFileName); }
		}


		public string Status { get; set; }

		public string Opener { get; set; }

		public string Body { get; set; }

		public string Closer { get; set; }

		public long Longitude { get; set; }

		public long Latitude { get; set; }

		public string UserId { get; set; }







	}
}

