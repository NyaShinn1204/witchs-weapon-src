namespace WaterBell.ProjX.Level.Model
{
	public class MonsterInfo
	{
		public string name { get; set; }

		public string opName { get; set; }

		public string givenName { get; set; }

		public string statID { get; set; }

		public int appearType { get; set; }

		public double[] PRS { get; set; }

		public int groupID { get; set; }

		public AIConfig ai_config { get; set; }

		public string tag { get; set; }
	}
}
