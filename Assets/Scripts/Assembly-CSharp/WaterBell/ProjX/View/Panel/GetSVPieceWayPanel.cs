using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class GetSVPieceWayPanel : UIPanelSingle
	{
		public Transform iconContainer;

		public TweenPosition detailTweener;

		public UILabel nameLabel;

		public UILabel numLabel;

		public UILabel topDescLabel;

		public UILabel bottomDescLabel;

		public ButtonEx closeWayButton;

		public ButtonEx openWayButton;

		public ButtonEx closeButton;

		public TweenPosition wayTweener;

		public UIPanelSingleContainer instanceContainer;

		private ServantStarSweepView servantStarSweepView;

		private SweepArgu cacheSweepArgu;

		private List<LevelButtonItemData> wayDataList;

		protected override void Awake()
		{
		}

		public void OpenPanelTest(string id)
		{
		}

		public void OpenPanel(long pieceId)
		{
		}

		public void SweepSuccessful()
		{
		}

		private void OnSweep(SweepArgu sweepArgu)
		{
		}

		private void OnGotoWay(LevelButtonItem levelButton)
		{
		}

		private void OpenWayPanel()
		{
		}

		private void CloseWayPanel()
		{
		}
	}
}
