using System;
using WaterBell.ProjX.Data.Entity;

namespace WaterBell.ProjX.View.Panel
{
	[Serializable]
	public class DrawInfo
	{
		public enum SpecialKinds
		{
			General = 0,
			MultSpecial = 1
		}

		public enum CurrencyTypes
		{
			Gold = 0,
			Item = 1
		}

		private const string GOLD_ICON = "Currency_Icon_Gold";

		private const string DIAMOND_ICON = "Item40_200s";

		private const string DIAMOND_ICON_MULTSPECIAL = "Item40_236s";

		private const string ACTIVITY_ICON = "Item40_200s";

		private const string GOLD_BUTTON_BG_ICON = "Pattern_Coin";

		private const string DIAMOND_BUTTON_BG_ICON = "Pattern_Diamonds";

		public long drawBaseId;

		public long actId;

		public long sortIndex;

		public int cardPoolType;

		public DateTime freeTime;

		public DateTime apCloseTime;

		public string name;

		public bool isApDraw;

		public int drawCurrency;

		public int drawTenCurrency;

		public string currencyIcon;

		public string currencyIconMult;

		public bool isFree;

		public bool isFree10;

		public bool cacheFree;

		public LuckDrawTypes luckDrawType;

		public string front;

		public string bg;

		public string button;

		public CrystalBallButton crystalBall;

		public DrawActivityData drawActivityData;

		public int freeCountMax;

		public int freeCount;

		public DrawCountTypes drawCountType;

		public bool canFree;

		public bool canFree10;

		public int state;

		public int needCurrency;

		public string tagArg;

		public SpecialKinds multButtonSpecialKind;

		public int guaranteesTimeCount;

		public bool showProb;

		public bool showGuarantees;

		public bool isFirstRestrict;

		public CurrencyTypes currencyType;

		public bool isClosePerson;

		public DrawInfo(LuckDrawTypes luckDrawType, long sortIndex, CrystalBallButton crystalBall = null)
		{
		}

		public DrawInfo(DrawActivityData drawActivityData, CrystalBallButton crystalBall = null)
		{
		}

		public bool IsFree()
		{
			return false;
		}

		public void UpdateInfo()
		{
		}

		public bool IsJpMultSpecialDraw()
		{
			return false;
		}

		public void SetState(DrawCountTypes drawCountType)
		{
		}
	}
}
