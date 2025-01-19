using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class ForgeStep : UIPanelSingle
	{
		public UISprite selectBox;

		public UILabel gold;

		public UILabel equipName;

		public Article currentEquip;

		public UIWidget stepContainer;

		public UIWidget acquiringWay;

		public Transform stepHistoryButtonContainer;

		public List<UIWidget> needNumContainer;

		public ButtonEx backButton;

		public ButtonEx forgeButton;

		public UIPanel tempPanel;

		public ForgeInfo rootForgeInfo;

		public ForgeInfo currentForgeInfo;

		private ForgeStepButton[] stepHistoryButtons;

		public static ForgeStep current;

		public GameObject maskObj;

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public void OpenPanel(long id)
		{
		}

		public void RefreshPanel()
		{
		}

		public void ForgeTarget(ForgeInfo info)
		{
		}

		private void HideAllButton()
		{
		}

		private List<ForgeInfo> FindChild2RootStep(ForgeInfo info)
		{
			return null;
		}

		public void Forge()
		{
		}

		public void UseEuipSucc()
		{
		}

		public void ComposeSucc()
		{
		}

		private void PlayForgeAnim()
		{
		}

		private string CanCompose(long id, bool isRecursionMode = true)
		{
			return null;
		}

		public void GotoNextStep()
		{
		}
	}
}
