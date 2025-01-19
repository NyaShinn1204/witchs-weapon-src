using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class ResTips : TipsBase
	{
		public enum CountStyle
		{
			General = 0,
			Own = 1
		}

		protected const string NAME_DELIMITER = "| ";

		protected const string TYPE_LABEL = "Container/Label_Type";

		protected const string NAME_LABEL = "Container/Label_Name";

		protected const string COUNT_LABEL = "Container/Label_Count";

		protected const string LOOT_CONTAINER = "Container/Icon";

		protected const string PRICE_CONTAINER = "Container/Price";

		protected const string DETAIL_TABLE = "Container/DetailTable";

		protected const string ACTIVITY_ICON_SPACING = "     ";

		protected const string EN_TYPE_LABEL = "Container/en_Label_Type";

		protected const string EN_NAME_LABEL = "Container/en_Label_Name";

		protected UILabel typeLabel;

		protected UILabel nameLabel;

		protected UILabel countLabel;

		protected UILabel priceLabel;

		protected UIWidget descMiddle;

		protected UILabel descMiddleLabel;

		protected UIWidget descBottom;

		protected UILabel descBottomLabel;

		protected Transform lootContainer;

		protected GameObject priceContainer;

		protected UITable detailTable;

		protected ResTipsData resTipsData;

		protected UISprite activityIcon;

		protected UILabel en_typeLabel;

		protected UILabel en_nameLabel;

		public CountStyle countStyle;

		protected string descBottomStr;

		protected string descMiddleStr;

		protected int price;

		protected long num;

		protected string nameStr;

		protected string typeStr;

		protected string activityIconStr;

		protected UIPanelSingleContainer levelContainer;

		protected GameObject objAcquiringWay;

		protected ServantEquipSweepView servantEquipSweepView;

		protected SweepArgu cacheSweepArgu;

		protected long cacheEquipID;

		protected override void Awake()
		{
		}

		public override void OpenPanel(TipsBaseData data, Transform target)
		{
		}

		protected virtual void DrawHead()
		{
		}

		protected virtual void SetData()
		{
		}

		protected virtual void DrawPrice()
		{
		}

		protected virtual void DrawDescMiddle()
		{
		}

		protected virtual void DrawDescBottom()
		{
		}

		protected virtual void OnSweep(SweepArgu sweepArgu)
		{
		}

		protected virtual void OnGotoWay(LevelButtonItem levelButton)
		{
		}

		public virtual void SweepSuccessful()
		{
		}

		protected virtual void DrawAcquiringWay()
		{
		}
	}
}
