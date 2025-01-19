using System;

namespace WaterBell.ProjX.View.Panel
{
	public class HeroDevPanel : UIPanelSingle
	{
		public static HeroDevPanel current;

		public const string CLOTH = "Cloth";

		public const string PROP = "Prop";

		public const string MAIN = "Main";

		public const string ACTION = "Action";

		public const string STORY = "Story";

		public const string CV = "CV";

		public LoadUIPanelSingle actionLoader;

		public LoadUIPanelSingle propLoader;

		public LoadUIPanelSingle clothLoader;

		public LoadUIPanelSingle storyLoader;

		public LoadUIPanelSingle cvLoader;

		public ButtonEx actionButton;

		public ButtonEx propButton;

		public ButtonEx clothButton;

		public ButtonEx storyButton;

		public ButtonEx backButton;

		public ButtonEx mainButton;

		public ButtonEx cvButton;

		private string currentChildName;

		private UIPanelSingle currentChild;

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		private void OpenChild(ButtonEx button)
		{
		}

		public void OpenChild(string child, bool isCloseSelf = true)
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		public void SetCloth(long id)
		{
		}

		private void ComeBack()
		{
		}
	}
}
