using System.Collections.Generic;
using Actionmod;
using Google.Protobuf.Collections;
using Lootmod;
using WaterBell.ProjX.Data.NetIO;

namespace WaterBell.ProjX.Playmode
{
	public class Rule1ActivityPlayMode : BasicActivityPlayMode
	{
		private List<DrawResultData> drawLoot;

		private List<DrawResultData> extraWeapon;

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

		public Rule1ActivityPlayMode(long instID, MngrCollection mngrc)
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

		protected override void HandleFetchBattleResult(bool isWin, int winStarNum = 0)
		{
		}

		public void Rule1GetrewardMsg()
		{
		}

		private void dealGetRuleDataResult(int result, RepeatedField<LootObject> loots, ExtraInfo ExtraInfo, int mode, string difficult = "", bool isspecial = false)
		{
		}

		public override long GetBuffID()
		{
			return 0L;
		}

		public override int GetFloor()
		{
			return 0;
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
	}
}
