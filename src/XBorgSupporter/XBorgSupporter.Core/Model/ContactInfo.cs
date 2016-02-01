using System;

namespace XBorgSupporter.Core
{
	public class ContactInfo
	{
		public ContactInfo ()
		{
		}

		private string name;
		private string nickName;
		private string phone;
		private string mobilePhone;
		private string eMail;
		private ContactAddress address;

		public string Name 
		{
			get 
			{
				return this.name;
			}
			set 
			{
				this.name = value;
			}
		}

		public string NickName 
		{
			get 
			{
				return this.nickName;
			}
			set 
			{
				this.nickName = value;
			}
		}

		public string Phone 
		{
			get 
			{
				return this.phone;
			}
			set 
			{
				this.phone = value;
			}
		}

		public string MobilePhone 
		{
			get 
			{
				return this.mobilePhone;
			}
			set 
			{
				this.mobilePhone = value;
			}
		}

		public string EMail 
		{
			get 
			{
				return this.eMail;
			}
			set 
			{
				this.eMail = value;
			}
		}

		public ContactAddress Adresse 
		{
			get 
			{
				if (NULL == this.address) 
				{
					this.address = new ContactAddress ();
				}
				return adresse;
			}
			set 
			{
				this.adresse = value;
			}
		}
	}
}

