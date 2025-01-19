using WaterBell.ProjX.View.Panel;

public class EntryOptionView : RegAndLoginSubView, YijieHelper.YijieLoginCallback
{
	public ButtonEx LoginBtn;

	public ButtonEx RegistBtn;

	public ButtonEx VisitorBtn;

	public ButtonEx QQLoginBtn;

	public ButtonEx WeChatLoginBtn;

	public ButtonEx JpFbLoginBtn;

	public ButtonEx JpGoogleLoginBtn;

	public ButtonEx AppleLoginBtn;

	public static void SignInWithAppleLogin()
	{
	}

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

	private void OnClickLoginBtn()
	{
	}

	private void OnClickRegistBtn()
	{
	}

	private void OnClickYijieLogin()
	{
	}

	private void OnClickJpFbLoginBtn()
	{
	}

	private void OnClickJpGoogleLoginBtn()
	{
	}

	public void OnLoginMessage(bool loginSucc, string channelUserID, string token, string channelID, string username)
	{
	}

	private void OnClickQQLoginBtn()
	{
	}

	private void OnClickWeChatLoginBtn()
	{
	}

	public void SuccessfulGet()
	{
	}

	private void OnClickVisitorBtn()
	{
	}

	private void successfulRegistGuest()
	{
	}

	private void OnClickAppleLoginBtn()
	{
	}
}
