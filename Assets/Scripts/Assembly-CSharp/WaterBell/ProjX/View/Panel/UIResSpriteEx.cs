using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class UIResSpriteEx : UIPanelBase
	{
		public enum ViewBlock
		{
			Top = 0,
			Mid = 1,
			Bot = 2
		}

		public enum DepthPref
		{
			BeFront = 0,
			BeBack = 1
		}

		public enum NumTextStyle
		{
			None = 0,
			SimpleCount = 1,
			GoodCount = 2,
			Consume = 3,
			Compose = 4,
			Hide = 5
		}

		public enum NumPosStyle
		{
			None = 0,
			InternalBottomRight = 1,
			ExternalBottom = 2
		}

		public static UIResSpriteEx currentSingleSelected;

		[SerializeField]
		protected UIRawResData resData;

		public UIResButtonEx mainItemBtnEx;

		internal Transform selfTrans;

		internal Transform topBlock;

		internal Transform midBlock;

		internal Transform botBlock;

		internal UISprite selectedSprite;

		internal UISprite superScriptSprite;

		internal UISprite iconSprite;

		internal UISprite iconFrameSprite;

		internal UISprite weaponRare;

		internal UILabel numLabel;

		private NumTextStyle currNumTextStyle;

		public bool isShowTip;

		protected bool isAllowDragScrillView;

		public bool isAllowSelected;

		public bool hasClickAction;

		protected bool isAutoAjustNumFontSize;

		protected bool isMultiSelected;

		private static Vector3 NumInternalBottomRight;

		private static Vector3 NumExternalBottom;

		public override UIDataBase Data
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void Bind(UIDataBase data)
		{
		}

		public override void UpdatePanel()
		{
		}

		protected override void Awake()
		{
		}

		protected virtual void BindChildrenNode()
		{
		}

		protected virtual void InitConfig()
		{
		}

		protected virtual void ConfigBtnEx()
		{
		}

		private void LoadDefaultSetting()
		{
		}

		public void SetNumLabelStyle(NumTextStyle txtStyle, NumPosStyle posStyle)
		{
		}

		public void SetNumLabelTxt(long baseNum)
		{
		}

		public static bool ShowNum(UIRawResData data)
		{
			return false;
		}

		public void SetNumLabelTxt(long currNum, long baseNum)
		{
		}

		private void OnClickHandler()
		{
		}

		protected virtual void OnClickAction()
		{
		}

		public void OnSelected()
		{
		}

		private void DeSelected()
		{
		}

		public void ClearSelected()
		{
		}
	}
}
