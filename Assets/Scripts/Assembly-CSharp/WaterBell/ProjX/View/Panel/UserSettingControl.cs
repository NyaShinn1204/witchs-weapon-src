using System;
using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.Data.Entity;

namespace WaterBell.ProjX.View.Panel
{
	public class UserSettingControl : UIAnimationPanelBase
	{
		public UILabel dateLabel;

		public UILabel timeLabel;

		public UILabel amPmLabel;

		public UILabel Id;

		public UILabel Account;

		public Transform Resouces;

		public UILabel DiamondValue;

		public UILabel GoldValue;

		public UILabel DrawValue;

		public UILabel CscValue;

		public UILabel YellowValue;

		public UILabel RedValue;

		public UILabel BlueValue;

		public UILabel GreenValue;

		public UILabel GuildValue;

		public UILabel DrawCurrency;

		public ButtonEx ReturnBtn;

		public ButtonEx KefuBtn;

		public ButtonEx GoWitchWeaponBtn;

		public ButtonEx QuitBtn;

		public ButtonEx servantBtn;

		public ButtonEx weaponBtn;

		public ButtonEx storyBtn;

		public ButtonEx achievementBtn;

		public static UserSettingControl current;

		public ButtonEx[] btns;

		public Transform[] views;

		public UISlider musicSlider;

		public UILabel musicValue;

		public UISlider soundSlider;

		public UILabel soundValue;

		public UISlider cvSlider;

		public UILabel cvValue;

		public UISlider cutSlider;

		public UILabel cutValue;

		public UIToggle animOpen;

		public UIToggle animClose;

		public UIToggle high;

		public UIToggle mid;

		public UIToggle low;

		public UIPopupList popupList;

		public UIToggle GetVit;

		public UIToggle VitLimit;

		public UIToggle vsOpen;

		public UIToggle vsClose;

		public UIScrollBar bar;

		public Transform topIcon;

		public Transform bottomIcon;

		public UIPopupList language;

		private List<string> names;

		public Transform CnWidget;

		public UIInput TelephoneInputTel;

		public UIInput TelephoneInputPw;

		public UIInput TelephoneInputCode;

		public UIInput EmailInputEm;

		public UIInput EmailInputPw;

		public UIInput EmailInputCode;

		public UIInput IdCardInputName;

		public UIInput IdCardInputCard;

		public ButtonEx TelephoneSendBtn;

		public ButtonEx TelephoneBindBtn;

		public ButtonEx EmailSendBtn;

		public ButtonEx EmailBindBtn;

		public ButtonEx CheckIdCardBtn;

		public UserSettingComponent[] components;

		private SettingTypeSelect currentSelect;

		public UILabel telNumber;

		public UILabel telWaitTimer;

		public UILabel emailWaitTimer;

		public Transform KrWidget;

		public ButtonEx KrBindBtn;

		public ButtonEx KrGoActivityBtn;

		public Transform KrCDKey;

		public UIInput KrCDKeyInput;

		public ButtonEx KrexChangeBtn;

		public BindAccountControl bindAccountControl;

		public UIInput CDKeyInput;

		public ButtonEx exChangeBtn;

		public ButtonEx ShareBtn;

		public ButtonEx GetAwardBtn;

		public UILabel remindText;

		public Transform redPoint;

		public UserSettingData data;

		public UITable JpTable;

		public ButtonEx btn1;

		public ButtonEx btn2;

		public ButtonEx btn3;

		public ButtonEx btn4;

		public ButtonEx btn5;

		public ButtonEx copyBtn;

		public ButtonEx ConsumptionQuestionBtn;

		public ButtonEx BugReportBtn;

		public ButtonEx SuggestBtn;

		public ButtonEx OtherConditionBtn;

		public UILabel serviceDeclare;

		public ButtonEx JPBindAccountViewBtn;

		public ButtonEx JPSendMailViewBtn;

		public ButtonEx JPGoStoreBtn;

		public ButtonEx JPSendMailBtn;

		public Transform SendMailView;

		public UIInput JPMailAdressInput;

		public UIInput JPMailTitleInput;

		public UIInput JPMailContentInput;

		public ButtonEx TwUserCenterBtn;

		public InviteControl inviteView;

		public Transform inviteRemindIcon;

		private List<string> languageKey;

		private List<string> languageValue;

		public UITable languageTable;

		private bool isChangeLock;

		[HideInInspector]
		public UserPlayerManagerView uframeView;

		private int anchorCutMax;

		private bool isShowAccountCenterCD;

		private List<HeadIcon> GetHeadList
		{
			get
			{
				return null;
			}
		}

		private List<HeadIconBox> GetHeadBoxList
		{
			get
			{
				return null;
			}
		}

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

		private string GetCDKey
		{
			get
			{
				return null;
			}
		}

		private string GetKrCDKey
		{
			get
			{
				return null;
			}
		}

		private string GetName
		{
			get
			{
				return null;
			}
		}

		private string GetIdCard
		{
			get
			{
				return null;
			}
		}

		protected override void Start()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		private void GetEfunResult()
		{
		}

		private void EfunMessageResult(bool hasUnReadMessage)
		{
		}

		private void InitLanguageUI()
		{
		}

		private void SetLanguageUI(UserSettingData _data)
		{
		}

		public void SetGetAwardBtn()
		{
		}

		private void SetInfo()
		{
		}

		private void InitLanguage()
		{
		}

		private string GetLanguageNmae(int _type)
		{
			return null;
		}

		private ManagerCsv.Language GetLanguageType(string _name)
		{
			return default(ManagerCsv.Language);
		}

		private void InitStartGameCV()
		{
		}

		private void SelectPopupListItem()
		{
		}

		private int GetSelectedID()
		{
			return 0;
		}

		private void InitAnimShow()
		{
		}

		private void InitVs()
		{
		}

		private void InitImage()
		{
		}

		private void InitMusicSlider()
		{
		}

		private void ChangeMusicSlider()
		{
		}

		private void ChangeSoundSlider()
		{
		}

		private void ChangeCvSlider()
		{
		}

		private void ChangeCutSlider()
		{
		}

		private void OnDisable()
		{
		}

		private void AddEvent()
		{
		}

		private void CancelShowAccountCenterCD()
		{
		}

		private void OnChange()
		{
		}

		private void ConfirmChangeLanguage()
		{
		}

		private void CannelChangeLanguage()
		{
		}

		private void ClickJPSendMailBtn()
		{
		}

		private void ClickJPGoStoreBtn()
		{
		}

		private void ClickJPBindAccountViewBtn()
		{
		}

		private void ClickJPSendMailViewBtn()
		{
		}

		private void ClickJPBindAcount()
		{
		}

		private void ClickJPSendMail()
		{
		}

		private void ClickJPGotoStore()
		{
		}

		private void CopyID()
		{
		}

		private void ConsumptionQuestionBtnClick()
		{
		}

		private void BugReportBtnClick()
		{
		}

		private void SuggestBtnClick()
		{
		}

		private void OtherConditionBtnClick()
		{
		}

		private void JPWarningBindAccount()
		{
		}

		private void JPBindAccountFunc()
		{
		}

		private void Return()
		{
		}

		private void GoServantList()
		{
		}

		private void GoWeaponList()
		{
		}

		private void GoAchie()
		{
		}

		private void ClickNeedHelp()
		{
		}

		public static void Quilt()
		{
		}

		private void alertQQYesHD()
		{
		}

		private void BtnsClick(int _index)
		{
		}

		private void ActionCenter()
		{
		}

		private void GoWitchWeaponWeb()
		{
		}

		private void GoWeb(string _url, bool _isOpenIn = true)
		{
		}

		private void SendTelephone()
		{
		}

		private void SendTelephoneSuccessful()
		{
		}

		private void SetTelWaitTimeText(float _value)
		{
		}

		private void SetEmailWaitTimeText(float _value)
		{
		}

		private void SendEmail()
		{
		}

		private void SendEmailSuccessful()
		{
		}

		private void BindTelephone()
		{
		}

		private void ShowBindLoot(ModelCollection<DrawResultData> loot, ModelCollection<DrawResultData> Weapon)
		{
		}

		private void ReSetTel()
		{
		}

		private void BindEmail()
		{
		}

		private void ReSetEmail()
		{
		}

		private void BindIdCard()
		{
		}

		private void ReSetIdCard()
		{
		}

		private void ExChange()
		{
		}

		private void KrExChange()
		{
		}

		public void GetAward()
		{
		}

		private void Share()
		{
		}

		public SettingTypeSelect GetSettingTypeCurrentSelect()
		{
			return default(SettingTypeSelect);
		}

		protected override void OnDestroy()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		private void Update()
		{
		}
	}
}
