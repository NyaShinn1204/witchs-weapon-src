using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class AGMO_NustrumItem : UIPanelSingle
	{
		protected readonly string emptyIcon;

		public UISprite useIcon;

		public UISprite icon;

		public GameObject select;

		private ButtonEx button;

		public Action<AGMO_NustrumItem> OnClick;

		protected override void Awake()
		{
		}

		public override void UpdatePanel()
		{
		}

		public void SetState(bool isSelect)
		{
		}
	}
}
