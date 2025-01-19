using System.Collections.Generic;
using System.Threading;
using Pathfinding.RVO.Sampled;
using UnityEngine;

namespace Pathfinding.RVO
{
	public class Simulator
	{
		internal class WorkerContext
		{
			public Agent.VO[] vos;
		}

		private class Worker
		{
			public Thread thread;

			public int start;

			public int end;

			public int task;

			public AutoResetEvent runFlag;

			public ManualResetEvent waitFlag;

			public Simulator simulator;

			private bool terminate;

			private WorkerContext context;

			public Worker(Simulator sim)
			{
			}

			public void Execute(int task)
			{
			}

			public void WaitOne()
			{
			}

			public void Terminate()
			{
			}

			public void Run()
			{
			}
		}

		private bool doubleBuffering;

		private float desiredDeltaTime;

		private bool interpolation;

		private Worker[] workers;

		private List<Agent> agents;

		private List<ObstacleVertex> obstacles;

		private RVOQuadtree quadtree;

		public float qualityCutoff;

		public float stepScale;

		private float frameDeltaTime;

		private float deltaTime;

		private float prevDeltaTime;

		private float lastStep;

		private float lastFrame;

		private bool doUpdateObstacles;

		private bool doCleanObstacles;

		private int frameTimeBufferIndex;

		private float[] frameTimeBuffer;

		private WorkerContext coroutineWorkerContext;

		public RVOQuadtree Quadtree
		{
			get
			{
				return null;
			}
		}

		public float FrameDeltaTime
		{
			get
			{
				return 0f;
			}
		}

		public float DeltaTime
		{
			get
			{
				return 0f;
			}
		}

		public float PrevDeltaTime
		{
			get
			{
				return 0f;
			}
		}

		public bool Multithreading
		{
			get
			{
				return false;
			}
		}

		public float DesiredDeltaTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool Interpolation
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Simulator(int workers, bool doubleBuffering)
		{
		}

		public List<Agent> GetAgents()
		{
			return null;
		}

		public List<ObstacleVertex> GetObstacles()
		{
			return null;
		}

		public void ClearAgents()
		{
		}

		public void OnDestroy()
		{
		}

		~Simulator()
		{
		}

		public IAgent AddAgent(IAgent agent)
		{
			return null;
		}

		public IAgent AddAgent(Vector3 position)
		{
			return null;
		}

		public void RemoveAgent(IAgent agent)
		{
		}

		public ObstacleVertex AddObstacle(ObstacleVertex v)
		{
			return null;
		}

		public ObstacleVertex AddObstacle(Vector3[] vertices, float height)
		{
			return null;
		}

		public ObstacleVertex AddObstacle(Vector3[] vertices, float height, Matrix4x4 matrix)
		{
			return null;
		}

		public ObstacleVertex AddObstacle(Vector3 a, Vector3 b, float height)
		{
			return null;
		}

		public void UpdateObstacle(ObstacleVertex obstacle, Vector3[] vertices, Matrix4x4 matrix)
		{
		}

		private void ScheduleCleanObstacles()
		{
		}

		private void CleanObstacles()
		{
		}

		public void RemoveObstacle(ObstacleVertex v)
		{
		}

		public void UpdateObstacles()
		{
		}

		private void BuildQuadtree()
		{
		}

		public void Update()
		{
		}
	}
}
