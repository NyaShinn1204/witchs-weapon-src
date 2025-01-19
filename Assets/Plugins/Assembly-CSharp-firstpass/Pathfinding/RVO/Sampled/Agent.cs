using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Pathfinding.RVO.Sampled
{
	public class Agent : IAgent
	{
		[StructLayout(LayoutKind.Sequential, Size = 68)]
		public struct VO
		{
			public Vector2 origin;

			private Vector2 line1;

			private Vector2 line2;

			private Vector2 dir1;

			private Vector2 dir2;

			private Vector2 cutoffLine;

			private Vector2 cutoffDir;

			private float sqrCutoffDistance;

			private bool leftSide;

			private bool colliding;

			public VO(Vector2 center, Vector2 offset, float radius, Vector2 sideChooser, float inverseDt)
			{
				origin = default(Vector2);
				line1 = default(Vector2);
				line2 = default(Vector2);
				dir1 = default(Vector2);
				dir2 = default(Vector2);
				cutoffLine = default(Vector2);
				cutoffDir = default(Vector2);
				sqrCutoffDistance = 0f;
				leftSide = false;
				colliding = false;
			}

			private static bool Left(Vector2 a, Vector2 dir, Vector2 p)
			{
				return false;
			}

			private static float Det(Vector2 a, Vector2 dir, Vector2 p)
			{
				return 0f;
			}

			public Vector2 Sample(Vector2 p, out float weight)
			{
				weight = default(float);
				return default(Vector2);
			}
		}

		private Vector3 smoothPos;

		public float radius;

		public float height;

		public float maxSpeed;

		public float neighbourDist;

		public float agentTimeHorizon;

		public float obstacleTimeHorizon;

		public float weight;

		public bool locked;

		private RVOLayer layer;

		private RVOLayer collidesWith;

		public int maxNeighbours;

		public Vector3 position;

		public Vector3 desiredVelocity;

		public Vector3 prevSmoothPos;

		internal Agent next;

		private Vector3 velocity;

		private Vector3 newVelocity;

		public Simulator simulator;

		public List<Agent> neighbours;

		public List<float> neighbourDists;

		private List<ObstacleVertex> obstaclesBuffered;

		private List<ObstacleVertex> obstacles;

		private List<float> obstacleDists;

		public static Stopwatch watch1;

		public static Stopwatch watch2;

		public static float DesiredVelocityWeight;

		public static float DesiredVelocityScale;

		public static float GlobalIncompressibility;

		public Vector3 Position { get; set; }

		public Vector3 InterpolatedPosition
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 DesiredVelocity { get; set; }

		public RVOLayer Layer { get; set; }

		public RVOLayer CollidesWith { get; set; }

		public bool Locked { get; set; }

		public float Radius { get; set; }

		public float Height { get; set; }

		public float MaxSpeed { get; set; }

		public float NeighbourDist { get; set; }

		public float AgentTimeHorizon { get; set; }

		public float ObstacleTimeHorizon { get; set; }

		public Vector3 Velocity { get; set; }

		public bool DebugDraw { get; set; }

		public int MaxNeighbours { get; set; }

		public List<ObstacleVertex> NeighbourObstacles
		{
			get
			{
				return null;
			}
		}

		public Agent(Vector3 pos)
		{
		}

		public void Teleport(Vector3 pos)
		{
		}

		public void BufferSwitch()
		{
		}

		public void Update()
		{
		}

		public void Interpolate(float t)
		{
		}

		public void CalculateNeighbours()
		{
		}

		private float Sqr(float x)
		{
			return 0f;
		}

		public float InsertAgentNeighbour(Agent agent, float rangeSq)
		{
			return 0f;
		}

		public void InsertObstacleNeighbour(ObstacleVertex ob1, float rangeSq)
		{
		}

		private static Vector3 To3D(Vector2 p)
		{
			return default(Vector3);
		}

		private static void DrawCircle(Vector2 _p, float radius, Color col)
		{
		}

		private static void DrawCircle(Vector2 _p, float radius, float a0, float a1, Color col)
		{
		}

		private static void DrawVO(Vector2 circleCenter, float radius, Vector2 origin)
		{
		}

		private static void DrawCross(Vector2 p, float size = 1f)
		{
		}

		private static void DrawCross(Vector2 p, Color col, float size = 1f)
		{
		}

		internal void CalculateVelocity(Simulator.WorkerContext context)
		{
		}

		private static Color Rainbow(float v)
		{
			return default(Color);
		}

		private Vector2 Trace(VO[] vos, int voCount, Vector2 p, float cutoff, out float score)
		{
			score = default(float);
			return default(Vector2);
		}

		public static bool IntersectionFactor(Vector2 start1, Vector2 dir1, Vector2 start2, Vector2 dir2, out float factor)
		{
			factor = default(float);
			return false;
		}
	}
}
