using System;
using System.Collections;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Framework
{
	[Serializable]
	[SpoofAOT]
	public abstract class Task
	{
		protected class AgentTypeAttribute : Attribute
		{
			public Type type;

			public AgentTypeAttribute(Type type)
			{
			}
		}

		protected class EventReceiverAttribute : Attribute
		{
			public string[] eventMessages;

			public EventReceiverAttribute(params string[] args)
			{
			}
		}

		protected class GetFromAgentAttribute : Attribute
		{
		}

		[SerializeField]
		private bool _isDisabled;

		[SerializeField]
		private TaskAgent overrideAgent;

		[NonSerialized]
		private IBlackboard _blackboard;

		[NonSerialized]
		private ITaskSystem _ownerSystem;

		[NonSerialized]
		private Component current;

		[NonSerialized]
		private bool _agentTypeInit;

		[NonSerialized]
		private Type _agentType;

		[NonSerialized]
		private string _taskName;

		[NonSerialized]
		private string _taskDescription;

		[NonSerialized]
		private string _obsoleteInfo;

		private bool alreaySetBB;

		protected Node nodeRef;

		public ITaskSystem ownerSystem
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public Component ownerAgent
		{
			get
			{
				return null;
			}
		}

		public IBlackboard ownerBlackboard
		{
			get
			{
				return null;
			}
		}

		protected float ownerElapsedTime
		{
			get
			{
				return 0f;
			}
		}

		public bool isActive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string obsolete
		{
			get
			{
				return null;
			}
		}

		public string name
		{
			get
			{
				return null;
			}
		}

		public string description
		{
			get
			{
				return null;
			}
		}

		public virtual Type agentType
		{
			get
			{
				return null;
			}
		}

		public string summaryInfo
		{
			get
			{
				return null;
			}
		}

		protected virtual string info
		{
			get
			{
				return null;
			}
		}

		public string agentInfo
		{
			get
			{
				return null;
			}
		}

		public bool agentIsOverride
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public string overrideAgentParameterName
		{
			get
			{
				return null;
			}
		}

		protected Component agent
		{
			get
			{
				return null;
			}
		}

		protected IBlackboard blackboard
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public string firstWarningMessage { get; private set; }

		public Task()
		{
		}

		public static T Create<T>(ITaskSystem newOwnerSystem) where T : Task
		{
			return null;
		}

		public static Task Create(Type type, ITaskSystem newOwnerSystem)
		{
			return null;
		}

		public virtual Task Duplicate(ITaskSystem newOwnerSystem)
		{
			return null;
		}

		public virtual void OnValidate(ITaskSystem ownerSystem)
		{
		}

		public void SetOwnerSystem(ITaskSystem newOwnerSystem)
		{
		}

		protected Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		protected void StopCoroutine(Coroutine routine)
		{
		}

		protected void SendEvent(string eventName)
		{
		}

		protected void SendEvent<T>(string eventName, T value)
		{
		}

		protected void SendEvent(EventData eventData)
		{
		}

		protected virtual string OnInit()
		{
			return null;
		}

		protected bool Set(Component newAgent, IBlackboard newBB)
		{
			return false;
		}

		private bool Initialize(Component newAgent, Type newType)
		{
			return false;
		}

		private bool InitializeAttributes(Component newAgent)
		{
			return false;
		}

		protected bool Error(string error)
		{
			return false;
		}

		public void RegisterEvent(string eventName)
		{
		}

		public void RegisterEvents(params string[] eventNames)
		{
		}

		public void UnRegisterEvent(string eventName)
		{
		}

		public void UnRegisterEvents(params string[] eventNames)
		{
		}

		public void UnRegisterAllEvents()
		{
		}

		public string GetWarning()
		{
			return null;
		}

		private string Internal_GetWarning()
		{
			return null;
		}

		public sealed override string ToString()
		{
			return null;
		}

		public virtual void OnDrawGizmos()
		{
		}

		public virtual void OnDrawGizmosSelected()
		{
		}

		public void PreSet(IBlackboard bb)
		{
		}

		public void SetNodeRef(Node node)
		{
		}

		public Node GetNodeRef()
		{
			return null;
		}
	}
}
