using UnityEngine;

namespace WaterBell.ProjX.Guide.Content
{
	public class AsideIntroTextUI : MonoBehaviour
	{
		public UILabel wordLabel;

		public TypewriterEffect writer;

		public UITexture role;

		private string rolePath;

		private string lastRole;

		public TweenAlpha twaBgLeft;

		public TweenScale twsBGRight;

		public TweenScale twsBgLeft;

		public TweenPosition twpHead;

		public TweenPosition twpBGRight;

		public void Clear()
		{
		}

		private void Start()
		{
		}

		private void TWResetToBeginning()
		{
		}

		public void Show(string icon, string word)
		{
		}

		public void LetInstantFinish()
		{
		}

		public bool GetIsRunningAnim()
		{
			return false;
		}
	}
}
