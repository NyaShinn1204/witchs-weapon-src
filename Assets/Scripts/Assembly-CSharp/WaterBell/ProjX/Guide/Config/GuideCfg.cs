namespace WaterBell.ProjX.Guide.Config
{
	public class GuideCfg
	{
		public enum System_CMDSet
		{

		}

		public enum Player_CMDSet
		{

		}

		public static readonly string GuideLocalFolderPath;

		public static readonly string LessonFileNamePrefix;

		public static readonly string LessonFileTypeInfo;

		public static readonly string PrefabPathPrefix;

		public static readonly string GuideImgPathPrefix;

		public static readonly string GuideAtlasPathPrefix;

		public static readonly float AnimTimeMax;

		public static readonly float AnimBgTimeMax;

		public static readonly string[] LoginFileArr;

		private static readonly string[] BattleInfoFileArr;

		private static readonly string BattleLootFile;

		public static readonly string[] BattleConstFileArr;

		public static readonly string[] LotteryFileArr;

		public static readonly string FirstAchieveFile;

		public static readonly string BattleServantLootUpdateFile;

		public static string GetLessonJsonFileName(string lessonFileNameSubfix)
		{
			return null;
		}

		public static bool CheckCampLevelID(long levelID)
		{
			return false;
		}

		public static string[] GetBattleInfoFileArr(int battleNO)
		{
			return null;
		}

		public static string GetBattleLootFile(int battleNO)
		{
			return null;
		}

		public static string GetLotteryFile(bool isLeftBtn)
		{
			return null;
		}
	}
}
