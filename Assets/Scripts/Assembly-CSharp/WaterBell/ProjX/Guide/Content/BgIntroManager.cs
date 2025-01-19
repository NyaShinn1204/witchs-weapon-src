using UnityEngine;

namespace WaterBell.ProjX.Guide.Content
{
	public class BgIntroManager : MonoBehaviour
	{
		public BgIntroTextUI textUI;

		private bool isRunning;

		public bool GetIsRunning()
		{
			return false;
		}

		public bool GetIsRunningAnim()
		{
			return false;
		}

		public void LetInstantFinish()
		{
		}

		private void Awake()
		{
		}

		public void Begin(float x = 0f, float y = 0f)
		{
		}

		public void End()
		{
		}

		public void ShowTopTitle(string word, Vector2 offset, Color col, UIAnchor.Side side, Vector4 relativeAndPixelOffset, bool isBG, NGUIText.Alignment align = NGUIText.Alignment.Left, int fontSize = 32, UIWidget.Pivot pivot = UIWidget.Pivot.TopLeft)
		{
		}

		public void ShowBottomTitle(string word, Vector2 offset, Color col, UIAnchor.Side side, Vector4 relativeAndPixelOffset, NGUIText.Alignment align = NGUIText.Alignment.Left, int fontSize = 32, UIWidget.Pivot pivot = UIWidget.Pivot.TopLeft)
		{
		}

		private void Clear()
		{
		}
	}
}
