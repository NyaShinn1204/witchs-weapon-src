using System;

public class GUtilTime
{
	private static double _serverTime;

	private static float _serverTimeStamp;

	public static float gameTime;

	public static DateTime UTC_START;

	public static int TimeZoneOffSetFromServer;

	private static int _HourOffset;

	public static double serverTime
	{
		get
		{
			return 0.0;
		}
		set
		{
		}
	}

	public static DateTime serverTimeFormat
	{
		get
		{
			return default(DateTime);
		}
	}

	public static DateTime serverTimeLocalTime
	{
		get
		{
			return default(DateTime);
		}
	}

	public static DateTime serverTimeFormatLocal
	{
		get
		{
			return default(DateTime);
		}
	}

	public static int HourOffset
	{
		get
		{
			return 0;
		}
	}

	public static float timeForamt(float sStamp)
	{
		return 0f;
	}

	public static long toUtcTimestamp()
	{
		return 0L;
	}
}
