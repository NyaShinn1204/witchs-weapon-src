using System;
using System.Collections.Generic;

namespace WaterBell.ProjX.View.Panel
{
	public class AP4_AwardPanel : UIPanelSingle
	{
		public ButtonEx closeButton;

		public UIPanelSingleContainer buff;

		public UIPanelSingleContainer loot;

		public UIPanelSingleContainer extra;

		public UIGrid mainGrid;

		public UILabel victory1Label;

		public UILabel victory2Label;

		public UILabel victory3Label;

		public UILabel victory4Label;

		public UILabel scoreLabel;

		public UIPanel effectPanel;

		private Action OnCloseCallback;

		private bool isInputEnabled;

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		private void CallClosePanel()
		{
		}

		public void OpenPanel(List<AGMF_AwardData> buffData, Action onCloseCallback)
		{
		}
	}
}
