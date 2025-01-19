using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class CommonTipsBox : UIPanelSingle
	{
		private const int MIN_WIDTH = 500;

		[Space]
		public UILabel tipsLabel;

		public UISprite bg;

		private const float duration = 1f;

		public static CommonTipsBox current;

		private string text;

		protected override void Awake()
		{
		}

		private new void OnDisable()
		{
		}

		public void OpenPanel(string text)
		{
		}

		[DebuggerHidden]
		private IEnumerator ClosePanelDelay()
		{
			return null;
		}

		public override void ClosePanel(Action action = null)
		{
		}

		public void OnClickClosePanel()
		{
		}
	}
}
