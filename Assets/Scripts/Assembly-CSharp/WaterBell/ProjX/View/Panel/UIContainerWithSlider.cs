using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class UIContainerWithSlider : UIPanelSingleContainer
	{
		public Transform anchorPoint;

		public float falloffDist;

		public float minScale;

		public float maxScale;

		public UICenterOnChild center;

		public event Action<UIPanelBase, float> OnEffectChange
		{
			add
			{
			}
			remove
			{
			}
		}

		private void Update()
		{
		}

		public T GetSelect<T>() where T : UIPanelSingle
		{
			return null;
		}
	}
}
