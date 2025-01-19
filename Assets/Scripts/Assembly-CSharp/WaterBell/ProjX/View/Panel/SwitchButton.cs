using UnityEngine;
using UnityEngine.Events;

namespace WaterBell.ProjX.View.Panel
{
	public sealed class SwitchButton : InteractionBase
	{
		[HideInInspector]
		public bool isOpen;

		[Space]
		public UnityEvent onOpenEvent;

		public UnityEvent onCloseEvent;

		private void Start()
		{
		}

		private void Init()
		{
		}

		private void OnClick()
		{
		}

		public void Close()
		{
		}

		public void Open()
		{
		}

		private void GetIsOpen()
		{
		}

		private void SetState(bool _isOpen)
		{
		}
	}
}
