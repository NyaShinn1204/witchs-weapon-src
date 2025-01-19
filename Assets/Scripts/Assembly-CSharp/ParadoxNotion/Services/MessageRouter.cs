using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ParadoxNotion.Services
{
	public class MessageRouter : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IDragHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, IEventSystemHandler
	{
		private Dictionary<string, List<object>> listeners;

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		public void OnDrop(BaseEventData eventData)
		{
		}

		public void OnScroll(PointerEventData eventData)
		{
		}

		public void OnUpdateSelected(BaseEventData eventData)
		{
		}

		public void OnSelect(BaseEventData eventData)
		{
		}

		public void OnDeselect(BaseEventData eventData)
		{
		}

		public void OnMove(AxisEventData eventData)
		{
		}

		public void OnSubmit(BaseEventData eventData)
		{
		}

		private void OnAnimatorIK(int layerIndex)
		{
		}

		private void OnBecameInvisible()
		{
		}

		private void OnBecameVisible()
		{
		}

		private void OnCollisionEnter(Collision collisionInfo)
		{
		}

		private void OnCollisionExit(Collision collisionInfo)
		{
		}

		private void OnCollisionStay(Collision collisionInfo)
		{
		}

		private void OnCollisionEnter2D(Collision2D collisionInfo)
		{
		}

		private void OnCollisionExit2D(Collision2D collisionInfo)
		{
		}

		private void OnCollisionStay2D(Collision2D collisionInfo)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void OnTriggerStay(Collider other)
		{
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		private void OnTriggerExit2D(Collider2D other)
		{
		}

		private void OnTriggerStay2D(Collider2D other)
		{
		}

		private void OnMouseDown()
		{
		}

		private void OnMouseDrag()
		{
		}

		private void OnMouseEnter()
		{
		}

		private void OnMouseExit()
		{
		}

		private void OnMouseOver()
		{
		}

		private void OnMouseUp()
		{
		}

		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		private void OnParticleCollision(GameObject other)
		{
		}

		public void OnCustomEvent(EventData eventData)
		{
		}

		public void Register(object target, params string[] messages)
		{
		}

		public void RegisterCallback(string message, Action callback)
		{
		}

		public void RegisterCallback<T>(string message, Action<T> callback)
		{
		}

		private void Internal_RegisterCallback(string message, Delegate callback)
		{
		}

		public void UnRegister(object target)
		{
		}

		public void UnRegister(object target, params string[] messages)
		{
		}

		public void Dispatch(string message, object arg)
		{
		}
	}
}
