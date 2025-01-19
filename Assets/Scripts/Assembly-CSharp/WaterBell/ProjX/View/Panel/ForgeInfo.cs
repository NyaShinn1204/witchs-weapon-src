using System.Collections.Generic;

namespace WaterBell.ProjX.View.Panel
{
	public class ForgeInfo
	{
		public long id;

		public int needGold;

		public int depth;

		public int num;

		public List<ForgeNeedNum> infoList;

		public long[] levelArray;

		public long[] shopArray;

		public long store;

		public ForgeInfo target;

		public List<ForgeInfo> forgeInfoList;

		public int maxStack;

		public ForgeInfo parent;

		public ForgeInfo(long id)
		{
		}

		public static void UpdateNum(ForgeInfo info)
		{
		}

		private static List<ForgeInfo> AnalyCurrentStep(ForgeInfo info)
		{
			return null;
		}

		public static List<ForgeInfo> AnalyAllStep(ForgeInfo info)
		{
			return null;
		}

		public static void UpdateAllStepNum(ForgeInfo info)
		{
		}

		public static long[] GetShopWays(long itemOrEquip)
		{
			return null;
		}

		public static long[] GetInstanceWays(long itemOrEquip)
		{
			return null;
		}
	}
}
