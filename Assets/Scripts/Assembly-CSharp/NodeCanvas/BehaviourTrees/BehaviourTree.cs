using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees
{
	[GraphInfo]
	public class BehaviourTree : Graph, IResource
	{
		[Serializable]
		[StructLayout(LayoutKind.Sequential, Size = 8)]
		private struct DerivedSerializationData
		{
			public bool repeat;

			public float updateInterval;
		}

		[SerializeField]
		public bool repeat;

		[SerializeField]
		public float updateInterval;

		private float intervalCounter;

		private Status _rootStatus;

		private bool _isAsSubTree;

		private BehaviourTree _rootGraph;

		private BTNode _subtreeParentNode;

		private HashSet<BTNode> protectActiveHashSet;

		private bool _isTreeNeedReset;

		public bool enableLazyReset;

		public Status rootStatus
		{
			get
			{
				return default(Status);
			}
			private set
			{
			}
		}

		public override Type baseNodeType
		{
			get
			{
				return null;
			}
		}

		public override bool requiresAgent
		{
			get
			{
				return false;
			}
		}

		public override bool requiresPrimeNode
		{
			get
			{
				return false;
			}
		}

		public override bool autoSort
		{
			get
			{
				return false;
			}
		}

		public bool isAsSubTree
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public BehaviourTree rootGraph
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public BTNode subtreeParentNode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override bool useLocalBlackboard
		{
			get
			{
				return false;
			}
		}

		public bool isTreeInProtect
		{
			get
			{
				return false;
			}
		}

		public bool isTreeNeedReset
		{
			get
			{
				return false;
			}
		}

		public static event Action<BehaviourTree, Status> onRootStatusChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public override object OnDerivedDataSerialization()
		{
			return null;
		}

		public override void OnDerivedDataDeserialization(object data)
		{
		}

		protected override void OnGraphStarted()
		{
		}

		protected override void OnGraphUpdate()
		{
		}

		public Status Tick(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}

		public void MarkProtectActive(BTNode node)
		{
		}

		public void UnmarkProtectActive(BTNode node)
		{
		}

		public void MarkTreeNeedReset()
		{
		}

		public void ResetTree()
		{
		}

		public void ResetTreeAndBB()
		{
		}

		public BehaviourTree Preload()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public void PrintSubTreeHash()
		{
		}

		public void PrintNodeHash()
		{
		}

		public void PrintAllNodeHash()
		{
		}

		private string GetAllHash(BehaviourTree g)
		{
			return null;
		}

		public void OnBorrow()
		{
		}

		public void OnReturn()
		{
		}

		public void OnCloneComplete()
		{
		}

		public void OnFullFill()
		{
		}
	}
}
