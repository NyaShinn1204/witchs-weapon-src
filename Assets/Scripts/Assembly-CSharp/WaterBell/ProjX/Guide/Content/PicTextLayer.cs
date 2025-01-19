using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace WaterBell.ProjX.Guide.Content
{
	public class PicTextLayer : MonoBehaviour
	{
		public enum Style
		{
			Vertical = 0,
			Horizontal = 1,
			Arrow = 2,
			Text = 3
		}

		public enum ArrowStyle
		{
			Left = 0,
			LeftTop = 1,
			LeftBottom = 2,
			Right = 3,
			RightTop = 4,
			RightBottom = 5,
			Top = 6,
			TopLeft = 7,
			TopRight = 8,
			Bottom = 9,
			BottomLeft = 10,
			BottomRight = 11
		}

		public enum ArrowPositionStyle
		{
			Anchor = 0,
			ButtonEX = 1,
			Mob = 2
		}

		public enum CloseStyle
		{
			Screen = 0,
			Button = 1,
			NoClose = 2
		}

		public enum ArrowCloseStyle
		{
			Screen = 0,
			NoClose = 1
		}

		public UILabel label;

		public UITexture texture;

		public UISprite spriteBG;

		public UISprite spriteArrow;

		public GameObject button;

		public Transform trsPosition;

		public GameObject buttonClose;

		private UIAnchor anchorLabel;

		private UIAnchor anchorArrow;

		private BoxCollider colliderButton;

		private UIAnchor anchorPosition;

		private float arrowHeight;

		private float arrowWidth;

		private bool next;

		public bool isNext
		{
			get
			{
				return false;
			}
		}

		private void Start()
		{
		}

		private void StyleControl(Style style, Vector2 offset)
		{
		}

		private void EnableAnchorPosition(UIAnchor.Side side)
		{
		}

		[DebuggerHidden]
		private IEnumerator CalcLastScale()
		{
			return null;
		}

		[DebuggerHidden]
		private IEnumerator CalcLastScaleArrow()
		{
			return null;
		}

		private void ArrowStyleControl(ArrowStyle arrowStyle, float offset)
		{
		}

		[DebuggerHidden]
		private IEnumerator EnableAnchorArrow()
		{
			return null;
		}

		[DebuggerHidden]
		private IEnumerator CalcArrowLastPosition2ButtonEX(UIWidget widgetObj)
		{
			return null;
		}

		private void CalcArrowLastPosition(ArrowPositionStyle arrowPositionStyle, string arg, UIAnchor.Side side = UIAnchor.Side.Center)
		{
		}

		public void Show(string label, Vector2 offset, ArrowStyle arrowStyle, float offsetArrow, ArrowPositionStyle arrowPositionStyle, string arg, UIAnchor.Side side, ArrowCloseStyle arrowCloseStyle)
		{
		}

		public void Show(string picName, string label, Style style, Vector2 offset, CloseStyle closeStyle, bool isLanguage)
		{
		}

		public void Hide()
		{
		}

		public void Click(GameObject obj)
		{
		}
	}
}
