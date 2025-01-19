using UnityEngine;

namespace UnityChan
{
	public class CameraController : MonoBehaviour
	{
		[SerializeField]
		private Vector3 focus;

		[SerializeField]
		private GameObject focusObj;

		public bool showInstWindow;

		private Vector3 oldPos;

		private void setupFocusObject(string name)
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnGUI()
		{
		}

		private void mouseEvent()
		{
		}

		private void mouseDragEvent(Vector3 mousePos)
		{
		}

		public void mouseWheelEvent(float delta)
		{
		}

		private void cameraTranslate(Vector3 vec)
		{
		}

		public void cameraRotate(Vector3 eulerAngle)
		{
		}
	}
}
