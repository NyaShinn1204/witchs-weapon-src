using UnityEngine;

namespace WaterBell.LevelDesign
{
	public class MonsterAttr : MonoBehaviour
	{
		public const int DEFAULT_CAMP_FOR_HERO = 0;

		public const int DEFAULT_CAMP_FOR_MONSTER = 1;

		public const int DEFAULT_CAMP_FOR_FRIENDLY_NPC = 2;

		private Color normalCol;

		private Color normalCol2;

		private Color eliteCol;

		private Color eliteCol2;

		private Color bossCol;

		private Color bossCol2;

		private Vector3 iconPos;

		private float iconRadius;

		public static int DefaultGroupID;

		public string mName;

		public string givenName;

		public int powerRank;

		public int mobTypeID;

		public int currLv;

		public long id;

		public string idStr;

		public bool isDataInited;

		public int campOption;

		public int npc_spawn_mode;

		public int npc_zoneIdx;

		public int ai_config_taunt_list_index;

		public bool ai_config_can_be_taunt;

		public string ai_config_follow_target;

		public int groupID;

		public int mobHPBarStyle;

		public float mobTriggerCameraDuration;

		public bool mobTriggerCameraAni;

		public bool mobTriggerBossWarningUI;

		public string statID
		{
			get
			{
				return null;
			}
		}

		private void Start()
		{
		}

		public void CloneDataRow(MobDataRow mobDataRow)
		{
		}

		public void SetAttrByStatID(string statID)
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
