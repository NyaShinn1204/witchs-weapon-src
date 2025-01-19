using System;

namespace WaterBell.ProjX.View.Panel
{
	public class ActivityMultModeSlider : UIPanelSingle
	{
		public UISlider modeSlider;

		public UISprite modeRateNum;

		private int maxRate;

		private int currentModeRate;

		public Action<ActivityMultModeSlider> OnSliderChange;

		public int CurrentRate
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int MaxRate
		{
			get
			{
				return 0;
			}
		}

		public void Init(int maxRate)
		{
		}

		private void ForceUpdate(int rate)
		{
		}

		private void OnModeSliderChange()
		{
		}
	}
}
