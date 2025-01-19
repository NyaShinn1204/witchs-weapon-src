using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class LFP_KindButton : UIPanelSingle
	{
		public UILabel kindNameLabel;

		public UILabel kindNameLabel2;

		public UILabel apCloseLabel;

		public UILabel apCloseLabel2;

		public UILabel cutDownLabel;

		public UISprite icon;

		public UITexture buttonIcon;

		public UILabel currencyLabel;

		public LuckDrawButton drawButton;

		public LuckDrawButton draw10Button;

		public GameObject button;

		public LFP_KindButtonData kindButtonData;

		private ButtonEx buttonEx;

		public bool isDiamondDraw;

		public Action<LFP_KindButton> OnClick;

		private CrystalBallButton linkBall;

		private UIContainerWithSlider container;

		protected override void Start()
		{
		}

		private void Update()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void OnEffectChange(UIPanelBase ui, float value)
		{
		}

		public override void UpdatePanel()
		{
		}

		public void SetSelectState(bool isSelect)
		{
		}
	}
}
