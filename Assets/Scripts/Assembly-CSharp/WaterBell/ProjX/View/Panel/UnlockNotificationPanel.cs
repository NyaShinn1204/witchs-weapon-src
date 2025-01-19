using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class UnlockNotificationPanel : UIPanelSingle
	{
		private static readonly string perfabPath;

		private static UnlockNotificationPanel s_Current;

		public Transform effectContainer;

		public UILabel contentLabel;

		public float duration;

		private Action m_OnOpenEvent;

		private Action m_OnCloseEvent;

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		public static UnlockNotificationPanel GetInstance()
		{
			return null;
		}

		public void OpenPanel(UnlockNotificationPanelData data, Action onOpenEvent = null, Action onCloseEvent = null)
		{
		}

		private void ClosePanelDelay()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}
	}
}
