using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;

namespace WaterBell.ProjX.Level
{
	public class BattlePlayerSettingManager
	{
		[StructLayout(LayoutKind.Sequential, Size = 40)]
		public struct SvUIInfo
		{
			public long svCardID;

			public long wpID;

			public int rank;

			public int star;

			public int lv;

			public long rid;

			public SvUIInfo(long cardID, long weaponID, int lv, int rankLv, int starLv, long rid)
			{
				svCardID = 0L;
				wpID = 0L;
				rank = 0;
				star = 0;
				this.lv = 0;
				this.rid = 0L;
			}
		}

		private static BattlePlayerSettingManager _instance;

		private static Dictionary<string, GameObject> callSkillServantDic;

		private static Dictionary<string, GameObject> servantDic;

		private List<SvUIInfo> currSvInfoList;

		public bool isLoadAtlas;

		public bool isLoadServantFinish;

		public bool isLoadWeaponsFinished;

		public static BattlePlayerSettingManager GetInstance()
		{
			return null;
		}

		public List<SvUIInfo> GetCurrSvInfoList()
		{
			return null;
		}

		public static GameObject GetServantByName(string name)
		{
			return null;
		}

		public static GameObject GetCallSkillServantByName(string servantPrefabName)
		{
			return null;
		}

		public void SetAllServants(long[] cardIDArr, long[] wpIDArr)
		{
		}

		public void SetAllServants(SvUIInfo[] infoList)
		{
		}

		[DebuggerHidden]
		public IEnumerator LoadUIAtlas()
		{
			return null;
		}

		[DebuggerHidden]
		public IEnumerator LoadServants2(BattlePreloadingData data)
		{
			return null;
		}

		public void LoadServants()
		{
		}

		private void Try2LoadAndCacheCallSkillServant(string servantPrefabName)
		{
		}

		[DebuggerHidden]
		public IEnumerator LoadWeapons2(BattlePreloadingData data)
		{
			return null;
		}

		public void ReloadServants()
		{
		}
	}
}
