using UnityEngine;

namespace UnityChan
{
	public class UnityChanControlScriptWithRgidBody : MonoBehaviour
	{
		public float animSpeed;

		public float lookSmoother;

		public bool useCurves;

		public float useCurvesHeight;

		public float forwardSpeed;

		public float backwardSpeed;

		public float rotateSpeed;

		public float jumpPower;

		private CapsuleCollider col;

		private Rigidbody rb;

		private Vector3 velocity;

		private float orgColHight;

		private Vector3 orgVectColCenter;

		private Animator anim;

		private AnimatorStateInfo currentBaseState;

		private GameObject cameraObject;

		private static int idleState;

		private static int locoState;

		private static int jumpState;

		private static int restState;

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnGUI()
		{
		}

		private void resetCollider()
		{
		}
	}
}
