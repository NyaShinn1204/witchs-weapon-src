using System;
using Pathfinding.Serialization;
using Pathfinding.Serialization.JsonFx;
using Pathfinding.Util;
using UnityEngine;

namespace Pathfinding
{
	public abstract class NavGraph
	{
		public byte[] _sguid;

		public AstarPath active;

		[JsonMember]
		public uint initialPenalty;

		[JsonMember]
		public bool open;

		public uint graphIndex;

		[JsonMember]
		public string name;

		[JsonMember]
		public bool drawGizmos;

		[JsonMember]
		public bool infoScreenOpen;

		[JsonMember]
		public Matrix4x4 matrix;

		public Matrix4x4 inverseMatrix;

		[JsonMember]
		public Pathfinding.Util.Guid guid
		{
			get
			{
				return default(Pathfinding.Util.Guid);
			}
			set
			{
			}
		}

		public virtual int CountNodes()
		{
			return 0;
		}

		public abstract void GetNodes(GraphNodeDelegateCancelable del);

		public void SetMatrix(Matrix4x4 m)
		{
		}

		public virtual void CreateNodes(int number)
		{
		}

		public virtual void RelocateNodes(Matrix4x4 oldMatrix, Matrix4x4 newMatrix)
		{
		}

		public NNInfo GetNearest(Vector3 position)
		{
			return default(NNInfo);
		}

		public NNInfo GetNearest(Vector3 position, NNConstraint constraint)
		{
			return default(NNInfo);
		}

		public virtual NNInfo GetNearest(Vector3 position, NNConstraint constraint, GraphNode hint)
		{
			return default(NNInfo);
		}

		public virtual NNInfo GetNearestForce(Vector3 position, NNConstraint constraint)
		{
			return default(NNInfo);
		}

		public virtual void Awake()
		{
		}

		public void SafeOnDestroy()
		{
		}

		public virtual void OnDestroy()
		{
		}

		public void ScanGraph()
		{
		}

		[Obsolete]
		public void Scan()
		{
		}

		public void ScanInternal()
		{
		}

		public abstract void ScanInternal(OnScanStatus statusCallback);

		public virtual Color NodeColor(GraphNode node, PathHandler data)
		{
			return default(Color);
		}

		public virtual void SerializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		public virtual void DeserializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		public virtual void PostDeserialization()
		{
		}

		public bool InSearchTree(GraphNode node, Path path)
		{
			return false;
		}

		public virtual void OnDrawGizmos(bool drawNodes)
		{
		}
	}
}
