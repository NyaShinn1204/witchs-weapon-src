using UnityEngine;
using WaterBell.ProjX.View.Common;
using WaterBell.ProjX.View.Panel;

public class AccRegisterByPhoneView : RegAndLoginSubView
{
	public GameObject NewRegistPanel;

	public GameObject firstStep;

	public GameObject secStep;

	public ButtonEx backBtn1;

	public ButtonEx switchEmailRegBtn;

	public CustomInput phoneAsAccNameInput;

	public ButtonEx nextBtn;

	public ButtonEx jumpBtn;

	public ButtonEx backBtn2;

	public CustomInput SMSInput;

	public ButtonEx SMSRegainBtn;

	public UILabel SMSRegainLabel;

	public CustomInput accPWInput;

	public ButtonEx hidePWBtn;

	public UISprite hidePWIcon;

	public ButtonEx regAndLoginBtn;

	public ButtonEx SMSLostBtn;

	public ButtonEx agreeContractBtn;

	public ButtonEx readContractBtn;

	public bool IsAgreeContract;

	private string phone2ReciveSms;

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

	private void OnClickSwitchEmailRegBtn()
	{
	}

	private void OnChangePhoneAsAccNameInput()
	{
	}

	private void CheckPhoneAsAccNameInputCount()
	{
	}

	private void OnClickNextBtn()
	{
	}

	private void OnCLickJumpBtn()
	{
	}

	private void RequestRegistSMSSuccess()
	{
	}

	private void SMSStartCD()
	{
	}

	private void NextStep()
	{
	}

	private void RefreshDuringSMSRegistCD()
	{
	}

	private void OnClickBackBtn2()
	{
	}

	private void OnChangeInput()
	{
	}

	private void CheckSMSInputAndAccPWInputCount()
	{
	}

	private void OnClickRegAndLoginBtn()
	{
	}

	public void OnClickSMSRegainBtn()
	{
	}

	private void RegisterByPWSucc()
	{
	}

	private void OnClickHidePWBtn()
	{
	}

	private void OnClickSMSLostBtn()
	{
	}

	private void OnClickAgreeContractBtn()
	{
	}

	private void OnClickReadContractBtn()
	{
	}
}
