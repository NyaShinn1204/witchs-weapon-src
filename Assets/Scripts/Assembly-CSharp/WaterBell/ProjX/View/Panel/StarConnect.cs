using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class StarConnect : MonoBehaviour
	{
		private static Vector3 hidePos;

		public Transform start;

		public Transform end;

		public float interval;

		private ParticleSystem m_ParticleSystem;

		private LineRenderer m_LineRenderer;

		private ParticleSystem.Particle[] particles;

		private void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
