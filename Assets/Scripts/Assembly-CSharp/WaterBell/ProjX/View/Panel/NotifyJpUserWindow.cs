using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class NotifyJpUserWindow : MonoBehaviour
	{
		[SerializeField]
		private ButtonEx CheckProtoBtn;

		[SerializeField]
		private ButtonEx CancelBtn;

		[SerializeField]
		private ButtonEx ConfirmBtn;

		[SerializeField]
		private UIToggle AgreeProtoToggle;

		[SerializeField]
		private UIToggle AgreePrivacyToggle;

		[SerializeField]
		private ButtonEx AgreeProtoTextBtn;

		[SerializeField]
		private ButtonEx AgreePrivacyTextBtn;

		[SerializeField]
		private UILabel CheckProtoBtnText;

		[SerializeField]
		private UILabel CancelBtnText;

		[SerializeField]
		private UILabel ConfirmBtnText;

		[SerializeField]
		private UILabel AgreeProtoToggleText;

		[SerializeField]
		private UILabel TitleText;

		[SerializeField]
		private UILabel ProtoContentText;

		[SerializeField]
		private UIScrollBar UIScrollBar;

		private bool isAgreeProto;

		private bool isAgreePrivacy;

		private Action confirmAction;

		private void Awake()
		{
		}

		public void Show()
		{
		}

		public void SetConfirmAction(Action action)
		{
		}

		private void OnClickCheckProtoBtn()
		{
		}

		private void OnClickAgreePrivacyBtn()
		{
		}

		private void OnClickCancelBtn()
		{
		}

		private void OnClickConfirmBtn()
		{
		}
	}
}
