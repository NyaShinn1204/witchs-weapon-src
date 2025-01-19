using System;
using System.Collections.Generic;

namespace WaterBell.ProjX.View.Panel
{
	public class LootPanel : UIPanelSingle
	{
		public ButtonEx closeButton;

		public UIPanelSingleContainer lootContainer;

		private Action<LootPanel> OnCloseEvent;

		protected override void Start()
		{
		}

		private void Update()
		{
		}

		public void OpenPanel<T>(List<T> dataList, Action<LootPanel> onCloseEvent = null) where T : UIRawResData
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}
	}
}
