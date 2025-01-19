using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class GrailPanel : UIPanelSingle
	{
		public UISprite blood;

		public Transform lightingBalls;

		private Tween bloodTween;

		private List<Transform> lightingBallList;

		protected override void Awake()
		{
		}

		private void OnClick()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		private void LightingBallMoveTo(Transform worldPos)
		{
		}

		private void UpdateBloodValue(float value)
		{
		}
	}
}
