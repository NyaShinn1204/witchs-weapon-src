using System.Collections.Generic;
using Google.Protobuf.Collections;
using Lootmod;
using WaterBell.ProjX.Data.NetIO;

namespace WaterBell.ProjX.Data.Entity
{
	public class UserInfoHelper
	{
		public static readonly int PlayerMaxLevel;

		private static readonly int DRAW_TIMES_GOLD;

		private static readonly int DRAW_TIMES_DIAMOND;

		public static readonly int DRAW_COST_SINGLE_GOLD;

		public static readonly int DRAW_COST_MULTI_GOLD_TEN;

		public static readonly int DRAW_COST_SINGLE_DIAMOND;

		public static readonly int DRAW_COST_MULTI_DIAMOND;

		public static readonly int DRAW_COOLDOWN_GOLD;

		public static readonly long DRAW_COST_MULTI_SPECIAL;

		public static readonly int ACTIVE_CURRENCY_MAX;

		public static long WillConsumeDiamondNum;

		private static List<long> GOODS_RMB_DIAMOND;

		private static Dictionary<long, long> GoodToGoodPlus;

		static UserInfoHelper()
		{
		}

		public string CanLevelBattle(long LVID)
		{
			return null;
		}

		public static void AddExp(int exp)
		{
		}

		public static void AddVipExp(int exp)
		{
		}

		public static void AddLoot(LootList lootList)
		{
		}

		public static void AddShopGood(int type, long goods_id, int goods_value, int goods_num, int buy_num)
		{
		}

		public static void AddAchieveReward(long id)
		{
		}

		private static void AddReward(long questid, int type, long id, int value, int num)
		{
		}

		public static void AddOpenChestLoot(int type, long id, int num, long targetItem = 0L)
		{
		}

		public static void AddChestSVFashion(long id, long value)
		{
		}

		public static int GetWepaonSpellLevel(long weaponId, int weaponLevel)
		{
			return 0;
		}

		public static int GetWepaonSpellLevel(long weaponId)
		{
			return 0;
		}

		public static long GetShopSetTimeLeft(long id)
		{
			return 0L;
		}

		public static string CanBuyGold()
		{
			return null;
		}

		public static string CanBuyStamina()
		{
			return null;
		}

		public static string CanSweep(long instanceId, int time)
		{
			return null;
		}

		public static int ActivityDrawMultyArgu(long actID = 0L)
		{
			return 0;
		}

		public static string DrawCheckOrConsume(int needNumDraw, bool isConsume = false)
		{
			return null;
		}

		public static string CanDraw(DrawArgu arg)
		{
			return null;
		}

		public static List<long> GetGOODS_RMB_DIAMOND()
		{
			return null;
		}

		private static void InitGOODS_RMB_DIAMOND()
		{
		}

		public static Dictionary<long, long> GetGoodToGoodPlus()
		{
			return null;
		}

		public static bool ShipGoods(long goodID)
		{
			return false;
		}

		public static void DrawtListToDrawResultData(RepeatedField<LootObject> loots, List<DrawResultData> DrawLoot, List<DrawResultData> ExtraWeapon, List<long> currentSvLoots, List<long> currentWpLoots, List<long> currentFashionLoots)
		{
		}

		public static void LootToDrawResultData(LootList lootList, List<DrawResultData> DrawLoot, List<DrawResultData> ExtraWeapon, List<long> currentSvLoots, List<long> currentWpLoots, List<long> currentFashionLoots, bool needShowStamina = false)
		{
		}

		public static string IsInstanceSetUnlock(long instanceSet)
		{
			return null;
		}

		public static bool CanReceiveStamina()
		{
			return false;
		}

		public static int GetItemNum(long itemID)
		{
			return 0;
		}

		public static int GetGiftCouponNum()
		{
			return 0;
		}

		public static int CanChangeHead(int id)
		{
			return 0;
		}

		public static int CanChangeHeadBox(int id)
		{
			return 0;
		}

		public static string CanBuyFashion(long id)
		{
			return null;
		}

		public static string CanReceiveVip2Gift()
		{
			return null;
		}

		public static string CanReceiveVip5Gift()
		{
			return null;
		}

		public static int FreeGoldDrawMaxTime()
		{
			return 0;
		}

		public static int FreeGold10DrawMaxTime()
		{
			return 0;
		}

		public static int FreeRmbDrawMaxTime()
		{
			return 0;
		}

		public static int FreeGoldDrawRemainTime()
		{
			return 0;
		}

		public static int FreeRMBDrawRemainTime()
		{
			return 0;
		}

		public static bool CanChangeName()
		{
			return false;
		}

		public static string CanUseItem(long id, int num)
		{
			return null;
		}

		public static string CanOpenChestItem(long id, int num, int itemSubType, long TargetItem)
		{
			return null;
		}

		private static string CheckCanAddSvFashion(long svID, int Serial)
		{
			return null;
		}

		public static long GetTotalVipExp()
		{
			return 0L;
		}

		public static RepeatedField<LootObject> GenerateLootObjectListBySpecialServiceID(long id)
		{
			return null;
		}

		public static void RequstFakeMail(NetMsgSeq.FinishSeqHandler allFinishHandler = null)
		{
		}

		public static bool IsNeedRefreshFashion()
		{
			return false;
		}

		public static bool IsDiscountFashionOutOfDate()
		{
			return false;
		}

		public static void consumePriceCost(int type, int Cost, int num, double pricePercent, long itemID = 0L)
		{
		}

		public static bool CanReceiveTwCbtReward()
		{
			return false;
		}

		public static void ReceiveTwCbtReward(NetMsgBase.SuccessfulDelegate action)
		{
		}

		public static bool HaveInviteRewardToReceive()
		{
			return false;
		}
	}
}
