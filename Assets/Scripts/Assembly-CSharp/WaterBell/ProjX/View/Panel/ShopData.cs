using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class ShopData : UIDataBase
	{
		public const string TagDailyImg = "Frame_Maze_Shop_Daily";

		public const string TagVipImg = "Frame_caph_Shop_Daily";

		public const string TagItemImg = "Frame_Resources_Shop_Daily";

		public const long DiamondID = 47000001L;

		public const long BagID = 47000002L;

		public const long FestivalID = 47000015L;

		public const long CardID = 47000016L;

		public const long DefaultID = 47000017L;

		public const long ResouceID = 47000003L;

		public const long ItemID = 47000004L;

		public const long Expedition1ID = 47000023L;

		public const long Expedition2ID = 47000005L;

		public const long Guild1ID = 47000006L;

		public const long Guild2ID = 47000024L;

		public const long TaskID = 47000007L;

		public const long LotteryID = 47000008L;

		public const long VipID = 47000009L;

		public const long ActivityID = 47000010L;

		public const long ActionID = 47000018L;

		public const long Special1IDItem = 47000011L;

		public const long Special1IDEquip = 47000025L;

		public const long Special2IDItem = 47000012L;

		public const long Special2IDEquip = 47000026L;

		public const long RunAcitivtyID = 47000014L;

		public const long ceshiID = 47000013L;

		public const long Star1ID = 47000019L;

		public const long Star2ID = 47000020L;

		public const long Activity3ID = 47000021L;

		public const long Activity4ID = 47000022L;

		public long TargetShopArgu;

		public string TargetIDShopStructure;

		public bool needRecord;

		public ShopArug arug;

		public const string UnLockText = "OperateGift4";

		public const string LockText = "OperateGift5";

		public static Color BuyUnLock;

		public static Color BuyLock;

		public static Dictionary<int, Vector3> tabBtnPosition;

		public string IDShopStructure
		{
			get
			{
				return null;
			}
		}

		public TypeCsvShopStructure CsvShopStructure
		{
			get
			{
				return null;
			}
		}

		public ShopData(bool needRecord, long targetShop, ShopArug _arug = null)
		{
		}

		public static string GetTitleName(long _bigSetID)
		{
			return null;
		}

		public static void FindGoods(long _bigSetID, long _setID, long _shopID, long _goodsID)
		{
		}

		public static void SetScrollView(UIScrollBar _bar, int _limit, int _index, int _gridMaxNum)
		{
		}

		public static int SetDiscount(int _price, bool _isDiscount, int _Discount)
		{
			return 0;
		}

		public static float GetPositionXvalues(float _imgWidget, float _labelWidget)
		{
			return 0f;
		}

		public static float GetPositionXOnlyLabel(long _length)
		{
			return 0f;
		}
	}
}
