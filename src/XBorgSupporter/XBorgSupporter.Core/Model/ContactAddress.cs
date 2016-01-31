using System;

namespace XBorgSupporter.Core
{
	public class ContactAddress
	{
		public ContactAddress ()
		{
		}

		public Country Country { get; set;}
		public String City { get; set;}
		public String Postcode { get; set;}
		public String Street { get; set;}
		public String HouseNumber { get; set;}
	}
}

