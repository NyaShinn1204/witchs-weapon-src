using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	public class CheckEvent : ConditionTask<GraphOwner>
	{
		[RequiredField]
		[SerializeField]
		public BBParameter<string> eventName;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected virtual string EventName()
		{
			return null;
		}

		protected override bool OnCheck()
		{
			return false;
		}

		public void OnCustomEvent(EventData receivedEvent)
		{
		}
	}
	public class CheckEvent<T> : ConditionTask<GraphOwner>
	{
		[SerializeField]
		[RequiredField]
		public BBParameter<string> eventName;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected virtual string EventName()
		{
			return null;
		}

		protected override bool OnCheck()
		{
			return false;
		}

		public void OnCustomEvent(EventData receivedEvent)
		{
		}
	}
}
