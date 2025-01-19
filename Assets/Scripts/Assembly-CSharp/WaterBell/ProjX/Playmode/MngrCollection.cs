using System.Collections.Generic;
using UnityEngine;
using WaterBell.Framework.Event;
using WaterBell.ProjX.Level;
using WaterBell.ProjX.Level.Model;
using WaterBell.ProjX.View.UIFrame;

namespace WaterBell.ProjX.Playmode
{
	public class MngrCollection
	{
		private static MngrCollection _mc;

		internal MonoBehaviour rootMono;

		internal GameObject rootNode;

		internal BattlePlayerSettingManager playerSettingMngr;

		internal BattleFieldManager fieldMngr;

		internal BattleQuestManager questMngr;

		internal MonsterManager monsterMngr;

		internal Battle2DUIManager uiMngr;

		internal Battle3DMapManager mapMngr;

		internal UISceneManager sceneMngr;

		internal BattleDataStore dataStore;

		internal EntityPool entityPool;

		internal EventEngine evtEngine;

		internal InstanceSettingData eData;

		internal BattleResult battleResult;

		internal Dictionary<long, long> latestCard2weaponDict;

		public static MngrCollection GetInstance()
		{
			return null;
		}
	}
}
