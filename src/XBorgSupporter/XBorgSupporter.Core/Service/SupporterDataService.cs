using System;

namespace XBorgSupporter.Core
{
	public class SupporterDataService
	{
		private static SupporterRepo supporterRepository = new SupporterRepo();

		public SupporterDataService ()
		{
		}

		public Supporter GetNewSupporterProfile()
		{
			supporterRepository.CreateSupporterProfile();
		}

		public List<Supporter> GetSupporters()
		{
			supporterRepository.GetSupporters();
		}
	}
}

