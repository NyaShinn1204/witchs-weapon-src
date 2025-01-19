using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class LevelIcon : MonoBehaviour
	{
		public enum LevelTypes
		{
			Normal = 2,
			Hard = 3,
			Daily = 0
		}

		public enum HardPointTypes
		{
			Pass = 0,
			CanBattle = 1,
			CanNotBattle = 2
		}

		public enum NormalPointTypes
		{
			NoPass = 0,
			CanBattle = 1,
			CanNotBattle = 2
		}

		private const string NORMAL_NOPASS_POINT = "WhitePoint";

		private const string NORMAL_CANBATTLE_POINT = "YellowPoint";

		private const string NORMAL_CANNOTBATTLE_POINT = "DarkPoint";

		private const string HARD_CANBATTLE_POINT = "GreenPoint";

		private const string HARD_CANNOTBATTLE_POINT = "RedPoint";

		private const string HARD_PASS_POINT = "YellowPoint";

		public long normalId;

		public long hardId;

		public BossLevelIcon bossLevel;

		private bool m_Lock;

		private List<Transform> hardPointList;

		private List<Transform> normalPointList;

		private Transform normalNoPassPoint;

		private Transform normalCanBattlePoint;

		private Transform normalCannotBattlePoint;

		private Transform hardCanBattlePoint;

		private Transform hardPassPoint;

		private Transform hardCanNotBattlePoint;

		private Transform hardPointContainer;

		private Transform normalPointContainer;

		private LevelTypes m_LevelState;

		private HardPointTypes m_HardPointType;

		private NormalPointTypes m_NormalPointType;

		public LevelTypes LevelState
		{
			get
			{
				return default(LevelTypes);
			}
			set
			{
			}
		}

		public HardPointTypes HardPointType
		{
			get
			{
				return default(HardPointTypes);
			}
			set
			{
			}
		}

		public NormalPointTypes NormalPointType
		{
			get
			{
				return default(NormalPointTypes);
			}
			set
			{
			}
		}

		public bool Lock
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		public void OnClick()
		{
		}
	}
}
