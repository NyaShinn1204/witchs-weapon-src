using System.Collections.Generic;

namespace WaterBell.ProjX.Level.Model
{
	public class EnemyInfo
	{
		public string levelID { get; set; }

		public int lvMin { get; set; }

		public int lvMax { get; set; }

		public List<Area> areas { get; set; }
	}
}
