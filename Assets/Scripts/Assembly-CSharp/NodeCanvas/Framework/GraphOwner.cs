using System;
using System.Collections.Generic;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Framework
{
	public abstract class GraphOwner : MonoBehaviour
	{
		public enum EnableAction
		{
			EnableBehaviour = 0,
			DoNothing = 1
		}

		public enum DisableAction
		{
			DisableBehaviour = 0,
			PauseBehaviour = 1,
			DoNothing = 2
		}

		[SerializeField]
		private string boundGraphSerialization;

		[SerializeField]
		private List<UnityEngine.Object> boundGraphObjectReferences;

		[HideInInspector]
		public EnableAction enableAction;

		[HideInInspector]
		public DisableAction disableAction;

		public static Action<GraphOwner> onOwnerBehaviourStateChange;

		protected Dictionary<Graph, Graph> instances;

		private bool startCalled;

		private static bool isQuiting;

		public abstract Graph graph { get; set; }

		public abstract IBlackboard blackboard { get; set; }

		public abstract Type graphType { get; }

		public bool isRunning
		{
			get
			{
				return false;
			}
		}

		public bool isPaused
		{
			get
			{
				return false;
			}
		}

		public float elapsedTime
		{
			get
			{
				return 0f;
			}
		}

		protected Graph GetInstance(Graph originalGraph)
		{
			return null;
		}

		protected Graph BindInstance(Graph originalGraph)
		{
			return null;
		}

		public void StartBehaviour()
		{
		}

		public void StartBehaviour2()
		{
		}

		public void StartBehaviour(Action<bool> callback)
		{
		}

		public void PauseBehaviour()
		{
		}

		public void StopBehaviour()
		{
		}

		public void UpdateBehaviour()
		{
		}

		public void SendEvent(string eventName)
		{
		}

		public void SendEvent<T>(string eventName, T eventValue)
		{
		}

		public void SendEvent(EventData eventData)
		{
		}

		public static void SendGlobalEvent(string eventName)
		{
		}

		public static void SendGlobalEvent<T>(string eventName, T eventValue)
		{
		}

		protected void OnApplicationQuit()
		{
		}

		protected void Awake()
		{
		}

		protected void Start()
		{
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		protected void OnDestroy()
		{
		}
	}
	public abstract class GraphOwner<T> : GraphOwner where T : Graph
	{
		[SerializeField]
		private T _graph;

		[SerializeField]
		private UnityEngine.Object _blackboard;

		public sealed override Graph graph
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public T behaviour
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public sealed override IBlackboard blackboard
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public sealed override Type graphType
		{
			get
			{
				return null;
			}
		}

		public void StartBehaviour(T newGraph)
		{
		}

		public void StartBehaviour(T newGraph, Action<bool> callback)
		{
		}

		public void SwitchBehaviour(T newGraph)
		{
		}

		public void SwitchBehaviour(T newGraph, Action<bool> callback)
		{
		}
	}
}
