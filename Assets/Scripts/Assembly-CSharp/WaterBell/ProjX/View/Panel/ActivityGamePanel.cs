using System;
using WaterBell.ProjX.Playmode;

namespace WaterBell.ProjX.View.Panel
{
	public class ActivityGamePanel : UIPanelSingle
	{
		public static ActivityGamePanel current;

		public UILabel cdLabel;

		public ButtonEx openResetButton;

		public LoadUIPanelSingle resetPanelLoader;

		public AGP_HardLevel hardLevel;

		public AGP_LevelButton[] generalLevels;

		public UIPanelSingleContainer loots;

		public UITexture photo;

		public UILabel mobEnhanceLabel;

		public ButtonEx storeButton;

		public UISprite[] rates;

		public ActivityMultModeSlider multModeSlider;

		public UILabel multTipsLabel;

		public LoadUIPanelSingle awardLoader;

		public UITexture bgTex;

		public UILabel activity3OwnBuffLabel;

		private long cd;

		private int currentModeRate;

		private int currentLayer;

		private Rule3ActivityPlayMode playMode;

		private ActivityPlaySystemManagerView activityPlaySystemManagerView;

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		private string CheckCanReset(int layer)
		{
			return null;
		}

		private void ResetLayer(int layer)
		{
		}

		public void OnResetFinish()
		{
		}

		private void OnSliderChange(ActivityMultModeSlider slider)
		{
		}

		private void Update()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		public override void UpdatePanel()
		{
		}

		public void GetReward()
		{
		}

		public void LevelButtonClick(int index)
		{
		}

		public void GetRewardFinish()
		{
		}
	}
}
