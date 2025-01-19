using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class AchievementController : CommonScenePanel
	{
		private GameObject achievement;

		private GameObject finishAchievement;

		public UIScrollView UnfinishedScroll;

		public UIGrid UnfinishedGrid;

		public UIScrollView FinishedScroll;

		public UIGrid FinishedGrid;

		public static AchievementController current;

		private bool _switch;

		public Transform swichButton;

		public ButtonEx closeButton;

		public UIScrollBar bar;

		protected override void AddConfigItem()
		{
		}

		protected override void Awake()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		private void Init()
		{
		}

		private void ShowList()
		{
		}

		public void FreshUIGrid()
		{
		}

		public void FreshOtherUIGrid()
		{
		}

		public void CloseButton()
		{
		}

		public void DestroyAchievementList()
		{
		}

		public void DestroyFinishList()
		{
		}

		private int Comparison<T>(T x, T y)
		{
			return 0;
		}

		public void SetItem(Transform tran, DrawResultData data)
		{
		}
	}
}
