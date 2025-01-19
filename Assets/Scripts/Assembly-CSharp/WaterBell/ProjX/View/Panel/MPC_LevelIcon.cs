using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class MPC_LevelIcon : UIPanelSingle
	{
		private const string NORMAL_LEVEL_ICON = "UI/Prefab/BattleMap/NormalLevelIcon";

		private const string HARD_LEVEL_ICON = "UI/Prefab/BattleMap/HardLevelIcon";

		private const string PORTAL_BUTTON = "UI/Prefab/BattleMap/PortalButton";

		private const string BASE_LEVEL_ICON = "UI/Prefab/BattleMap/BaseLevelIcon";

		public TypeCsvInstance instanceTableData;

		public ButtonEx button;

		private PositionSync positionSync;

		private MPC_LevelPos levelPos;

		protected override void Awake()
		{
		}

		protected virtual void Init(TypeCsvInstance instanceTableData, MPC_LevelPos levelPos, Camera targetCamera)
		{
		}

		public static MPC_LevelIcon Create(TypeCsvInstance instanceTableData, GameObject parent, MPC_LevelPos levelPos, Camera targetCamera)
		{
			return null;
		}
	}
}
