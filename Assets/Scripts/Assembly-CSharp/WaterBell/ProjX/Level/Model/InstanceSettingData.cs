namespace WaterBell.ProjX.Level.Model
{
	public class InstanceSettingData
	{
		public QuestInfo QuestInfo { get; set; }

		public MapInfo MapInfo { get; set; }

		public AIInfo AIInfo { get; set; }

		public EnemyInfo EnemyLayer { get; set; }

		public ItemInfo[] ItemLayer { get; set; }

		public NPCInfo[] NPCLayer { get; set; }

		public InteractiveObjInfo[] InteractiveObjLayer { get; set; }

		public int getTotalWave(int areaIdx)
		{
			return 0;
		}
	}
}
