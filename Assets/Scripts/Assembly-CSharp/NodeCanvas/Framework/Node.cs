using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Framework
{
	[Serializable]
	[SpoofAOT]
	public abstract class Node
	{
		[SerializeField]
		private Vector2 _position;

		[SerializeField]
		private string _UID;

		[SerializeField]
		private string _name;

		[SerializeField]
		private string _tag;

		[SerializeField]
		private string _comment;

		[SerializeField]
		private bool _isBreakpoint;

		private Graph _graph;

		private List<Connection> _inConnections;

		private List<Connection> _outConnections;

		private int _ID;

		[NonSerialized]
		private Status _status;

		[NonSerialized]
		private string _nodeName;

		[NonSerialized]
		private string _nodeDescription;

		public Graph graph
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int ID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public List<Connection> inConnections
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public List<Connection> outConnections
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public Vector2 nodePosition
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public string UID
		{
			get
			{
				return null;
			}
		}

		private string customName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string tag
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string nodeComment
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isBreakpoint
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual string name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual string description
		{
			get
			{
				return null;
			}
		}

		public abstract int maxInConnections { get; }

		public abstract int maxOutConnections { get; }

		public abstract Type outConnectionType { get; }

		public abstract bool allowAsPrime { get; }

		public abstract bool showCommentsBottom { get; }

		public Status status
		{
			get
			{
				return default(Status);
			}
			protected set
			{
			}
		}

		public Component graphAgent
		{
			get
			{
				return null;
			}
		}

		public IBlackboard graphBlackboard
		{
			get
			{
				return null;
			}
		}

		public bool isChecked { get; set; }

		public Node()
		{
		}

		public static Node Create(Graph targetGraph, Type nodeType, Vector2 pos)
		{
			return null;
		}

		public Node Duplicate(Graph targetGraph)
		{
			return null;
		}

		public virtual void OnValidate(Graph assignedGraph)
		{
		}

		public virtual void OnDestroy()
		{
		}

		public virtual Status Execute(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}

		[DebuggerHidden]
		private IEnumerator YieldBreak(Component agent, IBlackboard blackboard)
		{
			return null;
		}

		protected Status Error(string log)
		{
			return default(Status);
		}

		public void Reset(bool recursively = true)
		{
		}

		public void SendEvent(EventData eventData)
		{
		}

		public void RegisterEvents(params string[] eventNames)
		{
		}

		public void RegisterEvents(Component targetAgent, params string[] eventNames)
		{
		}

		public void UnRegisterEvents(params string[] eventNames)
		{
		}

		public void UnRegisterEvents(Component targetAgent, params string[] eventNames)
		{
		}

		public void UnregisterAllEvents()
		{
		}

		public void UnregisterAllEvents(Component targetAgent)
		{
		}

		public bool IsNewConnectionAllowed()
		{
			return false;
		}

		public bool IsNewConnectionAllowed(Node sourceNode)
		{
			return false;
		}

		public int AssignIDToGraph(int lastID)
		{
			return 0;
		}

		public void ResetRecursion()
		{
		}

		protected Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		protected void StopCoroutine(Coroutine routine)
		{
		}

		public List<Node> GetParentNodes()
		{
			return null;
		}

		public List<Node> GetChildNodes()
		{
			return null;
		}

		protected virtual Status OnExecute(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}

		protected virtual void OnReset()
		{
		}

		public virtual void OnParentConnected(int connectionIndex)
		{
		}

		public virtual void OnParentDisconnected(int connectionIndex)
		{
		}

		public virtual void OnChildConnected(int connectionIndex)
		{
		}

		public virtual void OnChildDisconnected(int connectionIndex)
		{
		}

		public virtual void OnGraphStarted()
		{
		}

		public virtual void OnGraphStoped()
		{
		}

		public virtual void OnGraphPaused()
		{
		}

		public virtual void OnGraphUnpaused()
		{
		}

		public sealed override string ToString()
		{
			return null;
		}

		public void OnDrawGizmos()
		{
		}

		public void OnDrawGizmosSelected()
		{
		}
	}
}
