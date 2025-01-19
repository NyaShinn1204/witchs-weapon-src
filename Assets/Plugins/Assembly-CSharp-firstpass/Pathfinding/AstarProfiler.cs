using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Pathfinding
{
	public class AstarProfiler
	{
		public class ProfilePoint
		{
			public Stopwatch watch;

			public int totalCalls;

			public long tmpBytes;

			public long totalBytes;
		}

		private static Dictionary<string, ProfilePoint> profiles;

		private static DateTime startTime;

		public static ProfilePoint[] fastProfiles;

		public static string[] fastProfileNames;

		private AstarProfiler()
		{
		}

		public static void InitializeFastProfile(string[] profileNames)
		{
		}

		public static void StartFastProfile(int tag)
		{
		}

		public static void EndFastProfile(int tag)
		{
		}

		public static void EndProfile()
		{
		}

		public static void StartProfile(string tag)
		{
		}

		public static void EndProfile(string tag)
		{
		}

		public static void Reset()
		{
		}

		public static void PrintFastResults()
		{
		}

		public static void PrintResults()
		{
		}
	}
}
