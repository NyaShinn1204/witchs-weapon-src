using System;

namespace WaterBell.ProjX.View.Panel
{
	public class ConfirmPanel : UIPanelSingle
	{
		public enum IconTypes
		{
			Warning = 0,
			Error = 1
		}

		public enum SkinConfirm
		{
			Gold = 0,
			Diamond = 1,
			Draw = 2
		}

		private static ConfirmPanel current;

		public UISprite TitleIcon;

		public UISprite TitleBG;

		public UISprite Box;

		public UISprite Yes;

		public UISprite No;

		public UILabel titleLabel;

		public UILabel descLabel;

		public UILabel cancelButtonLabel;

		public UILabel confirmButtonLabel;

		public UISprite blackMask;

		public ButtonEx closeButton;

		public ButtonEx noButton;

		public ButtonEx yesButton;

		private Action ButtonYesClickEvent;

		private Action ButtonNoClickEvent;

		public UIToggle checkBox;

		public UILabel checkBoxRemind;

		private SkinConfirm currentSkin;

		protected override void Awake()
		{
		}

		private new void OnDestroy()
		{
		}

		public static ConfirmPanel GetInstance()
		{
			return null;
		}

		public void OpenPanel(string title, string desc, Action yesEventCallBack, Action noEventCallBack = null, IconTypes iconType = IconTypes.Warning, bool isShowBlackMask = true)
		{
		}

		public void OpenDiamondPanel(string title, string desc, SkinConfirm _skin, Action yesEventCallBack, Action noEventCallBack = null)
		{
		}

		private void OnButtonNoClick()
		{
		}

		private void OnButtonYesClick()
		{
		}

		private void DirectClosePanel()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}
	}
}
