using UniRx;

namespace WaterBell.ProjX.Data.Entity
{
	public class ReminderInfoHelper
	{
		private static int AchieveTotal;

		private static int StoryTotal;

		public static int GetAchieveTotal()
		{
			return 0;
		}

		public static int GetStoryTotal()
		{
			return 0;
		}

		public static bool CanReceiveQuest()
		{
			return false;
		}

		public static bool CanReceiveAchivement()
		{
			return false;
		}

		public static bool HaveNewMail()
		{
			return false;
		}

		public static bool HaveNewGuildRequest()
		{
			return false;
		}

		public static bool IsNeedToShowSvRedStarOnMainUIOrPhone()
		{
			return false;
		}

		public static bool CanComposeSv()
		{
			return false;
		}

		public static bool CanReceiveSvFavQuest()
		{
			return false;
		}

		public static bool HaveSvCanAddStar()
		{
			return false;
		}

		public static bool HaveSvCanAddRank()
		{
			return false;
		}

		public static bool HaveSvImageNew()
		{
			return false;
		}

		public static bool HaveSvImageReward()
		{
			return false;
		}

		public static bool HaveSvCanPromoteWpSpell()
		{
			return false;
		}

		public static Tuple<int, int> GetServantCompleteness()
		{
			return null;
		}

		public static Tuple<int, int> GetWeaponCompleteness()
		{
			return null;
		}

		public static Tuple<int, int> GetStoryCompleteness()
		{
			return null;
		}

		public static Tuple<int, int> GetAchieveCompleteness()
		{
			return null;
		}

		public static Tuple<int, int> GetDailyQuestCompleteness()
		{
			return null;
		}
	}
}
