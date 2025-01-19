using System.Collections.Generic;

namespace WaterBell.ProjX.Level.Model
{
	public class Zone
	{
		public string name { get; set; }

		public double[] entryPR { get; set; }

		public double[] navP { get; set; }

		public List<Wave> waves { get; set; }

		public List<WallInfo> walls { get; set; }

		public List<ColliderTriggerInfo> triggers { get; set; }
	}
}
