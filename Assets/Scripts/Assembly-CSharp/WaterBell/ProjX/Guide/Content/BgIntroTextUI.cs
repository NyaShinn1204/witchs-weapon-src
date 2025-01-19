using UnityEngine;

namespace WaterBell.ProjX.Guide.Content
{
	public class BgIntroTextUI : MonoBehaviour
	{
		public UILabel topWordLabel;

		public UITexture topWordBG;

		public UILabel bottomWordLabel;

		public TypewriterEffect writerEffTop;

		public TypewriterEffect writerEffBottom;

		public Color defautCol;

		public UIAnchor uIAnchor;

		private int wordAmount;

		private void Awake()
		{
		}

		public void ClearAndHide()
		{
		}

		public void ShowTopTitle(string word, Vector2 offset, Color col, UIAnchor.Side side, Vector4 relativeAndPixelOffset, bool isBG, NGUIText.Alignment align = NGUIText.Alignment.Left, int fontSize = 32, UIWidget.Pivot pivot = UIWidget.Pivot.TopLeft)
		{
		}

		public void ShowBottomTitle(string word, Vector2 offset, Color col, UIAnchor.Side side, Vector4 relativeAndPixelOffset, NGUIText.Alignment align = NGUIText.Alignment.Left, int fontSize = 32, UIWidget.Pivot pivot = UIWidget.Pivot.TopLeft)
		{
		}

		public bool GetIsRunningAnim()
		{
			return false;
		}

		public void LetInstantFinish()
		{
		}
	}
}
