using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class AP5_SelectAwardBuff : UIPanelSingle
	{
		public UISprite icon;

		public GameObject select;

		public UILabel Activity5Buff1;

		private ButtonEx buttonEx;

		public Action<AP5_SelectAwardBuff> OnClickEvent;

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
