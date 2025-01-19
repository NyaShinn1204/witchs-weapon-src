using System.Collections.Generic;

namespace WaterBell.LevelDesign
{
	public class PlayerCfgSimulator
	{
		private static PlayerCfgSimulator _instance;

		public int roleLv;

		public string[] svParamArr;

		public string[] wpParamArr;

		private LevelMobFilter mobFilter;

		private Dictionary<int, PlayerAblitySetting> playerAblitySettingDict;

		private Dictionary<int, ServantAblitySetting> svAblitySettingDict;

		public static PlayerCfgSimulator GetInstance()
		{
			return null;
		}

		public string GetRoleParam(string roleIDStr)
		{
			return null;
		}

		private void ClearData()
		{
		}

		public bool CaculateData(long levelID, long[] svCardIDArr, long[] wpIDArr)
		{
			return false;
		}

		public void RefreshData()
		{
		}

		private void InitParseCSV()
		{
		}

		private void ParseServantAblitySettingCSV()
		{
		}

		private void ParsePlayerAblitySettingCSV()
		{
		}

		public string[] GetServantDataFromConfig(ServantAblitySetting sas)
		{
			return null;
		}

		public ServantAblitySetting GetAbilitySettings(int playerLevel, int servantSlotIndex)
		{
			return null;
		}

		internal void PrepareCoreData(int roleLevel, long[] cads, long[] weapons, SvAdjGroupSlot[] slots)
		{
		}
	}
}
