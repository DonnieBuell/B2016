using System;

namespace XBorgSupporter.Core
{
	public class ContactInfo
	{
		public ContactInfo ()
		{
		}

		public string Name { get; set;}
		public string NickName { get; set;}
		public string Phone { get; set;}
		public string MobilePhone { get; set;}
		public string eMail { get; set;}
		public ContactAddress Adresse { get; set;}
	}
}

