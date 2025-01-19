using System.Collections.Generic;

namespace WaterBell.ProjX.Tools
{
	public class UISDKHelper
	{
		private static UISDKHelper instantce;

		private Dictionary<string, string> countryCodeToCurrency;

		private List<string> notNeedUseCountryCode;

		private List<string> originCountryCodes;

		public string HardCoreChName { get; set; }

		private UISDKHelper()
		{
		}

		public static UISDKHelper getInstance()
		{
			return null;
		}

		public string GetCurrencyByCountryCode(string code)
		{
			return null;
		}

		public int GetCountryCodeIndex(string code)
		{
			return 0;
		}

		public bool IsNeedUseCountryCode(string code)
		{
			return false;
		}

		public static bool IsTwVersion()
		{
			return false;
		}

		public static bool IsTwAndroidVersion()
		{
			return false;
		}

		public static bool IsTwIOSVersion()
		{
			return false;
		}

		public static bool IsJPVersion()
		{
			return false;
		}

		public static bool IsJPDmmPcVersion()
		{
			return false;
		}
	}
}
