using System.Collections.Generic;
using System.Runtime.InteropServices;
using LeanCloud.Storage.Internal;

namespace LeanCloud
{
	[StructLayout(LayoutKind.Sequential, Size = 16)]
	public struct AVGeoPoint : IJsonConvertible
	{
		private double latitude;

		private double longitude;

		public double Latitude
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public double Longitude
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public AVGeoPoint(double latitude, double longitude)
		{
			this.latitude = 0.0;
			this.longitude = 0.0;
		}

		public AVGeoDistance DistanceTo(AVGeoPoint point)
		{
			return default(AVGeoDistance);
		}

		IDictionary<string, object> IJsonConvertible.ToJSON()
		{
			return null;
		}
	}
}
