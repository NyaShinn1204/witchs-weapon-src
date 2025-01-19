using System;
using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.View.Panel;

public class NewShopPanelControl : UIPanelBase
{
	public UISprite shopTitle;

	public UILabel ActivityTabText;

	public Transform DefultView;

	public UIScrollView bagScroll;

	public UIGrid bagGrid;

	public UIScrollView diamondScroll;

	public UIGrid diamondGrid;

	public UIScrollView resouceScroll;

	public UIGrid resouceGrid;

	public UIScrollView itemScroll;

	public UIGrid itemGrid;

	public UIScrollView currencyScroll;

	public UIGrid currencyGrid;

	public UIScrollView MysteryScrollView;

	public UIGrid MysteryGrid;

	public UIScrollView RunActivityScrollView;

	public UIGrid RunActivityGrid;

	public UIDragScrollView DefultDragBox;

	public ButtonEx exchangeBtn;

	public Transform CurrencyView;

	public UIDragScrollView CurrencyDragBox;

	public Transform buyWidget;

	public UILabel buyCount;

	public UILabel buyCountText;

	public Transform MysteryView;

	public UILabel specialCloseTime;

	public UIDragScrollView MysteryDragBox;

	public Transform VipShopView;

	public UIDragScrollView VipDragBox;

	public Transform RunActivityShopView;

	public UIDragScrollView RunAcitityDragBox;

	public static NewShopPanelControl current;

	public ShopSystemManagerView view;

	private GameObject itemPrefab;

	public long currentBigSetID;

	private long currentSetID;

	private long currentGoodID;

	private List<int> types;

	private List<long> currency_ids;

	public Transform[] prices;

	public UITable tablePrice;

	[HideInInspector]
	public UIGrid currentGrid;

	private UIScrollView currentScroll;

	public int payType;

	public Transform waitBg;

	public Transform buyWaitBg;

	private int refreshCount;

	private int refreshLimit;

	public Transform FreshView;

	public UILabel freshDiamond;

	public UILabel freshTime;

	public UILabel freshNumber;

	public ButtonEx freshBtn;

	public ButtonEx returnBtn;

	public ButtonEx zhifubao;

	public ButtonEx weixin;

	public ShopItemInfo ShopItemInfoView;

	public UILabel titleText;

	public UIScrollView[] scrolls;

	public UIScrollBar bar;

	private long firstTabBtnId;

	private bool isReSet;

	private ShopArug arug;

	private GoodInfo findGoodInfo;

	private int _index;

	private int limit;

	public UITable JpTable;

	public ButtonEx Abtn;

	public ButtonEx Bbtn;

	public ButtonEx Cbtn;

	public ButtonEx Dbtn;

	public ButtonEx remindBtn;

	public UILabel KrMoonthCardsText;

	public GameObject Helper;

	private List<ButtonEx> _listBtnMenu;

	private GameObject _btnMenuItem;

	private ButtonEx _btnMenuPre;

	private List<ButtonEx> _listBtnMenuSub;

	private GameObject _btnMenuSubItem;

	private ButtonEx _btnMenuSubPre;

	private long _time;

	private List<long> ids;

	private long _freshTime;

	private List<long> CloseShopSets;

	private List<long> ShopSets;

	private long FirstTabBtn
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public void ClickHelper(GameObject obj)
	{
	}

	public override void OpenPanel(UIDataBase mData = null)
	{
	}

	private void DrawButton(ShopData sData)
	{
	}

	private void DrawButtonSub(string[] sSubData, ShopData sData = null)
	{
	}

	public override void ClosePanel(Action action = null)
	{
	}

	private void OpenTab(long _TargetShopArgu)
	{
	}

	public void OpenShopSet(long _bigSetID, bool _isReSet = true, ShopArug _arug = null)
	{
	}

	private void ClosePay()
	{
	}

	private void CanPay()
	{
	}

	private void SelectShopSet(long _bigSetID)
	{
	}

	private long GetFirstShopSetID(List<long> _setIDS)
	{
		return 0L;
	}

	private void InitBigShop(long _bigSetID)
	{
	}

	public void InitShop(List<long> _setIDS)
	{
	}

	private void GetShopState(List<long> _setIDS)
	{
	}

	public void RefrashShop(List<ShopInfo> _info, List<long> _setIDS, List<int> _vipExtras)
	{
	}

	public void SetShopPrice()
	{
	}

	private void GetPriceList()
	{
	}

	private void SetCurrentView(long _bigSetID)
	{
	}

	private void SetInitActivityShopView()
	{
	}

	private void SpecialShopClose()
	{
	}

	private void SetSpecialShopTime()
	{
	}

	private void SetAcitonScroll(UIScrollView _scroll, bool _isReSet = true)
	{
	}

	private void SetPayBtnState()
	{
	}

	private void PayByZFB()
	{
	}

	private void PayByWX()
	{
	}

	private bool IsSellOut(long _bigShopID)
	{
		return false;
	}

	private bool IsNull(long _bigShopID)
	{
		return false;
	}

	private bool IsOutTime(long _bigShopID)
	{
		return false;
	}

	private void AddEvent()
	{
	}

	private void GoWeb(string _url)
	{
	}

	public void ShowPayGoods(bool isFirstBuy = false)
	{
	}

	public void ShowBuyGoods()
	{
	}

	public void CloseInfoVIew()
	{
	}

	public void ShowWaitView()
	{
	}

	public void CloseWaitView()
	{
	}

	public void CloseBuyWaitView()
	{
	}

	public void ShowBuyWaitView()
	{
	}

	public void InitFreshTime(List<long> _ids)
	{
	}

	private void FreshTime()
	{
	}

	private void FreshTimeCloseShopSet(List<long> _setIDS)
	{
	}

	private void CloseShopSet()
	{
	}

	public void ManualFresh()
	{
	}

	private void OpenConfirmPanel()
	{
	}

	private int GetShopSetRefreshCount(long _setID)
	{
		return 0;
	}

	public void SetSelectGoods(GoodInfo _goodInfo, long _setID, long _shopID, long _goodsID)
	{
	}
}
