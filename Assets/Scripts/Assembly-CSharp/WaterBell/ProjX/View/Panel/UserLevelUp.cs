using System.Runtime.InteropServices;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class UserLevelUp : UIPanelSingle
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void CloseAnimationCompleteDelegate();

		private static UserLevelUp current;

		[Space]
		public UILabel levelLabel;

		public UILabel servantLevelLimitLabel;

		public UILabel vitLabel;

		public UILabel vitLimitLabel;

		public UILabel levelFakeLabel;

		public UILabel servantLevelLimitFakeLabel;

		public UILabel vitFakeLabel;

		public UILabel vitLimitFakeLabel;

		private UserLevelUpData mUserLevelData;

		public GameObject box_title_level1;

		public GameObject box_title_level2;

		public GameObject body1;

		public GameObject body2;

		public UILabel body2_text;

		public CloseAnimationCompleteDelegate OnCloseAnimationComplete;

		public static UserLevelUp GetInstance()
		{
			return null;
		}

		public override void UpdatePanel()
		{
		}

		private void GetText()
		{
		}

		private void ShowBody1()
		{
		}

		private void ShowBody2()
		{
		}

		public void OpenPanel(UserLevelUpData data)
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public override void Disappear()
		{
		}
	}
}
