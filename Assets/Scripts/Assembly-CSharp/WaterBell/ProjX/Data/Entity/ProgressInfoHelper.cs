using UniRx;
using WaterBell.ProjX.Playmode;

namespace WaterBell.ProjX.Data.Entity
{
	public class ProgressInfoHelper
	{
		private static int CurrentDay
		{
			get
			{
				return 0;
			}
		}

		public static bool isInstanceSetUnLock(long set)
		{
			return false;
		}

		public static bool isInstanceUnLock(long id)
		{
			return false;
		}

		public static string CanRestBattleCount(long arg)
		{
			return null;
		}

		public static string CanFightWeaponMaterialLevel(long id)
		{
			return null;
		}

		public static string CanSetTargerWeapon(long id)
		{
			return null;
		}

		public static string CanOpenSetWeaponPanel()
		{
			return null;
		}

		public static ActionResult IsAllowShowSweepGameOnce(long instanceID)
		{
			return default(ActionResult);
		}

		public static ActionResult IsAllowShowSweepGameMultiTime(long instanceID)
		{
			return default(ActionResult);
		}

		public static ActionResult IsAble2SweepGameOnce(long instanceID)
		{
			return default(ActionResult);
		}

		public static ActionResult IsAble2SweepGameMultiTime(long instanceID)
		{
			return default(ActionResult);
		}

		public static Tuple<ActionResult, int, int> SetSweepState(long instanceID, int count = -1, bool isIgnoreStamina = false)
		{
			return null;
		}

		public static ActionResult IsAllow2Fight(long instanceID)
		{
			return default(ActionResult);
		}

		public static string GetTipsText(ActionResult result)
		{
			return null;
		}

		public static string GetDailyErrorCode(long _instanceID)
		{
			return null;
		}

		public static bool IsPlayTrialToday(long _chapterID)
		{
			return false;
		}

		public static bool IsPlayTaskToday(long _chapterID)
		{
			return false;
		}

		private static bool CanPlay(int number, string _key)
		{
			return false;
		}

		public static void TrackJPStoryLine(long instanceID, bool isBegin, bool isWin)
		{
		}
	}
}
