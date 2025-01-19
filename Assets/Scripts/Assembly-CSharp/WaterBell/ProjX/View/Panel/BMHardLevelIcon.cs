using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class BMHardLevelIcon : BMLevelIcon
	{
		public GameObject[] battleCounts;

		public GameObject star;

		[SerializeField]
		private int m_BattleCount;

		public override ProgressTypes ProgressType
		{
			set
			{
			}
		}

		public int BattleCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int Status
		{
			set
			{
			}
		}
	}
}
