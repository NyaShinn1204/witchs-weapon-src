using System;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Framework
{
	[SpoofAOT]
	public abstract class Connection
	{
		[SerializeField]
		private Node _sourceNode;

		[SerializeField]
		private Node _targetNode;

		[SerializeField]
		private bool _isDisabled;

		[NonSerialized]
		private Status _status;

		public Node sourceNode
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public Node targetNode
		{
			get
			{
				return null;
			}
			protected set
			{
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

		public Status status
		{
			get
			{
				return default(Status);
			}
			set
			{
			}
		}

		protected Graph graph
		{
			get
			{
				return null;
			}
		}

		public Connection()
		{
		}

		public static Connection Create(Node source, Node target, int sourceIndex)
		{
			return null;
		}

		public Connection Duplicate(Node newSource, Node newTarget)
		{
			return null;
		}

		public virtual void OnValidate(int sourceIndex, int targetIndex)
		{
		}

		public virtual void OnDestroy()
		{
		}

		public void SetSource(Node newSource, bool isRelink = true)
		{
		}

		public void SetTarget(Node newTarget, bool isRelink = true)
		{
		}

		public Status Execute(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}

		public void Reset(bool recursively = true)
		{
		}
	}
}
