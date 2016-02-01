using System;

namespace XBorgSupporter.Core
{
	public class Supporter
	{
		public Supporter ()
		{
		}

		private ContactInfo contactInformation;
		private PerformanceInfo performanceInformation;

		public ContactInfo ContactInformation 
		{ 
			get
			{
				if (NULL == this.contactInformation) 
				{
					this.contactInformation = new ContactInfo ();
				}
				return this.contactInformation;
			} 
			set
			{ 
				this.contactInformation = value;
			}
		}
		public PerformanceInfo PerformanceInformation 
		{ 
			get
			{ 
				if (NULL == this.performanceInformation) 
				{
					this.performanceInformation = new PerformanceInfo ();
				}
				return this.performanceInformation;
			} 
			set
			{ 
				this.performanceInformation = value;
			}
		}

	}
}

