using System.Collections.Generic;
using WaterBell.ProjX.Level.Model;
using unit;

namespace WaterBell.ProjX.Level
{
	public class MonsterBornInfo
	{
		public string origPrefab;

		public string givenName;

		public int areaIdx;

		public int zoneIdx;

		public int waveIdx;

		public int subWaveIdx;

		public int seqIndex;

		public int groupID;

		public string summonData;

		public MobAppearType appearType;

		public bool isNeedExtraRecord;

		public const string TAG_TRIGGER_BOSS_WARNING = "boss_warning";

		public const string TAG_TRIGGER_CAMERA_ANIMATION = "cam_ani";

		public const string TAG_HP_BAR_STYLE1 = "hp_bar_style1";

		public const string TAG_HP_BAR_STYLE2 = "hp_bar_style2";

		public const int MOB_HPBAR_STYLE_DEFAULT = 0;

		public const int MOB_HPBAR_STYLE_BOSS = 1;

		public const int MOB_HPBAR_STYLE_NORMAL = 2;

		public bool tag_triggerCameraAnimation;

		public float tag_triggerCameraAnimationDuration;

		public bool tag_triggerBossWarningUI;

		public int tag_hpBarStyle;

		public static List<string[]> ai_taunt_list_collection;

		public int ai_taunt_list_index;

		public string ai_follow_target;

		public bool ai_can_be_taunt;

		public MonsterBornInfo(string prefab, string gName, int aIdx, int zIdx, int wIdx, int swIdx, int sIdx, int gID, int appearType = 1, bool isNeedExtraRecord = false)
		{
		}

		public static void InitAIConfig(AIInfo aiInfo)
		{
		}

		public static string[] GetAITauntList(MonsterEntity e)
		{
			return null;
		}
	}
}
