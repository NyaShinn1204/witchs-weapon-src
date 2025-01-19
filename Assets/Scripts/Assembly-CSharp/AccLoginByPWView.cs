using WaterBell.ProjX.View.Common;
using WaterBell.ProjX.View.Panel;

public class AccLoginByPWView : RegAndLoginSubView
{
	public ButtonEx switchSMSLoginBtn;

	public CustomInput accNameInput;

	public CustomInput accPWInput;

	public ButtonEx loginBtn;

	public ButtonEx hidePWBtn;

	public UISprite hidePWIcon;

	public ButtonEx forgetPWBtn;

	public ButtonEx backBtn1;

	private bool hidePass;

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	protected override void ReturnBack2PrevView()
	{
	}

	protected override void AssignUIEvent()
	{
	}

	private void FailCheckAccountStatus(string errorcode)
	{
	}

	private void LoginProgress()
	{
	}

	private void OnClickLoginBtn()
	{
	}

	public void LoginByEmailSucc()
	{
	}

	private void OnClickHidePWBtn()
	{
	}

	private void OnClickSwitchSMSLoginBtn()
	{
	}

	private void OnClickBackBtn1()
	{
	}

	private void OnClickForgetPWBtn()
	{
	}

	private void ReceivedMessageHD(UniWebView webView, UniWebViewMessage message)
	{
	}

	private void OnEmailAsAccNameInputChange()
	{
	}

	private void CheckAccNameInputAndAccPWInputCount()
	{
	}

	public void OnAccPWInputChange()
	{
	}
}
