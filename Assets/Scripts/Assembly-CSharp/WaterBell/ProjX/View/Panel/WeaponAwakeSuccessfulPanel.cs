using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class WeaponAwakeSuccessfulPanel : UIPanelSingle
	{
		public WeaponButtonItem prev;

		public WeaponButtonItem current;

		public ButtonEx closeButton;

		public GameObject effSource;

		private GameObject eff;

		private Action OnCloseEvent;

		protected override void Awake()
		{
		}

		public void OpenPanel(long weaponId, Action OnCloseEvent = null)
		{
		}

		public void OpenPanel(Action onCloseEvent = null)
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}
	}
}
