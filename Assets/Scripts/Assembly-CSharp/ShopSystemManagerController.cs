using System.Collections.Generic;
using Google.Protobuf.Collections;
using Lootmod;
using WaterBell.ProjX.Data.Entity;

public class ShopSystemManagerController : ShopSystemManagerControllerBase
{
	private long TotalWaitTime;

	private long FinishPayTime;

	private const long WAIT_TIME_MAX = 1L;

	private const long RETRY_TIME_MAX = 8L;

	private const float REFRESH_INTERN = 1f;

	private const long CHECK_INTERN = 1L;

	private const long RETRY_TIME_INTERN = 2L;

	private const long BACKGROUND_RETRY_TIME_INTERN = 100L;

	private long BackgroundWaitTime;

	private long ForegroundWaitTime;

	private int payType;

	private string orderid;

	private long buySetID;

	private long buyShopID;

	private long GoodID;

	private int Num;

	private string tempSDKPayResultOrderID;

	public override void InitializeShopSystemManager(ShopSystemManagerViewModel shopSystemManager)
	{
	}

	private void UpdateSecretShopSets(bool state)
	{
	}

	public void RefreshOrderHandler()
	{
	}

	private void RefreshOrderInfo()
	{
	}

	private void DealOrderResult(string finishOrderid, long goodID)
	{
	}

	private void InitAlShopSet()
	{
	}

	private void RefreshShopSet(long setID)
	{
	}

	private ShopSet InitShopSet(ShopSetInfo info)
	{
		return null;
	}

	private List<ShopInfo> InitAllShopInfo(ShopSetInfo info)
	{
		return null;
	}

	private List<GoodInfo> InitAllGood(Shop shopData)
	{
		return null;
	}

	private void UpdateShopSet(PropertyChangeedObservable target)
	{
	}

	public override void RefreshOutofDateShopSet(ShopSystemManagerViewModel shopSystemManager, string arg)
	{
	}

	private void finishManulRefresh(long id)
	{
	}

	private void finishGetSetData(string ids)
	{
	}

	public override void RefreshManagerShopSet(ShopSystemManagerViewModel shopSystemManager, string arg)
	{
	}

	public override void FinishRefresh(ShopSystemManagerViewModel shopSystemManager)
	{
	}

	private void finishBuy()
	{
	}

	public override void BuyGood(ShopSystemManagerViewModel shopSystemManager, BuyGoodArug arg)
	{
	}

	private void ConfirmEvent()
	{
	}

	public void FailhBuy(string text)
	{
	}

	private void DealResultBuy(string result, string order, RepeatedField<LootObject> lootObjects)
	{
	}

	public override void FinishBuyGood(ShopSystemManagerViewModel shopSystemManager)
	{
	}

	private void ResetArgu()
	{
	}

	public override void ManulRefresh(ShopSystemManagerViewModel shopSystemManager, long arg)
	{
	}

	public override void CreatePay(ShopSystemManagerViewModel shopSystemManager, BuyGoodArug arg)
	{
	}

	private void SuccessBuyProduct(string data)
	{
	}

	private void FailBuyProduct(string data)
	{
	}

	private void FinishCreateOrder(string result, string orderinfo, string paytype)
	{
	}

	private void LeitingPayDelegate(bool succ, string leitingOrderNum, string money, string msg)
	{
	}

	private void DealEfunPayResult(bool isSucc)
	{
	}

	private void DealDmmPcPayResult(int Result, string TransactionID, RepeatedField<LootObject> lootObjects)
	{
	}

	private void DealJpGooglePayResult(int Result, string TransactionID, RepeatedField<LootObject> lootObjects)
	{
	}

	private void DealJPGoogleSDKPayResult(bool isSucc, string token, string SDKPayResultOrderID)
	{
	}

	private void DealJPDmmPcPayResult(bool isSucc, string data = "", string sign = "")
	{
	}

	private void DealSDKPayResult(long errorCode)
	{
	}

	private void AfterFinishPayRefreshShopGoodNum()
	{
	}

	public void FailhPay(string text)
	{
	}

	private void FinishCheckPay(string errorcode, string orderid)
	{
	}

	private void successCheckPay()
	{
	}

	public override void FinishPay(ShopSystemManagerViewModel shopSystemManager)
	{
	}

	private void BuyDiamondAdjust(long goodID, bool isSuccess)
	{
	}
}
