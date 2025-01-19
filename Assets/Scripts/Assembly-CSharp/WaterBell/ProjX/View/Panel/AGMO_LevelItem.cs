using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class AGMO_LevelItem : UIPanelSingle
	{
		protected readonly string emptyIcon;

		public UISprite icon;

		public GameObject select;

		public GameObject passContent;

		public UISprite mobEnhance;

		public UILabel scoreLabel;

		public UILabel scoreTitleLabel;

		private ButtonEx button;

		[SerializeField]
		private AGMO_LevelItemData levelItemData;

		public Action<AGMO_LevelItem> OnClick;

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
