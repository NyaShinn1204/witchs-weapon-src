namespace WaterBell.ProjX.Level.Model
{
	public class QuestInfo
	{
		public class TriggerModel
		{
			public string type;

			public string[] param;
		}

		public int code { get; set; }

		public string optStr { get; set; }

		public int sec { get; set; }

		public TriggerModel[] Triggers { get; set; }

		public int[] WinJudgement { get; set; }

		public int[] LoseJudgement { get; set; }

		public int BonusType { get; set; }

		public double BonusParam { get; set; }

		public int LevelObjectiveType { get; set; }
	}
}
