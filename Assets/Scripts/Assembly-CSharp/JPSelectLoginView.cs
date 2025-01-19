using System.Runtime.InteropServices;
using WaterBell.ProjX.View.Panel;

public class JPSelectLoginView : RegAndLoginSubView
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void FinishGuestLogin();

	private FinishGuestLogin finishGuestLogin;

	public ButtonEx GoogleBtn;

	public ButtonEx FacebookBtn;

	public ButtonEx GuestBtn;

	public ButtonEx TwitterBtn;

	public ButtonEx GameCenterBtn;

	public ButtonEx IosBtn;

	public ButtonEx MailBtn;

	public ButtonEx hackLeftBtn;

	public ButtonEx hackRightBtn;

	private int LeftCount;

	private int RightCount;

	private int HackTriggerTime;

	public override void Show()
	{
	}

	public void ShowSelectJPLogin(FinishGuestLogin finishAction)
	{
	}

	protected override void AssignUIEvent()
	{
	}

	private void OnClickHackLeftBtn()
	{
	}

	private void OnClickHackRightBtn()
	{
	}

	private void OnClickGoogleBtn()
	{
	}

	private void OnClickFacebookBtn()
	{
	}

	private void OnClickMailBtn()
	{
	}

	private void OnClickTwitterBtn()
	{
	}

	private void OnClickGameCenterBtn()
	{
	}

	private void OnClikcIosBtn()
	{
	}

	private void OnClickGuestBtn()
	{
	}

	private void successfulRegistGuest()
	{
	}
}
