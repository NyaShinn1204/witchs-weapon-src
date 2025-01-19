using System;
using System.Collections.Generic;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas
{
	public class ActionListPlayer : MonoBehaviour, ITaskSystem, ISerializationCallbackReceiver
	{
		[NonSerialized]
		private ActionList _actionList;

		[SerializeField]
		private Blackboard _blackboard;

		[SerializeField]
		private List<UnityEngine.Object> _objectReferences;

		[SerializeField]
		private string _serializedList;

		Component ITaskSystem.agent
		{
			get
			{
				return null;
			}
		}

		UnityEngine.Object ITaskSystem.contextObject
		{
			get
			{
				return null;
			}
		}

		public ActionList actionList
		{
			get
			{
				return null;
			}
		}

		public IBlackboard blackboard
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float elapsedTime
		{
			get
			{
				return 0f;
			}
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		public static ActionListPlayer Create()
		{
			return null;
		}

		public void SendTaskOwnerDefaults()
		{
		}

		void ITaskSystem.SendEvent(EventData eventData)
		{
		}

		private void Awake()
		{
		}

		public void Play()
		{
		}

		public void Play(Action<bool> OnFinish)
		{
		}

		public void Play(Component agent, IBlackboard blackboard, Action<bool> OnFinish)
		{
		}

		public Status ExecuteAction()
		{
			return default(Status);
		}

		public Status ExecuteAction(Component agent)
		{
			return default(Status);
		}
	}
}
