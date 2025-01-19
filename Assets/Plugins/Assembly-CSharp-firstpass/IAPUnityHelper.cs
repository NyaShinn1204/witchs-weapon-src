using System.Runtime.InteropServices;
using UnityEngine;

public class IAPUnityHelper : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void FunctionString(string sData);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void FunctionIAPUnityHelperData(IAPUnityHelperData sData);

	public class IAPUnityHelperData
	{
		public string ID;

		public string userName;

		public FunctionString succeed;

		public FunctionString failed;

		public string transactionID;

		public string transactionData;

		public string productID
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}

	private static string SANDBOX;

	private static string AppStore;

	private static IAPUnityHelper _instance;

	private IAPUnityHelperData _data;

	private FunctionIAPUnityHelperData _serverSendHD;

	public static IAPUnityHelper instance
	{
		get
		{
			return null;
		}
	}

	public void StartBuyProduct(string sID, string sUserName, FunctionString sSucceed, FunctionString sFailed, FunctionIAPUnityHelperData sServerSend)
	{
	}

	private void PayHDPreBuyProductFailed(string sRecvData)
	{
	}

	private void PayHDBuyProudctFailed(string sRecvData)
	{
	}

	private void PayHDRestoreProductFailed(string sRecvData)
	{
	}

	private void PayHDCancelRestoreProducts(string sRecvData)
	{
	}

	private void PayHDBuyProductSuccess(string sRecvData)
	{
	}

	private void PayHDGotProductsSuccess(string sRecvData)
	{
	}

	private void PayHDVerifyProductReceiptDataRestore(string sRecvData)
	{
	}

	private void PayHDVerifyProductReceiptData(string sRecvData)
	{
	}

	public void recvGameServerHD(string sRecvData)
	{
	}
}
