using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class WeaponIntensifySuccessfulPanel : UIPanelSingle
	{
		public UILabel currentLevelLabel;

		public UILabel prevLevelLabel;

		public UILabel atkLabel;

		public UILabel prevAtkLabel;

		public UILabel prevMatkLabel;

		public UILabel matkLabel;

		public ButtonEx closeButton;

		public GameObject effSource;

		private GameObject eff;

		private Action onCloseEvent;

		protected override void Awake()
		{
		}

		public void OpenPanel(long weaponId, int level, int prevLevel, long atk, long prevAtk, long MATK, long prevMATK, Action onCloseEvent = null)
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
