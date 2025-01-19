using System;
using System.Timers;

public class TimeTool
{
	private static System.Timers.Timer timer;

	private static DateTime s_ServerDateTime;

	public static DateTime ServerTime
	{
		get
		{
			return default(DateTime);
		}
	}

	public static void Start()
	{
	}

	public static void Stop()
	{
	}

	public static DateTime SyncFromServer(int timeStamp)
	{
		return default(DateTime);
	}

	public static DateTime SyncFromServer(string time)
	{
		return default(DateTime);
	}

	private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
	{
	}
}
