using System;
using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class HeroClothPanel : UIPanelSingle
	{
		public static HeroClothPanel current;

		public UIPanelSingleContainer clothsContainer;

		public ButtonEx confirmButton;

		public ButtonEx unlockButton;

		public UILabel nameLabel;

		public UILabel descLabel;

		public UILabel needClothMoneyLabel;

		public Camera photoCam;

		public UITexture photoTex;

		public LoadUIPanelSingle unlockConfirmLoader;

		public UILabel activityLabel;

		public UISprite activityIcon;

		protected RenderTexture photoRT;

		public Action<long> OnSelectSkin;

		private FashionForBattleView fashionForBattleView;

		private List<SgcClothItemData> clothDataList;

		private long selectID;

		public Transform discountTrans;

		public UILabel newNum;

		public UILabel oldNum;

		public UILabel endTime;

		private long discountEndTime;

		public UIScrollView scroll;

		public string modelName;

		protected override void Awake()
		{
		}

		private new void OnEnable()
		{
		}

		private new void OnDisable()
		{
		}

		protected override void OnDestroy()
		{
		}

		public void OpenPanel(long clothID)
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public override void UpdatePanel()
		{
		}

		private int CanUnlock(long clothID)
		{
			return 0;
		}

		private void OnUnlockButtonClick()
		{
		}

		public virtual void Select(long clothID)
		{
		}

		private void ReFreshEndTime()
		{
		}

		private void OnConfirmButtonClick()
		{
		}
	}
}
