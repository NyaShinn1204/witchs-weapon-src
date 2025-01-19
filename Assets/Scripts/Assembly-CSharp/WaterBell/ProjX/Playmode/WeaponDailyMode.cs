using Levelmod;
using WaterBell.ProjX.Data.NetIO;

namespace WaterBell.ProjX.Playmode
{
	public class WeaponDailyMode : NormalMode
	{
		public int ChooseMateriaTime { get; set; }

		public WeaponDailyMode(long instID, MngrCollection mngrc)
			: base(0L, null)
		{
		}

		protected override void Init()
		{
		}

		protected override void HandleFetchBattleResult(bool isWin, int winStarNum = 0)
		{
		}

		public override void ParseBattleResult(Levelmod.BattleResult result)
		{
		}

		public override ActionResult IsAble2SelectCard()
		{
			return default(ActionResult);
		}

		public void GetchooseMaterial(NetMsgBase.SuccessfulDelegate successAction)
		{
		}

		public int IsEnoughTimeGetWeaponMaterail()
		{
			return 0;
		}

		public int IsEnoughDiamondGetWeaponMaterail()
		{
			return 0;
		}

		public int GetCurrentWeaponMaterailNeedDiamond()
		{
			return 0;
		}

		public int SetWeaponTime()
		{
			return 0;
		}

		public override void OnTryStartBegin()
		{
		}

		public override void OnCombatExit()
		{
		}
	}
}
