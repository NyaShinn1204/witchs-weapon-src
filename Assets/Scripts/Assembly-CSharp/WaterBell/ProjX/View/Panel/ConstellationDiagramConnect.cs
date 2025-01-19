using System;

namespace WaterBell.ProjX.View.Panel
{
	[Serializable]
	public class ConstellationDiagramConnect
	{
		public enum ConnectTypes
		{
			Ordered = 0,
			Unordered = 1
		}

		public long start;

		public long end;

		public ConnectTypes connectType;
	}
}
