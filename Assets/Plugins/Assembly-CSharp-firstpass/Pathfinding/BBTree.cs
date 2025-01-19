using UnityEngine;

namespace Pathfinding
{
	public class BBTree
	{
		private struct BBTreeBox
		{
			public Rect rect;

			public MeshNode node;

			public int left;

			public int right;

			public bool IsLeaf
			{
				get
				{
					return false;
				}
			}

			public BBTreeBox(BBTree tree, MeshNode node)
			{
				rect = default(Rect);
				this.node = null;
				left = 0;
				right = 0;
			}

			public bool Contains(Vector3 p)
			{
				return false;
			}
		}

		private BBTreeBox[] arr;

		private int count;

		public INavmeshHolder graph;

		public Rect Size
		{
			get
			{
				return default(Rect);
			}
		}

		public BBTree(INavmeshHolder graph)
		{
		}

		public void Clear()
		{
		}

		private void EnsureCapacity(int c)
		{
		}

		private int GetBox(MeshNode node)
		{
			return 0;
		}

		public void Insert(MeshNode node)
		{
		}

		public NNInfo Query(Vector3 p, NNConstraint constraint)
		{
			return default(NNInfo);
		}

		public NNInfo QueryCircle(Vector3 p, float radius, NNConstraint constraint)
		{
			return default(NNInfo);
		}

		public NNInfo QueryClosest(Vector3 p, NNConstraint constraint, out float distance)
		{
			distance = default(float);
			return default(NNInfo);
		}

		public NNInfo QueryClosestXZ(Vector3 p, NNConstraint constraint, ref float distance, NNInfo previous)
		{
			return default(NNInfo);
		}

		private void SearchBoxClosestXZ(int boxi, Vector3 p, ref float closestDist, NNConstraint constraint, ref NNInfo nnInfo)
		{
		}

		public NNInfo QueryClosest(Vector3 p, NNConstraint constraint, ref float distance, NNInfo previous)
		{
			return default(NNInfo);
		}

		private void SearchBoxClosest(int boxi, Vector3 p, ref float closestDist, NNConstraint constraint, ref NNInfo nnInfo)
		{
		}

		public MeshNode QueryInside(Vector3 p, NNConstraint constraint)
		{
			return null;
		}

		private MeshNode SearchBoxInside(int boxi, Vector3 p, NNConstraint constraint)
		{
			return null;
		}

		private void SearchBoxCircle(int boxi, Vector3 p, float radius, NNConstraint constraint, ref NNInfo nnInfo)
		{
		}

		private void SearchBox(int boxi, Vector3 p, NNConstraint constraint, ref NNInfo nnInfo)
		{
		}

		public void OnDrawGizmos()
		{
		}

		private void OnDrawGizmos(int boxi, int depth)
		{
		}

		private static bool NodeIntersectsCircle(MeshNode node, Vector3 p, float radius)
		{
			return false;
		}

		private static bool RectIntersectsCircle(Rect r, Vector3 p, float radius)
		{
			return false;
		}

		private static bool RectContains(Rect r, Vector3 p)
		{
			return false;
		}

		private static float ExpansionRequired(Rect r, Rect r2)
		{
			return 0f;
		}

		private static Rect ExpandToContain(Rect r, Rect r2)
		{
			return default(Rect);
		}

		private static float RectArea(Rect r)
		{
			return 0f;
		}
	}
}
