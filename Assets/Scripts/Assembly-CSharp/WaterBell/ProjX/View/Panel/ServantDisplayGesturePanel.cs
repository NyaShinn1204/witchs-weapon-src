using System;

namespace WaterBell.ProjX.View.Panel
{
	public class ServantDisplayGesturePanel : UIPanelSingle
	{
		private const int MAX_COUNT_ONE_SCREEN = 6;

		private const string PREFAB_PATH = "UI/Prefab/ServantDisplayGesturePanel";

		private static ServantDisplayGesturePanel current;

		public ButtonEx prevButton;

		public ButtonEx nextButton;

		public ButtonEx closeButton;

		public UIPanelSingleContainer items;

		private long selectID;

		private int index;

		private UserPlayerManagerView userPlayerManagerView;

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		public static ServantDisplayGesturePanel GetInstance()
		{
			return null;
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		public override void UpdatePanel()
		{
		}

		public void OnItemClick(long id)
		{
		}
	}
}
