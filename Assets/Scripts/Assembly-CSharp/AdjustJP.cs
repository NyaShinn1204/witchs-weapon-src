using System.Collections.Generic;

public class AdjustJP : GameAnalytics
{
	public const string JP_ADJUST_EVENT_ROLE_LOGIN = "cmig7e";

	public const string JP_ADJUST_EVENT_GUIDE_LVL1_BEGIN = "dwgw5g";

	public const string JP_ADJUST_EVENT_GUIDE_LVL1_WIN = "5vaevz";

	public const string JP_ADJUST_EVENT_GUIDE_NAME = "a72lbg";

	public const string JP_ADJUST_EVENT_GUIDE_NAME_FINISH = "udgvfm";

	public const string JP_ADJUST_EVENT_GUIDE_LVL2_BEGIN = "iekhz2";

	public const string JP_ADJUST_EVENT_GUIDE_LVL2_WIN = "k3bg01";

	public const string JP_ADJUST_EVENT_GUIDE_MAIN_MENU = "io1rcb";

	public const string JP_ADJUST_EVENT_GUIDE_LVL3_BEGIN = "srv3gi";

	public const string JP_ADJUST_EVENT_GUIDE_LVL3_WIN = "rh8qo3";

	public const string JP_ADJUST_EVENT_GUIDE_LVL4_BEGIN = "231blb";

	public const string JP_ADJUST_EVENT_GUIDE_LVL4_WIN = "c9tpi8";

	public const string JP_ADJUST_EVENT_GUIDE_LVL4_LOSE = "2hnw40";

	public const string JP_ADJUST_EVENT_LOGIN_REWARD = "34jbvu";

	public const string JP_ADJUST_EVENT_LVL1_4_BEGIN = "jmf5iv";

	public const string JP_ADJUST_EVENT_LVL1_4_WIN = "y0i0kf";

	public const string JP_ADJUST_EVENT_LVL1_5_BEGIN = "hbwu8f";

	public const string JP_ADJUST_EVENT_LVL1_5_WIN = "6vcvtx";

	public const string JP_ADJUST_EVENT_LVL1_6_BEGIN = "mlaptl";

	public const string JP_ADJUST_EVENT_LVL1_6_WIN = "eoqbjm";

	public const string JP_ADJUST_EVENT_STORY_A = "tn70wz";

	public const string JP_ADJUST_EVENT_STORY_B = "7izh1t";

	public const string JP_ADJUST_EVENT_STORY_C = "xt5vhd";

	public const string JP_ADJUST_EVENT_STORY_D = "l68kkz";

	public const string JP_ADJUST_EVENT_PURCHASE_14 = "xw7bpd";

	public const string JP_ADJUST_EVENT_PURCHASE_28 = "gi137h";

	public const string JP_ADJUST_EVENT_PURCHASE_56 = "exq75f";

	public const string JP_ADJUST_EVENT_PURCHASE_140 = "fi5wmi";

	public const string JP_ADJUST_EVENT_PURCHASE_280 = "2b6wk9";

	public const string JP_ADJUST_EVENT_PURCHASE_630 = "8vq295";

	public const string JP_ADJUST_EVENT_PURCHASE_1150 = "a5rttb";

	public const string JP_ADJUST_EVENT_PURCHASE_CARD = "9ibaae";

	public const string JP_ADJUST_EVENT_FAIL_PURCHASE_14 = "z6excz";

	public const string JP_ADJUST_EVENT_FAIL_PURCHASE_28 = "urkzob";

	public const string JP_ADJUST_EVENT_FAIL_PURCHASE_56 = "s9dbyg";

	public const string JP_ADJUST_EVENT_FAIL_PURCHASE_140 = "pa1aal";

	public const string JP_ADJUST_EVENT_FAIL_PURCHASE_280 = "b0kqkt";

	public const string JP_ADJUST_EVENT_FAIL_PURCHASE_630 = "iy8bbd";

	public const string JP_ADJUST_EVENT_FAIL_PURCHASE_1150 = "1m7s6y";

	public const string JP_ADJUST_EVENT_FAIL_PURCHASE_CARD = "kiok06";

	public Dictionary<string, string> eventsDifferedFromPlatforms;

	public const long FIRST_BATTLE_INSTANCE = 3150001001L;

	public override void Init()
	{
	}

	public override void TriggerEvent(string etype, string[] param)
	{
	}

	private string GetRevenueParams(string etype)
	{
		return null;
	}

	public override void TriggerEventPay(int amount)
	{
	}

	public override void TriggerEventLogin()
	{
	}

	public override void TriggerEventRoleLogin()
	{
	}

	public override void TriggerEventLevelUp(int level = 1)
	{
	}

	public override void TriggerEventGuide(int progress = -1)
	{
	}

	public override void TriggerEventUserRegist()
	{
	}

	private string GetNameFromType(string etype)
	{
		return null;
	}
}
