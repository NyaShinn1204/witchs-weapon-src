using System;

namespace LeanCloud.Realtime.Internal
{
	internal static class DateTimeEngine
	{
		public static long ToUnixTimeStamp(this DateTime date, UnixTimeStampUnit unit = UnixTimeStampUnit.Milisecond)
		{
			return 0L;
		}

		public static DateTime ToDateTime(this long timestamp, UnixTimeStampUnit unit = UnixTimeStampUnit.Milisecond)
		{
			return default(DateTime);
		}
	}
}
