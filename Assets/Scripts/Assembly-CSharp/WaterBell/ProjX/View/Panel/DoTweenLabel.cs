using System;
using DG.Tweening;

namespace WaterBell.ProjX.View.Panel
{
	public sealed class DoTweenLabel : DoTweenObject
	{
		public long from;

		public long to;

		public float duration;

		public Ease easeType;

		public string prefix;

		public UILabel uilabel;

		public Action<int> onUpdateEvent;

		public override void Change()
		{
		}

		public void SetValue(long value)
		{
		}

		public void Change(long _to)
		{
		}

		public void Change(long _from, long _to)
		{
		}

		private void LabelUpdate(float _value)
		{
		}
	}
}
