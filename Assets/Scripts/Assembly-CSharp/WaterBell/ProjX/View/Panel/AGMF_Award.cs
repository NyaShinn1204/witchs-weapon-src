using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class AGMF_Award : UIPanelSingle
	{
		public UISprite icon;

		public UILabel countLabel;

		public GameObject lockIcon;

		public GameObject select;

		public GameObject empty;

		public GameObject normal;

		private ButtonEx buttonEx;

		public Action<AGMF_Award> OnClickEvent;

		protected override void Awake()
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
