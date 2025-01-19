using NodeCanvas.Framework;
using UnityEngine;
using UnityEngine.EventSystems;

namespace NodeCanvas.Tasks.Conditions
{
	public class InterceptEvent : ConditionTask<Transform>
	{
		public EventTriggerType eventType;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override string OnInit()
		{
			return null;
		}

		protected override bool OnCheck()
		{
			return false;
		}

		private void OnPointerEnter(PointerEventData eventData)
		{
		}

		private void OnPointerExit(PointerEventData eventData)
		{
		}

		private void OnPointerDown(PointerEventData eventData)
		{
		}

		private void OnPointerUp(PointerEventData eventData)
		{
		}

		private void OnPointerClick(PointerEventData eventData)
		{
		}

		private void OnDrag(PointerEventData eventData)
		{
		}

		private void OnDrop(BaseEventData eventData)
		{
		}

		private void OnScroll(PointerEventData eventData)
		{
		}

		private void OnUpdateSelected(BaseEventData eventData)
		{
		}

		private void OnSelect(BaseEventData eventData)
		{
		}

		private void OnDeselect(BaseEventData eventData)
		{
		}

		private void OnMove(AxisEventData eventData)
		{
		}

		private void OnSubmit(BaseEventData eventData)
		{
		}
	}
}
