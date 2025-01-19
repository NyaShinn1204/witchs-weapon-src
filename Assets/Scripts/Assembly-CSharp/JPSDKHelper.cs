using System.Runtime.InteropServices;
using Facebook.Unity;
using LitJson;
using TwitterKit.Unity;

internal class JPSDKHelper
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void LoginDelegate(bool succ, string id, string name, string msg);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void PayDelegate(bool succ, string token, string orderId);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void ShareDelegate(bool succ, string msg);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void OnInvQueryResult(GooglePlayPurchase[] purchases);

	public static JPSDKHelper instance;

	public LoginDelegate OnGoogleLoginComplete;

	public LoginDelegate OnFacebookLoginComplete;

	public LoginDelegate OnTwitterLoginComplete;

	public LoginDelegate OnIOSGameCenterLoginComplete;

	public OnInvQueryResult OnGoogleInventoryQueryFinished;

	public PayDelegate OnGooglePayResult;

	public ShareDelegate OnTwitterShareResult;

	public static JPSDKHelper GetInstance()
	{
		return null;
	}

	public void DoGameCenterLogin()
	{
	}

	internal void HandleAuthenticated(bool success)
	{
	}

	public void DoGooglePay(string skuID)
	{
	}

	public void DoGoogleQueryInventory(string[] skuIds)
	{
	}

	public void DoGoogleCosumeItem(string orderId)
	{
	}

	public void DoGoogleLogin()
	{
	}

	public void DoFacebookLogin()
	{
	}

	public void DoIosLogin()
	{
	}

	public void DoGoogleLogout()
	{
	}

	public void DoFacebookLogout()
	{
	}

	public void DoTwitterLogin()
	{
	}

	public void DoTwitterLogout()
	{
	}

	public void DoTwitterShare(string content, string imgURL)
	{
	}

	public void TrackAdjustEvent()
	{
	}

	public void GameExit()
	{
	}

	public void SendEmail(string email, string title, string body)
	{
	}

	public void GotoAppStore()
	{
	}

	public void OnTwitterShareSucc(string tweetId)
	{
	}

	public void OnTwitterShareFail(ApiError error)
	{
	}

	public void OnTwitterShareCancel()
	{
	}

	internal void OnGoogleResult(JsonData data)
	{
	}

	internal void OnFacebookAuthenticationFinished(IResult result)
	{
	}

	internal void OnTwitterLoginSucc(TwitterSession session)
	{
	}

	internal void OnTwitterLoginFailure(ApiError error)
	{
	}

	public void OnDestory()
	{
	}
}
