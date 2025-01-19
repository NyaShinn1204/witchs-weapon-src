using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class SettlementTask : UIPanelSingle
	{
		public UILabel mainTaskTitleLabel;

		public UIPanelSingleContainer mainTasks;

		public GameObject sweepConditionsIcon;

		public UILabel sweepConditionsLabel;

		public GameObject sweepConditionsGo;

		public long instanceId;

		public bool isDebug;

		private List<SUT_ItemData> mainTaskDataList;

		public override void UpdatePanel()
		{
		}

		private void UpdateMonsterKillList()
		{
		}

		private int ConvertInt(string str)
		{
			return 0;
		}

		private void UpdateProtectionList()
		{
		}
	}
}
