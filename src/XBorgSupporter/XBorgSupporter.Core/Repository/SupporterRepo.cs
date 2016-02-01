using System;

namespace XBorgSupporter.Core
{
	public class SupporterRepo
	{
		public SupporterRepo ()
		{
		}

		public Supporter CreateSupporterProfile()
		{
			return new Supporter ();
		}

		public List<Supporter> GetSupporters()
		{
			return new List<Supporter> ();
		}
	}
}

