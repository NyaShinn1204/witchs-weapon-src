using System.Runtime.InteropServices;

namespace LeanCloud
{
	[StructLayout(LayoutKind.Sequential, Size = 8)]
	public struct AVGeoDistance
	{
		private const double EarthMeanRadiusKilometers = 6371.0;

		private const double EarthMeanRadiusMiles = 3958.8;

		public double Radians { get; private set; }

		public double Miles
		{
			get
			{
				return 0.0;
			}
		}

		public double Kilometers
		{
			get
			{
				return 0.0;
			}
		}

		public AVGeoDistance(double radians)
		{
			Radians = 0.0;
		}

		public static AVGeoDistance FromMiles(double miles)
		{
			return default(AVGeoDistance);
		}

		public static AVGeoDistance FromKilometers(double kilometers)
		{
			return default(AVGeoDistance);
		}

		public static AVGeoDistance FromRadians(double radians)
		{
			return default(AVGeoDistance);
		}
	}
}
