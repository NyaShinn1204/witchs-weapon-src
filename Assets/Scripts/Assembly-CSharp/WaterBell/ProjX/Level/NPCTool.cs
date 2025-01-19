using System.Collections.Generic;
using LitJson;
using UnityEngine;
using WaterBell.ProjX.Level.Model;
using unit;

namespace WaterBell.ProjX.Level
{
	public class NPCTool
	{
		public class NPCStatus
		{
			public int npc_spawn_mode;

			public int npc_status;

			public int npc_zoneIdx;

			public MonsterInfo mInfo;

			public GameObject npc_go;
		}

		public const int NPC_STATUS_NOT_SPAWNED = 0;

		public const int NPC_STATUS_INACTIVE = 1;

		public const int NPC_STATUS_INBATTLE = 2;

		public const int NPC_STATUS_DEAD = 3;

		public const int NPC_SPAWN_ONLOAD = 0;

		public const int NPC_SPAWN_ONENTERZONE = 1;

		public const int NPC_SPAWN_BEFORE_ENTERZONE = 2;

		public List<NPCStatus> npc_status;

		private static NPCTool instance;

		public static NPCTool GetInstance()
		{
			return null;
		}

		public void InitNPCInfo(NPCInfo[] info)
		{
		}

		public bool isNPC(MonsterEntity m)
		{
			return false;
		}

		public void CheckAndLoadNPC(ZoneState zone)
		{
		}

		public void OnMonsterPerished(MonsterEntity mon)
		{
		}

		private void RestoreNPCInfo(JsonData json)
		{
		}

		public void SaveNPCInfo(JsonWriter jw)
		{
		}

		private void WriteNPCItem(JsonWriter jw, int status, float hp)
		{
		}
	}
}
