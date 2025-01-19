using System.Collections.Generic;
using Actionmod;
using Google.Protobuf.Collections;
using Lootmod;
using WaterBell.ProjX.Data.Entity;
using WaterBell.ProjX.Data.NetIO;

namespace WaterBell.ProjX.Playmode
{
	public class Rule5ActivityPlayMode : BasicActivityPlayMode
	{
		private List<DrawResultData> extraBonus;

		private List<DrawResultData> drawLoot;

		private List<DrawResultData> extraWeapon;

		private List<long> lootBuff;

		private List<int> lootBuffLayer;

		public List<DrawResultData> ExtraBonus
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<DrawResultData> DrawLoot
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<DrawResultData> ExtraWeapon
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<long> LootBuff
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<int> LootBuffLayer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int CurBattleScore
		{
			get
			{
				return 0;
			}
		}

		public int BeforeMobLevel
		{
			get
			{
				return 0;
			}
		}

		public int MobLevel
		{
			get
			{
				return 0;
			}
		}

		public int MaxMobLevel
		{
			get
			{
				return 0;
			}
		}

		public Rule5ActivityPlayMode(long instID, MngrCollection mngrc)
			: base(0L, null)
		{
		}

		protected override void Init()
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

		public override List<ActivityPlayModeBuffInfo> CurrentLevelBuff(int r5roundType = 0)
		{
			return null;
		}

		protected override void HandleFetchBattleResult(bool isWin, int winStarNum = 0)
		{
		}

		public override ActionResult IsAble2SelectCard()
		{
			return default(ActionResult);
		}

		public override List<NetMsgBase> BuildInitialNetMsgList()
		{
			return null;
		}

		public override ActionResult CanGetReward(int r5RoundType = 0)
		{
			return default(ActionResult);
		}

		public override ActionResult CanGotoNextFloor(int r5RoundType = 0)
		{
			return default(ActionResult);
		}

		public void ChooseCurrentLevelAndBuff(int levelIndex, int buffIndex)
		{
		}

		public override void OnLoadOutBegin()
		{
		}

		public void Rule5GetrewardMsg()
		{
		}

		private void dealGetRuleDataResult(int result, RepeatedField<LootObject> loots, ExtraInfo ExtraInfo, int mode, string difficult = "", bool isspecial = false)
		{
		}

		private void dealGetExtraBonusDataResult(int result, RepeatedField<LootObject> loots)
		{
		}
	}
}
