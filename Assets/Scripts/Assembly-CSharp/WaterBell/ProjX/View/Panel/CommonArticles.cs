using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class CommonArticles : UIPanelSingle
	{
		private CommonArticlesData mdata;

		protected CommonArticlesData data;

		[Space]
		public UIImageNGUI iconImage;

		public UIImageNGUI qualityImage;

		public bool isOpenDetail;

		public UIPanelSingle detailPanel;

		protected UIPanelSingleContainer containerGrid;

		public override void UpdatePanel()
		{
		}

		protected void UpdateImage(CommonArticlesData _data)
		{
		}

		public void SetIcon(string iconName)
		{
		}

		public void SetQualityImage(int _quality)
		{
		}

		public virtual void SetCount(int _count)
		{
		}

		public void SetMaxCount(int _maxNum)
		{
		}

		public virtual void Use(int _num = 1)
		{
		}

		public void Get(int _num = 1)
		{
		}

		protected virtual void ChangeCount(int _num)
		{
		}
	}
}
