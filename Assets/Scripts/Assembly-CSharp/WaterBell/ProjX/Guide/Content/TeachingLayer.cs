using UnityEngine;

namespace WaterBell.ProjX.Guide.Content
{
	public class TeachingLayer : MonoBehaviour
	{
		private GameObject selfObj;

		private UILabel teachingLabel;

		private TeachingLine teachingLine;

		private UITexture maskTex;

		private Transform teachingLabelTF;

		private Transform teachingLineTF;

		private Transform maskBGTF;

		private int maskStatus;

		private void Awake()
		{
		}

		public void Begin()
		{
		}

		public void End()
		{
		}

		private void Clear()
		{
		}

		public void ShowWord(string word, Vector3 triggerPos, Vector3 offset2triggerObj, NGUIText.Alignment align = NGUIText.Alignment.Left)
		{
		}

		public void ShowLine(Vector3 triggerPos, Vector2 startPointOffset, Vector2 endPointOffset)
		{
		}

		public void HideLine()
		{
		}

		public void ShowMask(Vector2 scaleFactor, Vector3 finalPos, bool isSqrMask)
		{
		}

		public void ShowBg(string bgSpriteName)
		{
		}

		public void Hide()
		{
		}
	}
}
