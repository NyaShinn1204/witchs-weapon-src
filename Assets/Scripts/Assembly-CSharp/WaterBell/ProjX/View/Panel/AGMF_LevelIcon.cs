using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class AGMF_LevelIcon : UIPanelSingle
	{
		private const string NORMAL_STATE = "Frame_Mine_Activity_BG_01";

		private const string UNPASS_STATE = "Frame_Mine_Activity_BG_02";

		private const string LAST_STATE = "Frame_Mine_Activity_BG_03";

		public UISprite stateIcon;

		public GameObject lockIcon;

		public ButtonEx fightingButton;

		public UILabel nameLabel;

		public UILabel fightingLabel;

		public UISprite levelIcon;

		public GameObject extraAward;

		public UILabel extraAwardLabel;

		public AGMF_LevelIconData data;

		public Action<AGMF_LevelIcon> OnFightingButtonClick;

		protected override void Awake()
		{
		}

		public override void UpdatePanel()
		{
		}

		public void SetFightingState(bool canFightingCLick)
		{
		}
	}
}
