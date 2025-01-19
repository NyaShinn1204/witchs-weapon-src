using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class GhostEffect : MonoBehaviour
	{
		public Transform target;

		[Space]
		public GameObject shadow;

		public Transform container;

		public List<GameObject> shadowList;

		[Space]
		public float limitDistance;

		public float duration;

		private Vector3 oldPosition;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void CreatShadow()
		{
		}

		[DebuggerHidden]
		private IEnumerator HideShadow(GameObject go)
		{
			return null;
		}
	}
}
