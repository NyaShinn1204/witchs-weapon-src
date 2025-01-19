using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public abstract class UIAnimGroup<T> : MonoBehaviour where T : UITweener
	{
		public AnimationCurve animationCurve;

		public float duration;

		public float delay;

		private void Update()
		{
		}

		public void PlayForward()
		{
		}

		public void PlayReverse()
		{
		}

		protected List<T> GetChildren()
		{
			return null;
		}

		protected virtual void ChildInit(T t)
		{
		}
	}
}
