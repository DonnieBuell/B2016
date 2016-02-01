using System;

namespace XBorgSupporter.Core
{
	public class ContactAddress
	{
		public ContactAddress ()
		{
		}

		Country country;
		String city;
		String postcode;
		String street;
		String houseNumber;

		public Country Country 
		{
			get 
			{
				return this.country;
			}
			set 
			{
				this.country = value;
			}
		}

		public String City 
		{
			get 
			{
				return this.city;
			}
			set 
			{
				this.city = value;
			}
		}

		public String Postcode 
		{
			get 
			{
				return this.postcode;
			}
			set 
			{
				this.postcode = value;
			}
		}

		public String Street 
		{
			get 
			{
				return this.street;
			}
			set 
			{
				this.street = value;
			}
		}

		public String HouseNumber 
		{
			get 
			{
				return this.houseNumber;
			}
			set 
			{
				this.houseNumber = value;
			}
		}
	}
}

