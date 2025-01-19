using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class MemberInfoViewPanelControl : UIAnimationPanelBase
	{
		public UILabel Name;

		public UILabel Lv;

		public Transform IconWidget;

		public UILabel Privilege;

		public UILabel fightingValue;

		public Transform BossType;

		public Transform AdminType;

		public Transform MemberTypeBody;

		public Transform RequestTypeBody;

		public Transform DismissTypeBtn;

		public Transform MemberBtn;

		public Transform RequestBtn;

		public UILabel TitleText;

		public UILabel LoginTime;

		public UILabel JoinTime;

		public UILabel TodayValue;

		public UILabel TotelValue;

		public UILabel ServantValue;

		public UISprite ServantSlider;

		public UILabel WeaponValue;

		public UISprite WeaponSlider;

		public UILabel StoryValue;

		public UISprite StorySlider;

		public UILabel AchievementValue;

		public UISprite AchievementSlider;

		private GameObject IconPrefab;

		public void SetMemeberInfo(GuildMember _info)
		{
		}

		public void SetRequestInfo(RequestMember _info)
		{
		}

		private void SetBtnEnable(GlobalEnum.GuildPrivilege _userType, int _selectType)
		{
		}

		private void SetBtn(ButtonEx _Btn, bool isActive, ButtonEx _DiaBtn)
		{
		}

		private void SetPresident(GlobalEnum.GuildPrivilege _userType, int _selectType)
		{
		}

		private void SetAdmin(GlobalEnum.GuildPrivilege _userType, int _selectType)
		{
		}

		private void SetMember(GlobalEnum.GuildPrivilege _userType, int _selectType)
		{
		}

		private void SetIcon(long _head, long headBox)
		{
		}
	}
}
