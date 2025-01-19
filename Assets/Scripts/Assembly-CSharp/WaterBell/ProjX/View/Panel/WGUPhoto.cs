using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class WGUPhoto : UIPanelSingle
	{
		[Space]
		public UITexture image;

		private TweenColor tweenerColor;

		private int skinIndex;

		public override void UpdatePanel()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		public void SetColor(Color color)
		{
		}
	}
}
