using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Pathfinding
{
	public class LocalAvoidance : MonoBehaviour
	{
		public enum ResolutionType
		{
			Sampled = 0,
			Geometric = 1
		}

		public struct VOLine
		{
			public VO vo;

			public Vector3 start;

			public Vector3 end;

			public bool inf;

			public int id;

			public bool wrongSide;

			public VOLine(VO vo, Vector3 start, Vector3 end, bool inf, int id, bool wrongSide)
			{
				this.vo = null;
				this.start = default(Vector3);
				this.end = default(Vector3);
				this.inf = false;
				this.id = 0;
				this.wrongSide = false;
			}
		}

		public struct VOIntersection
		{
			public VO vo1;

			public VO vo2;

			public float factor1;

			public float factor2;

			public bool inside;

			public VOIntersection(VO vo1, VO vo2, float factor1, float factor2, bool inside = false)
			{
				this.vo1 = null;
				this.vo2 = null;
				this.factor1 = 0f;
				this.factor2 = 0f;
				this.inside = false;
			}
		}

		public class HalfPlane
		{
			public Vector3 point;

			public Vector3 normal;

			public bool Contains(Vector3 p)
			{
				return false;
			}

			public Vector3 ClosestPoint(Vector3 p)
			{
				return default(Vector3);
			}

			public Vector3 ClosestPoint(Vector3 p, float minX, float maxX)
			{
				return default(Vector3);
			}

			public Vector3 Intersection(HalfPlane hp)
			{
				return default(Vector3);
			}

			public void DrawBounds(float left, float right)
			{
			}

			public void Draw()
			{
			}
		}

		public enum IntersectionState
		{
			Inside = 0,
			Outside = 1,
			Enter = 2,
			Exit = 3
		}

		[StructLayout(LayoutKind.Sequential, Size = 8)]
		public struct IntersectionPair : IComparable<IntersectionPair>
		{
			public float factor;

			public IntersectionState state;

			public IntersectionPair(float factor, bool inside)
			{
				this.factor = 0f;
				state = default(IntersectionState);
			}

			public void SetState(IntersectionState s)
			{
			}

			public int CompareTo(IntersectionPair o)
			{
				return 0;
			}
		}

		public class VO
		{
			public Vector3 origin;

			public Vector3 direction;

			public float angle;

			public float limit;

			public Vector3 pLeft;

			public Vector3 pRight;

			public Vector3 nLeft;

			public Vector3 nRight;

			public List<IntersectionPair> ints1;

			public List<IntersectionPair> ints2;

			public List<IntersectionPair> ints3;

			public void AddInt(float factor, bool inside, int id)
			{
			}

			public bool FinalInts(Vector3 target, Vector3 closeEdgeConstraint, bool drawGizmos, out Vector3 closest)
			{
				closest = default(Vector3);
				return false;
			}

			public bool Contains(Vector3 p)
			{
				return false;
			}

			public float ScoreContains(Vector3 p)
			{
				return 0f;
			}

			public void Draw(Color c)
			{
			}

			public static explicit operator HalfPlane(VO vo)
			{
				return null;
			}
		}

		public float speed;

		public float delta;

		public float responability;

		public ResolutionType resType;

		private Vector3 velocity;

		public float radius;

		public float maxSpeedScale;

		public Vector3[] samples;

		public float sampleScale;

		public float circleScale;

		public float circlePoint;

		public bool drawGizmos;

		protected CharacterController controller;

		protected LocalAvoidance[] agents;

		private Vector3 preVelocity;

		public const float Rad2Deg = 57.29578f;

		private const int maxVOCounter = 50;

		private List<VO> vos;

		private void Start()
		{
		}

		public void Update()
		{
		}

		public Vector3 GetVelocity()
		{
			return default(Vector3);
		}

		public void LateUpdate()
		{
		}

		public void SimpleMove(Vector3 desiredMovement)
		{
		}

		public Vector3 ClampMovement(Vector3 direction)
		{
			return default(Vector3);
		}

		public bool CheckSample(Vector3 sample, List<VO> vos)
		{
			return false;
		}
	}
}
