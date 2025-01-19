using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class AcquiringWay : UIPanelSingle
	{
		[Space]
		public Article currentArticle;

		public UIPanelSingleContainer levelContainer;

		public UILabel needCountLabel;

		private ForgeInfo currentForgeInfo;

		private ServantEquipSweepView servantEquipSweepView;

		private SweepArgu cacheSweepArgu;

		public static AcquiringWay current;

		protected override void Start()
		{
		}

		private void OnSweep(SweepArgu sweepArgu)
		{
		}

		public void SweepSuccessful()
		{
		}

		public void OpenPanel(ForgeInfo currentInfo)
		{
		}

		public override void UpdatePanel()
		{
		}

		private void OnGotoWay(LevelButtonItem levelButton)
		{
		}
	}
}
