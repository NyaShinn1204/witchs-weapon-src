using UnityEngine;
using WaterBell.ProjX.View.Common;
using WaterBell.ProjX.View.Panel;

public class AccLoginBySMSView : RegAndLoginSubView
{
	public GameObject firstStep;

	public GameObject secStep;

	public ButtonEx switchPWLoginBtn;

	public ButtonEx backBtn1;

	public ButtonEx nextBtn;

	public CustomInput phoneNumInput;

	public ButtonEx backBtn2;

	public ButtonEx phoneLoginBtn;

	public CustomInput phoneVerifyInput;

	public ButtonEx SMSRegainBtn;

	public UILabel SMSRegainLabel;

	public UILabel phoneToLoginLabel;

	private string phone2ReciveSms;

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	protected override void AssignUIEvent()
	{
	}

	private void OnClickSwitchPWLoginBtn()
	{
	}

	protected override void ReturnBack2PrevView()
	{
	}

	private void OnChangePhoneNumInput()
	{
	}

	private void CheckPhoneNumInputCount()
	{
	}

	private void NextStep()
	{
	}

	private void OnClickNextBtn()
	{
	}

	private void LoginProgress()
	{
	}

	private void FailCheckAccountStatus(string errorcode)
	{
	}

	private void RequestRegistSMSSuccess()
	{
	}

	private void SMSStartCD()
	{
	}

	private void RefreshDuringSMSLoginCD()
	{
	}

	private void OnClickBackBtn2()
	{
	}

	public void OldUserPhoneLogin()
	{
	}

	public void LoginByPhoneSucc()
	{
	}

	private void OnChangePhoneVerifyInput()
	{
	}

	private void CheckPhoneVerifyInputCount()
	{
	}

	public void OnClickSMSRegainBtn()
	{
	}
}
