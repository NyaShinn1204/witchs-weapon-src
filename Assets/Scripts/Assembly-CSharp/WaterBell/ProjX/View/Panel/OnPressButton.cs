using UnityEngine;
using UnityEngine.Events;

namespace WaterBell.ProjX.View.Panel
{
	public sealed class OnPressButton : InteractionBase
	{
		[Space]
		public UnityEvent onPressEvent;

		public UnityEvent onUpEvent;

		private void OnPress(bool _isPress)
		{
		}
	}
}
