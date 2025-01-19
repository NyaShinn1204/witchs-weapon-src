using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class StoryMiniPanel : UIPanelSingle
	{
		private const int STORY_COUNT = 3;

		private static StoryMiniPanel s_Current;

		private static int needNextStoryCount;

		public Animator tipsAnim;

		public UILabel tipsLabel;

		public UILabel tipsLabel2;

		public ButtonEx storyMainButton;

		public ButtonEx switchStateButton;

		public ButtonEx closeDetailButton;

		public GameObject detail;

		public UIPanelSingleContainer detailContainer;

		private StorySystemManagerView storySystemManagerView;

		private bool isDetailOpen;

		protected override void Awake()
		{
		}

		public static long GetMainLineProgress()
		{
			return 0L;
		}

		public static StoryMiniPanel GetInstance()
		{
			return null;
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public void ShowTips(string text)
		{
		}

		public void ShowNewStoryTips()
		{
		}

		public override void UpdatePanel()
		{
		}

		private void CloseDetail()
		{
		}

		private void ClosePanel()
		{
		}

		private void OpenDetail()
		{
		}
	}
}
