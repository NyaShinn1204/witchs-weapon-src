public class KochavaTW : GameAnalytics
{
	public const string TW_EVENT_MAP_1_10 = "map1-10";

	public const string TW_EVENT_MAP_2_10 = "map2-10";

	public const string TW_EVENT_MAP_5_10 = "map5-10";

	public const string TW_EVENT_1ST_10DRAW = "1st Tenfold Draw";

	public const string TW_EVENT_10DRAW = "Tenfold Draw";

	public const string TW_EVENT_CHAPTER1 = "Chapter1";

	public const string TW_EVENT_CHAPTER2 = "Chapter2";

	public const string TW_EVENT_CHAPTER3 = "Chapter3";

	public const long MAP_1_10 = 3110001010L;

	public const long MAP_2_10 = 3110002010L;

	public const long MAP_5_10 = 3110005010L;

	public const long EVENT_CHAPTER1 = 61100011006L;

	public const long EVENT_CHAPTER2 = 61100021027L;

	public const long EVENT_CHAPTER3 = 61100031016L;

	public void TriggerKochavaEvent(string etype, string roleId, string roleLevel)
	{
	}

	public override void TriggerEvent(string etype, string[] param)
	{
	}
}
