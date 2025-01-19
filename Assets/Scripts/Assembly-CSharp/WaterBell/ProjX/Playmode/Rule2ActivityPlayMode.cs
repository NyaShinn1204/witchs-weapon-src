namespace WaterBell.ProjX.Playmode
{
	public class Rule2ActivityPlayMode : BasicActivityPlayMode
	{
		public Rule2ActivityPlayMode(long instID, MngrCollection mngrc)
			: base(0L, null)
		{
		}

		public override void SetLevel(int levelIndex, int r5RoundType = 0)
		{
		}

		public override int GetCurrentFloor(int r5RoundType = 0)
		{
			return 0;
		}

		public override int GetMaxFloor(int r5RoundType = 0)
		{
			return 0;
		}

		public override int GetFloor()
		{
			return 0;
		}

		public override long GetBuffID()
		{
			return 0L;
		}
	}
}
