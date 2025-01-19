using System.Collections.Generic;
using UnityEngine;

namespace Pathfinding
{
	public class NodeLink2 : GraphModifier
	{
		protected static Dictionary<GraphNode, NodeLink2> reference;

		public Transform end;

		public float costFactor;

		public bool oneWay;

		private PointNode startNode;

		private PointNode endNode;

		private MeshNode connectedNode1;

		private MeshNode connectedNode2;

		private Vector3 clamped1;

		private Vector3 clamped2;

		private bool postScanCalled;

		private static readonly Color GizmosColor;

		private static readonly Color GizmosColorSelected;

		public Transform StartTransform
		{
			get
			{
				return null;
			}
		}

		public Transform EndTransform
		{
			get
			{
				return null;
			}
		}

		public GraphNode StartNode
		{
			get
			{
				return null;
			}
		}

		public GraphNode EndNode
		{
			get
			{
				return null;
			}
		}

		public static NodeLink2 GetNodeLink(GraphNode node)
		{
			return null;
		}

		public override void OnPostScan()
		{
		}

		public void InternalOnPostScan()
		{
		}

		public override void OnGraphsPostUpdate()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void RemoveConnections(GraphNode node)
		{
		}

		private void ContextApplyForce()
		{
		}

		public void Apply(bool forceNewCheck)
		{
		}

		private void DrawCircle(Vector3 o, float r, int detail, Color col)
		{
		}

		private void DrawGizmoBezier(Vector3 p1, Vector3 p2)
		{
		}

		public virtual void OnDrawGizmosSelected()
		{
		}

		public void OnDrawGizmos()
		{
		}

		public void OnDrawGizmos(bool selected)
		{
		}
	}
}
