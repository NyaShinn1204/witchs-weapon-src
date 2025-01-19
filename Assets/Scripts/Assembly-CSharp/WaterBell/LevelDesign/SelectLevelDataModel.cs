using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.LevelDesign
{
	public class SelectLevelDataModel
	{
		private SelectLevelDataProvider dataProvider;

		private static SelectLevelDataModel _instance;

		public HeaderRow levelSetHeaderRow;

		public HeaderRow levelDetailHeaderRow;

		public List<CustomDataRow> levelSetDataList;

		public Dictionary<long, List<CustomDataRow>> levelDetailDataMap;

		public Vector2 levelSetScrollPos;

		public Vector2 levelDetailScrollPos;

		public int lastLevelSetIdx;

		public int currLevelSetIdx;

		public int lastLevelDetailIdx;

		public int currLevelDetailIdx;

		public readonly long coreLevelSetID;

		private bool isPreparedLevelData;

		private long currLevelSetID
		{
			get
			{
				return 0L;
			}
		}

		public long currLevelDetailID
		{
			get
			{
				return 0L;
			}
		}

		public LevelDetailDataRow currLevelDetailDataRow
		{
			get
			{
				return null;
			}
		}

		private SelectLevelDataModel()
		{
		}

		public static SelectLevelDataModel GetInstance()
		{
			return null;
		}

		public void RefreshData()
		{
		}

		public void PrepareLevelData(bool isForceRefresh = false)
		{
		}

		public string getCurrLevelDetialAttachedName()
		{
			return null;
		}

		public string getCurrLevelSetName()
		{
			return null;
		}

		public bool isSelectedLevelValid()
		{
			return false;
		}

		public bool isSelectedLevelJsonFileExist()
		{
			return false;
		}

		public bool isSelectedLevelOldJsonFileExist()
		{
			return false;
		}

		public bool isSelectedLevelU3DFileExist()
		{
			return false;
		}

		public List<CustomDataRow> getCurrLevelDetailDataList()
		{
			return null;
		}

		public string GetCurrLevelMobsIDSetStr()
		{
			return null;
		}
	}
}
