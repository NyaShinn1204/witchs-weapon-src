using System.Runtime.InteropServices;
using WaterBell.ProjX.View.Panel;

public class LineUpView : RegAndLoginSubView
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void FinishGuestLogin();

	private FinishGuestLogin finishGuestLogin;

	public ButtonEx LineUpCancelBtn;

	public UILabel LineUpTitle;

	public UILabel LineUpContent;

	private int waitNum;

	public const float maxWaitTime = 5f;

	public override void Show()
	{
	}

	public void ShowLineUp(int waitNum)
	{
	}

	protected override void AssignUIEvent()
	{
	}

	private void OnClickLineUpCancelBtn()
	{
	}

	private void StartCountDownToResend()
	{
	}

	private void CancelCountDownToResend()
	{
	}

	private void ResendRoleLogin()
	{
	}

	private void OnRoleLoginSucc()
	{
	}

	private void OnRoleLoginFail(string error)
	{
	}
}
