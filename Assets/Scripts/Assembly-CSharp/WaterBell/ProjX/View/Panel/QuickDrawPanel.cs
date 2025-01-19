using System;

namespace WaterBell.ProjX.View.Panel
{
	public class QuickDrawPanel : UIPanelSingle
	{
		public enum State
		{
			Gold = 1,
			Gold10 = 2,
			Activity = 8,
			Activity10 = 9,
			Diamond = 3,
			Diamond10 = 4
		}

		public UIPopupList popupList;

		public State state;

		public ButtonEx drawButton;

		public ButtonEx stopButton;

		public ButtonEx closeButton;

		public UIPanelSingleContainer lootContainer;

		private DrawSystemManagerView drawView;

		private new void Start()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		private void OnChange()
		{
		}

		public static QuickDrawPanel GetInstance()
		{
			return null;
		}

		public void Stop()
		{
		}

		public void Draw()
		{
		}

		private void DrawLoop()
		{
		}

		public void OnDrawFinished()
		{
		}
	}
}
