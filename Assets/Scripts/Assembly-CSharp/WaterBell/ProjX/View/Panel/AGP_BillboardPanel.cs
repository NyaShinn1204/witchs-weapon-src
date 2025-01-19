using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class AGP_BillboardPanel : UIPanelSingle
	{
		public UILabel indexLabel;

		public UILabel roleLabel;

		public UILabel scoreLabel;

		public UILabel myIndexLabel;

		public UILabel pointLabel;

		public UILabel myCurrencyLabel;

		public UILabel myIndexValueLabel;

		public UILabel myScoreValueLabel;

		public UIPanelSingleContainer items;

		public GameObject selectBox;

		public ButtonEx closeButton;

		public UILabel notesLabel;

		private ActivityPlayRankView activityPlayRankView;

		protected override void Awake()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public override void UpdatePanel()
		{
		}
	}
}
