using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class LFP_KindButtonNew : UIPanelSingle
	{
		public UILabel kindNameLabel;

		public UILabel apCloseLabel;

		public GameObject button;

		public LFP_KindButtonData kindButtonData;

		private ButtonEx buttonEx;

		public bool isDiamondDraw;

		public Action<LFP_KindButtonNew> OnClick;

		private CrystalBallButton linkBall;

		private UIContainerWithSlider container;

		private string strClose;

		private string strWillClose;

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
