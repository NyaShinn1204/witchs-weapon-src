using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class BossEnter : UIPanelSingle
	{
		public GameObject effectSourc;

		private GameObject effect;

		private Action OnCloseEvent;

		private UIPanel panel;

		protected override void Awake()
		{
		}

		private new void OnDisable()
		{
		}

		public void OpenPanel(long bossID, Action onCloseEvent)
		{
		}

		private void ClosePanel()
		{
		}
	}
}
