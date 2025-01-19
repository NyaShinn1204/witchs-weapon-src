using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class Article : UIPanelSingle
	{
		private const string generalBg = "Common_Qulity_Whole";

		private const string generalQuality = "Common_Qulity_002_";

		private const string debrisBg = "Common_Qulity_Shard";

		private const string debrisQuality = "Common_Qulity_003_";

		public const int DiamondResID = -2017310;

		private const string diamondIconAtlasName = "NewResBar";

		private const string diamondIconAtlasSpriteName = "Currency_Icon_Diamond_Big";

		[Space]
		public UISprite bg;

		public UISprite quality;

		public UISprite other;

		public UISprite icon;

		public UILabel count;

		public GlobalEnum.PackageTypes type;

		public TypeCsvItemClient itemClientData;

		public TypeCsvItem itemData;

		public TypeCsvServantEquipClient equipClientData;

		public TypeCsvServantEquip equipData;

		[SerializeField]
		public ArticleData aData;

		public bool isShowTipsPanel;

		public int Count
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override void UpdatePanel()
		{
		}

		protected virtual void OnPress(bool isPress)
		{
		}

		public void Use()
		{
		}

		public void SetNumLabel(bool isShow)
		{
		}
	}
}
