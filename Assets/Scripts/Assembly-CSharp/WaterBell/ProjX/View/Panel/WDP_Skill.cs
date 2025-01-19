using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class WDP_Skill : UIPanelSingle
	{
		public UILabel nameLabel;

		public UILabel topLabel;

		public UILabel bottomLabel;

		public WDP_SkillIcon skillButton1;

		public WDP_SkillIcon skillButton2;

		public ButtonEx helpButton;

		public UIPanelSingleContainer props;

		public GameObject selectIcon;

		protected int skillIndex;

		protected SingleWeaponInfo weaponInfo;

		protected SingleServantInfo servantInfo;

		protected override void Awake()
		{
		}

		private new void OnEnable()
		{
		}

		private new void OnDisable()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		protected override void BindData()
		{
		}

		public override void UpdatePanel()
		{
		}

		public void DrawPanel(float _patk = 0f, float _matk = 0f)
		{
		}

		private void OpenHelpPanel()
		{
		}

		protected virtual void SwitchSkill(int skillIndex)
		{
		}
	}
}
