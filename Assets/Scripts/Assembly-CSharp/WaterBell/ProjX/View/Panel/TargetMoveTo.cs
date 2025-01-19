using UnityEngine;
using UnityEngine.Events;

namespace WaterBell.ProjX.View.Panel
{
	public class TargetMoveTo : MonoBehaviour
	{
		public float duration;

		private Animator animator;

		private GameObject mGo;

		[Space]
		public UnityEvent beginEvent;

		public UnityEvent endEvent;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public GameObject Move(GameObject clone, Transform to)
		{
			return null;
		}

		private void OnComplete()
		{
		}
	}
}
