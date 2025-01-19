using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class OnLongPressButton : MonoBehaviour
	{
		private const float limitBeginTime = 0.8f;

		private const float updateTime = 0.2f;

		private static OnLongPressButton target;

		public AnimationCurve speedCurve;

		private bool m_IsLongPress;

		private bool m_IsDrag;

		private bool m_IsPress;

		private float beginTime;

		private Vector2 dragOffset;

		public Action OnClickEvent;

		public Action OnBeginEvent;

		public Action<int> OnTickEvent;

		public Action OnEndEvent;

		private void OnDisable()
		{
		}

		private void OnPress(bool isPress)
		{
		}

		private void OnDrag(Vector2 delta)
		{
		}

		private void CheckIsLongPress()
		{
		}

		private void UpdateIsDrag()
		{
		}

		private void TriggerOnUpdateEvent()
		{
		}

		private void PressEnd()
		{
		}
	}
}
