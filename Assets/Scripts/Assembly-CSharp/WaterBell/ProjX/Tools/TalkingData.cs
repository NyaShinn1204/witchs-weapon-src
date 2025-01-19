namespace WaterBell.ProjX.Tools
{
	public class TalkingData
	{
		public const int EVENT_TYPE_LOGIN = 0;

		public const int EVENT_TYPE_REGISTER = 1;

		public const int EVENT_TYPE_CHANGE_ACC = 2;

		public const int EVENT_TYPE_LEVEL = 3;

		public const int EVENT_TYPE_CHARGE_REQUEST = 4;

		public const int EVENT_TYPE_CHARGE_SUCCESS = 5;

		public const int EVENT_TYPE_REWARD = 6;

		public static void SendLoginEvent(string userId, string username, string gameserver)
		{
		}

		public static void SendRegEvent(string userId, string username)
		{
		}

		public static void SendLevelUp(int level)
		{
		}

		public static void SendChargeRequest(string orderId, string itemname, string price, string amount, string paymentType)
		{
		}

		public static void SendChargeSuccess(string orderId)
		{
		}
	}
}
