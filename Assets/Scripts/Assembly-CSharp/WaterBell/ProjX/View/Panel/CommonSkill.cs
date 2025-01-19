using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class CommonSkill : UIPanelSingle
	{
		[Space]
		public int index;

		public UILabel skillNameLabel;

		public UISprite icon;

		[Space]
		public GameObject unLockState;

		public UILabel typeLabel;

		public UILabel currentLevelLabel;

		public UILabel needGoldCountLabel;

		[Space]
		public GameObject lockState;

		public UISprite rankIcon;

		public UILabel typeLabelLock;

		public ButtonEx butttonEx;

		public UIButtonLongPressTick tickComp;

		private bool isNewTickStarted;

		private int tickSum;

		private int level2Sub;

		private CommonSkillData cData;

		protected override void Start()
		{
		}

		public override void UpdatePanel()
		{
		}

		private void onTickTrigger(int tickDelta)
		{
		}

		private void onTickDone()
		{
		}

		private void OnPress(bool isPress)
		{
		}
	}
}
