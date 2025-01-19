using System.Collections.Generic;
using LitJson;
using Svmod;
using WaterBell.ProjX.Data.Entity;

namespace WaterBell.ProjX.Data.NetIO
{
	public class JasonUtil
	{
		private const string BattleJasonfileName = "BattleJasonTemplate.txt";

		private static string BattleJasonpath;

		private static long sidBase;

		private static Dictionary<string, List<string>> JasonHeadConfig;

		private static int[] equipBit;

		private static long getNewSid()
		{
			return 0L;
		}

		public static long GetLong(JsonData data)
		{
			return 0L;
		}

		public static int GetInt(JsonData data)
		{
			return 0;
		}

		public static double GetDouble(JsonData data)
		{
			return 0.0;
		}

		public static string GetString(JsonData data)
		{
			return null;
		}

		public static string BattleJasonRecovery(string before)
		{
			return null;
		}

		private static JsonData GetNoErrorData(string responseText)
		{
			return null;
		}

		private static Dictionary<string, List<string>> getJasonBattleConfig()
		{
			return null;
		}

		private static void ReadMobConfig()
		{
		}

		public static JsonData TransJason(string tag, string orig)
		{
			return null;
		}

		public static ServantCore.SingleServant ParseSvData2SingleServant(ServantInstanceProto sv)
		{
			return null;
		}

		public static long[] parseEquip(int equipBitCode)
		{
			return null;
		}

		public static int[] parseWeaponSkin(long id, int weaponSkinBitCode)
		{
			return null;
		}

		public static int CombineEquip(bool[] equipSlotStateArr)
		{
			return 0;
		}

		public static void ParseRegistAndLoginJason(JsonData jsonValueData, string account, string uType, string nickName)
		{
		}

		public static void ParseRoleZoneJson(JsonData jsonValueData)
		{
		}
	}
}
