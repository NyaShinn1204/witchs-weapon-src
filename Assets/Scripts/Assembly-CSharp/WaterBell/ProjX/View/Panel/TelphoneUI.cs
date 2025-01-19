using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class TelphoneUI : UIPanelSingle
	{
		[StructLayout(LayoutKind.Sequential, Size = 4)]
		public struct TelphoneState
		{
			public bool showBlackBg;

			public TelphoneState(bool showBlackBg)
			{
				this.showBlackBg = false;
			}
		}

		private static TelphoneState defaultState;

		public static TelphoneState currentState;

		public ButtonEx toggleButton;

		public ButtonEx servantListButton;

		public ButtonEx achievementButton;

		public ButtonEx quastButton;

		public ButtonEx shopButton;

		public ButtonEx closeButton;

		public ButtonEx guildButton;

		public ButtonEx clothingButton;

		public ButtonEx libraryButton;

		public ButtonEx caphButton;

		public GameObject mainRedPoint;

		public GameObject newMailRedPoint;

		public GameObject servantRedPoint;

		public GameObject receiveQuestPoint;

		public GameObject guildPoint;

		public UILabel dateLabel;

		public UILabel timeLabel;

		public UILabel amPmLabel;

		public GameObject timeContainer;

		public GameObject closeButtonContainer;

		public GameObject screen;

		static TelphoneUI()
		{
		}

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void OnAnyClick(GameObject go)
		{
		}

		private void Init()
		{
		}

		private void SwitchState()
		{
		}

		protected override void AddConfigItem()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		private void SetRedPoint()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		private void GoClothing()
		{
		}

		private void GoLibrary()
		{
		}

		private void GoServantList()
		{
		}

		private void GotoGuild()
		{
		}

		private void GoMail()
		{
		}

		private void GoAchievement()
		{
		}

		private void GoShop()
		{
		}

		private void GoTask()
		{
		}
	}
}
