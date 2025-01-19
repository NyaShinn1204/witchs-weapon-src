using System;
using UnityEngine;

namespace Pathfinding
{
	[Obsolete]
	public class LocalAvoidanceMover : MonoBehaviour
	{
		public float targetPointDist;

		public float speed;

		private Vector3 targetPoint;

		private LocalAvoidance controller;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
