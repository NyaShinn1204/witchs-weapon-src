using UnityEngine;

public class UnBindCheck : MonoBehaviour
{
	private enum BindType
	{
		BindTelphone = 0,
		BindEmail = 1
	}

	public ButtonEx TelPhoneBtn;

	public ButtonEx EmailBtn;

	public Transform telphone;

	public Transform email;

	public ButtonEx GetTelCodeBtn;

	public ButtonEx GetEmCodeBtn;

	public UILabel telWaitTimer;

	public UILabel emailWaitTimer;

	public ButtonEx BindBtn;

	public ButtonEx CannelBtn;

	private BindType currentType;

	public UIInput TelephoneInputTel;

	public UIInput TelephoneInputPw;

	public UIInput TelephoneInputCode;

	public UIInput EmailInputEm;

	public UIInput EmailInputPw;

	public UIInput EmailInputCode;

	public UIInput TelIdCardInputName;

	public UIInput TelIdCardInputCard;

	public UIInput EmIdCardInputName;

	public UIInput EmIdCardInputCard;

	public UILabel errorCodeText;

	private string GetTelephone
	{
		get
		{
			return null;
		}
	}

	private string GetEmail
	{
		get
		{
			return null;
		}
	}

	private string GetTelphoneName
	{
		get
		{
			return null;
		}
	}

	private string GetTelphoneIdCard
	{
		get
		{
			return null;
		}
	}

	private string GetEmailName
	{
		get
		{
			return null;
		}
	}

	private string GetEmailIdCard
	{
		get
		{
			return null;
		}
	}

	private string GetTelephoneCode
	{
		get
		{
			return null;
		}
	}

	private string GetEmailCode
	{
		get
		{
			return null;
		}
	}

	private string GetTelephonePw
	{
		get
		{
			return null;
		}
	}

	private string GetEmailPw
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	private void BindTelphoneCheckIDcard()
	{
	}

	private void GetBindLoot(ModelCollection<DrawResultData> _loot, ModelCollection<DrawResultData> _weapon)
	{
	}

	private void OnTelephoneSuccessful()
	{
	}

	private void OnTelephoneFail(string _errCode)
	{
	}

	private void BindEmailCheckIDcard()
	{
	}

	public void Init()
	{
	}

	private void ClickTelPhone()
	{
	}

	private void ClickEmail()
	{
	}

	private void GetTelCode()
	{
	}

	private void GetEmCode()
	{
	}

	private void SendTelephoneSuccessful()
	{
	}

	private void SendEmailSuccessful()
	{
	}

	private void SetTelWaitTimeText(float _value)
	{
	}

	private void SetEmailWaitTimeText(float _value)
	{
	}
}
