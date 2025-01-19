using UnityEngine;
using WaterBell.ProjX.View.Common;
using WaterBell.ProjX.View.Panel;

public class ForgetCodeView : RegAndLoginSubView
{
	public GameObject firstStep;

	public GameObject secondePhoneStep;

	public GameObject secondeMailStep;

	public ButtonEx backBtn;

	public CustomInput phoneAsAccNameInput;

	public ButtonEx nextBtn;

	public ButtonEx backFromPhoneBtn;

	public CustomInput SMSInput;

	public ButtonEx SMSRegainBtn;

	public UILabel SMSRegainLabel;

	public CustomInput phonePWInput;

	public ButtonEx phonehidePWBtn;

	public UISprite phonehidePWIcon;

	public ButtonEx phoneResetBtn;

	public ButtonEx phoneSMSLostBtn;

	public ButtonEx backFromMailBtn;

	public CustomInput MailCodeInput;

	public ButtonEx MailCodeRegainBtn;

	public UILabel MailCodeRegainLabel;

	public CustomInput MailPWInput;

	public ButtonEx MailhidePWBtn;

	public UISprite MailhidePWIcon;

	public ButtonEx MailResetBtn;

	public ButtonEx MailSMSLostBtn;

	private string phone2ReciveSms;

	private bool phonehidePass;

	private bool mailhidePass;

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

	private void OnCLickJumpBtn()
	{
	}

	private void RequestMailCodeSuccess()
	{
	}

	private void RequestRegistSMSSuccess()
	{
	}

	private void SMSStartCD()
	{
	}

	private void ToPhoneNextStep()
	{
	}

	private void ToMailNextStep()
	{
	}

	private void RefreshDuringSMSRegistCD()
	{
	}

	private void OnClickPhoneResetBtn()
	{
	}

	private void PhoneAccountCheckCodeSucc(string unicode)
	{
	}

	private void OnClickBackFromPhoneBtn()
	{
	}

	private void OnClickSMSRegainBtn()
	{
	}

	private void FinishUpdatePass()
	{
	}

	private void OnClickPhoneSMSLostBtn()
	{
	}

	private void OnClickPhoneHidePWBtn()
	{
	}

	private void OnPhoneChangeInput()
	{
	}

	private void CheckSMSInputAndAccPWInputCount()
	{
	}

	private void OnMailChangeInput()
	{
	}

	private void CheckMailCodeInputAndMailPWInputCount()
	{
	}

	private void OnClickMailCodeRegainBtn()
	{
	}

	private void MailCodeStartCD()
	{
	}

	private void RefreshDuringMailCodeCD()
	{
	}

	private void OnClickBackFromMailBtn()
	{
	}

	private void OnClickMailResetBtn()
	{
	}

	private void MailAccountCheckCodeSucc(string unicode)
	{
	}

	private void OnClickMailHidePWBtn()
	{
	}

	private void OnClickMailSMSLostBtn()
	{
	}
}
