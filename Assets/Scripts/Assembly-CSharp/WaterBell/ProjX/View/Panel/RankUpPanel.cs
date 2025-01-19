using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class RankUpPanel : UIPanelSingle
	{
		public static RankUpPanel current;

		public UISprite rankIconPrev;

		public UISprite rankIconCurrent;

		public UILabel rankNumPrev;

		public UILabel rankNumCurrent;

		public UILabel prevCHPLabel;

		public UILabel currentCHPLabel;

		public UILabel prevCombatScoreLabel;

		public UILabel currentCombatScoreLabel;

		public ButtonEx closeButton;

		public UISprite spellIcon;

		public UILabel spellNameLabel;

		public GameObject spellContainer;

		public GameObject effSource;

		private GameObject eff;

		protected override void Awake()
		{
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

		public void PlayUnlokSound()
		{
		}
	}
}
