using System;
using UnityEngine;
using WaterBell.ProjX.Data.Entity;

namespace WaterBell.ProjX.View.Panel
{
	public class ServantLevelUpPanel : UIPanelSingle
	{
		public static ServantLevelUpPanel current;

		public UIResSpriteExGrid expItemContainer;

		public BarBase expBar;

		public GameObject levelUpAnimItem;

		public UIPanel emptyTips;

		public GameObject levelUpEffect;

		public ButtonEx closeButton;

		public ButtonEx closeBG;

		public Action OnCloseEvent;

		private ExpDevelopInfo expDevelopInfo;

		private SingleServantAddExpView singleServantAddExpView;

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void LevelChangeEvent(BarBase bar)
		{
		}

		private void HideLevelUpEffect()
		{
		}

		public void OpenPanel(Action onCloseEvent = null)
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		public void BindUFrame()
		{
		}

		public void Use(ExpProps expProps, int num)
		{
		}
	}
}
