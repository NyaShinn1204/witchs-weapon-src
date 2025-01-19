using System;

namespace WaterBell.ProjX.View.Panel
{
	[Serializable]
	public class AP5_LevelStateIconData : UIDataBase
	{
		public bool isCurrentProgress;

		public bool isLast;

		public bool hasExtraAward;

		public bool isClear;

		public AP5TowerType towerType;

		public AP5TowerLayerKind layerKind;

		public int currentTowerType;

		public AP5_LevelStateIconData(long level, bool isCurrentProgress, bool isLast, bool hasExtraAward, bool isClear, AP5TowerType towerType, AP5TowerLayerKind layerKind, int currentTowerType)
		{
		}
	}
}
