using UnityEngine;
using WaterBell.ProjX.View.Common;
using WaterBell.ProjX.View.Panel;

public class AccRegisterByEmailView : RegAndLoginSubView
{
	public GameObject firstStep;

	public GameObject secStep;

	public ButtonEx backBtn1;

	public ButtonEx switchPhoneRegBtn;

	public CustomInput emailAsAccNameInput;

	public ButtonEx nextBtn;

	public ButtonEx jumpBtn;

	public ButtonEx backBtn2;

	public UILabel regEmailLabel;

	public CustomInput accPWInput;

	public ButtonEx hidePWBtn;

	public UISprite hidePWIcon;

	public ButtonEx regAndLoginBtn;

	public ButtonEx agreeContractBtn;

	public ButtonEx readContractBtn;

	public bool IsAgreeContract;

	private const string RegEmailPrefix = "即将\ufffd";

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

	private void OnClickBackBtn1()
	{
	}

	private void OnClickBackBtn2()
	{
	}

	private void OnEmailAsAccNameInputChange()
	{
	}

	private void CheckEmailAsAccNameInputCount()
	{
	}

	private void CheckAccPWInputCount()
	{
	}

	public void OnAccPWInputChange()
	{
	}

	private void OnClickSwitchPhoneRegBtn()
	{
	}

	private void OnClickNextBtn()
	{
	}

	public void OnClickRegAndLoginBtn()
	{
	}

	public void RegisterByEmailSucc()
	{
	}

	public void OnChangeAccPWInput()
	{
	}

	private void OnClickHidePWBtn()
	{
	}

	private void OnClickAgreeContractBtn()
	{
	}

	private void OnClickReadContractBtn()
	{
	}
}
