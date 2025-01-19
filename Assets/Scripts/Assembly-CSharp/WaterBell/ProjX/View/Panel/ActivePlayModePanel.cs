using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class ActivePlayModePanel : UIPanelSingle
	{
		public ButtonEx activityButton;

		public ButtonEx materialButton;

		public ButtonEx billboardButton;

		public ButtonEx activityStoryButton;

		public ButtonEx taskButton;

		public ButtonEx storeButton;

		public ButtonEx activityLotteryButton;

		public ButtonEx helpButton;

		public UILabel maxLayerLabel;

		public UILabel scoreLabel;

		public UILabel rankingIconLabel;

		public UILabel battleCountLabel;

		public UITexture drawAD;

		public UITexture storyImage;

		public UISprite activityIcon;

		public UILabel activityNameLabel;

		public UIWidget currencyIcon;

		public UIWidget materialIcon;

		public UILabel materialTitleLabel;

		public UILabel materialTitleLabel_2;

		public GameObject taskPoint;

		public GameObject storyNewIcon;

		public LoadUIPanelSingle billboardLoader;

		public LoadUIPanelSingle activityDetailLoader;

		public UITexture bgTex;

		public UILabel activityMainButtonLabel;

		public UILabel activityGuideIconLabel;

		private QuestForAPView questForAPView;

		private ActivityPlayRootView activityPlayRootView;

		protected override void Awake()
		{
		}

		public override void UpdatePanel()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}
	}
}
