using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class AGMO_DetailPanel : UIPanelSingle
	{
		[Serializable]
		[StructLayout(LayoutKind.Sequential, Size = 24)]
		private struct PropLevelInfo
		{
			public int propID;

			public long level;

			public long targetLevel;

			public PropLevelInfo(long level, long targetLevel, int propID)
			{
				this.propID = 0;
				this.level = 0L;
				this.targetLevel = 0L;
			}

			public void Set(long level, long targetLevel, int propID)
			{
			}
		}

		private static long myCurrency;

		public UISprite currencyIcon;

		public UISprite currencyIcon2;

		public UISprite currencyIcon3;

		public UILabel bingLingLabel;

		public UILabel pointLabel;

		public UITexture bgTex;

		public GameObject addPorpContainer;

		public GameObject resetContriner;

		public UILabel propAddRuleLabel;

		public UIPanelSingleContainer buffs;

		public UILabel buffCountLabel;

		public UILabel buffDescLabel;

		public UILabel needCurrencyTotalLabel;

		public UILabel needPointLabel;

		public UILabel needBingLingLabel;

		public UILabel needCurrencyTotalTitleLabel;

		public UILabel needPointTitleLabel;

		public UILabel needBingLingTitleLabel;

		public UIPanelSingleContainer propAdds;

		public ButtonEx cancelButton;

		public ButtonEx saveButton;

		public ButtonEx resetButton;

		public ButtonEx backButton;

		public ButtonEx storeButton;

		public ButtonEx homeButton;

		public UILabel resetNeedBingLingTitleLabel;

		public UILabel resetNeedBingLingLabel;

		public UILabel resetCdLabel;

		[SerializeField]
		private List<AGMO_PropAddItemData> propAddDataList;

		[SerializeField]
		private List<LotteryLootData> buffDataList;

		[SerializeField]
		private int buffCount;

		[SerializeField]
		private int buffOwn;

		[SerializeField]
		private long bingLingCount;

		[SerializeField]
		private long pointCount;

		[SerializeField]
		private long currencyTotalCount;

		[SerializeField]
		private long needBingLingCount;

		[SerializeField]
		private long needPointCount;

		[SerializeField]
		private long resetNeedBingLing;

		[SerializeField]
		private long resetCD;

		[SerializeField]
		private int activitySerial;

		[SerializeField]
		private long needCurrencyTotal;

		[SerializeField]
		private PropLevelInfo[] propLevelInfos;

		[SerializeField]
		private int attrPointPrice;

		[SerializeField]
		public bool isDebug;

		private ActivityPlayAttributeView activityPlayAttributeView;

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		private void BackButtonClick()
		{
		}

		private bool IsSavePoint()
		{
			return false;
		}

		private void CancelPropButtonClick()
		{
		}

		private void PropAddInit()
		{
		}

		private void SyncPropLevelInfos()
		{
		}

		private void CancelProp()
		{
		}

		private void ResetPropButtonClick()
		{
		}

		public void ResetPropFinish()
		{
		}

		private void SavePropButtonClick()
		{
		}

		public void SavePropFinish()
		{
		}

		public override void UpdatePanel()
		{
		}

		public static string CanPreAdd(long targetLevel, int propID)
		{
			return null;
		}

		private void OnPropItemAdd(AGMO_PropAddItem item, int changeLevel)
		{
		}

		private void OnPropItemReduce(AGMO_PropAddItem item, int changeLevel)
		{
		}
	}
}
