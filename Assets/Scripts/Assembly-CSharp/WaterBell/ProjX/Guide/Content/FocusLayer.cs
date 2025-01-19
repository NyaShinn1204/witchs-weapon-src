using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace WaterBell.ProjX.Guide.Content
{
	public class FocusLayer : MonoBehaviour
	{
		private const float CornerOffset = 8f;

		public GameObject focusOutline;

		public Transform LTCorner;

		public Transform RTCorner;

		public Transform LBCorner;

		public Transform RBCorner;

		public GameObject dynamicMask;

		public Transform topMask;

		public Transform rightMask;

		public Transform bottomMask;

		public Transform leftMask;

		public Transform centerMask;

		public GameObject clickPoint;

		public GameObject tipObj;

		public UILabel tipText;

		public Transform tipBg;

		public bool isHiding;

		private float focusX;

		private float focusY;

		private float focusW;

		private float focusH;

		private GameObject dragAni;

		private bool isFocusOnLotteryScene;

		private GameObject focusAni;

		private Vector3 offset;

		private Camera cam;

		private Camera lotteryCam;

		private float tipOffsetRight;

		private float tipOffsetLeft;

		public void FocusOnUIWidget(UIWidget widgetObj, Stage.FocusStyle style, int focusOffsetX, int focusOffsetY)
		{
		}

		[DebuggerHidden]
		public IEnumerator AutoFocusOnUIWidget(UIWidget widgetObj, Stage.FocusStyle style, int focusOffsetX, int focusOffsetY)
		{
			return null;
		}

		private void LocateUIWidget(UIWidget w)
		{
		}

		private void LocateCollider(BoxCollider box)
		{
		}

		public void FocusOnCollider(BoxCollider colliderObj, Stage.FocusStyle style, int focusOffsetX, int focusOffsetY)
		{
		}

		[DebuggerHidden]
		public IEnumerator AutoFocusOnCollider(BoxCollider colliderObj, Stage.FocusStyle style, int focusOffsetX, int focusOffsetY)
		{
			return null;
		}

		public void ShowTip(string word, int focusOffsetX, int focusOffsetY)
		{
		}

		public void Reset()
		{
		}

		public void SetFocusOnLottery(bool val)
		{
		}

		public bool GetFocusOnLottery()
		{
			return false;
		}

		private void SetFocusRegion(UIWidget widgetObj)
		{
		}

		private void SetFocusRegion(BoxCollider colliderObj)
		{
		}

		private void RelocateFocusOutline()
		{
		}

		private void RelocateDynamicMask()
		{
		}

		private void RelocateClickPoint(Stage.FocusStyle style, int focusOffsetX = 0, int focusOffsetY = 0)
		{
		}

		private void showDragAnim(Vector3 pos)
		{
		}

		private void RelocateHint(int focusOffsetX, int focusOffsetY)
		{
		}

		private void ReCaculatBoxCollider(BoxCollider box, out float posX, out float posY, out float w, out float h)
		{
			posX = default(float);
			posY = default(float);
			w = default(float);
			h = default(float);
		}

		private Vector3 GetAccumulatedUILocalPosition(Transform objTf)
		{
			return default(Vector3);
		}

		public void ReCaculateWidget(UIWidget widgetObj, out float posX, out float posY, out float w, out float h)
		{
			posX = default(float);
			posY = default(float);
			w = default(float);
			h = default(float);
		}

		private void ReCaculateWidget2(UIWidget widgetObj, out float posX, out float posY, out float w, out float h)
		{
			posX = default(float);
			posY = default(float);
			w = default(float);
			h = default(float);
		}

		private void AutoAdjustTipPosAndDirection(int focusOffsetX, int focusOffsetY)
		{
		}
	}
}
