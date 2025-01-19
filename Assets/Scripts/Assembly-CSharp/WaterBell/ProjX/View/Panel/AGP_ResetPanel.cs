using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class AGP_ResetPanel : UIPanelSingle
	{
		public ButtonEx cancelButton;

		public ButtonEx confirmButton;

		public ButtonEx bgCloseButton;

		public UILabel currentLayerLabel;

		public UILabel maxLayerLabel;

		public UILabel selectLayerLabel;

		public UISlider layerSlider;

		public UISprite sliderBar;

		public ButtonEx prevButton;

		public ButtonEx nextButton;

		public UILabel warningLabel;

		public UILabel freeCountLabel;

		public UILabel currencyLabel;

		public GameObject free;

		public GameObject currency;

		public GameObject currencyIcon;

		public int myMaxLayer;

		public int selectLayer;

		public int currentLayer;

		public int layerUpperLimit;

		private Func<int, string> CheckCanReset;

		private Action<int> OnReset;

		public bool isDebug;

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		public virtual void OpenPanel(int currentLayer, int myMaxLayer, long tipsID, Func<int, string> checkCanReset, Action<int> onReset)
		{
		}

		private void OnSliderChange()
		{
		}

		public override void UpdatePanel()
		{
		}

		protected virtual void ResetLayer()
		{
		}

		private void Close()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}
	}
}
