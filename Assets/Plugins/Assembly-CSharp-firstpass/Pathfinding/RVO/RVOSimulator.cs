using UnityEngine;

namespace Pathfinding.RVO
{
	public class RVOSimulator : MonoBehaviour
	{
		public bool doubleBuffering;

		public bool interpolation;

		public int desiredSimulatonFPS;

		public ThreadCount workerThreads;

		public float qualityCutoff;

		public float stepScale;

		public float incompressibility;

		public float desiredVelocityWeight;

		private Simulator simulator;

		public Simulator GetSimulator()
		{
			return null;
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
