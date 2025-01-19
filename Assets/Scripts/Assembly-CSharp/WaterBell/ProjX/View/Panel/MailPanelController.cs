using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class MailPanelController : CommonScenePanel
	{
		public MailManagerView view;

		public static MailPanelController current;

		public MailItemInfo itemInfo;

		public GameObject selectIcon;

		public ButtonEx returnViewButton;

		public UIGrid grid;

		public UIScrollView scroll;

		public UIScrollBar scrollBar;

		public string mailID;

		public UIScrollView TextScroll;

		public ButtonEx GetAllBtn;

		public ButtonEx RemoveAllBtn;

		public ButtonEx unGetAllBtn;

		public ButtonEx unRemoveAllBtn;

		public Transform remindText;

		protected override void AddConfigItem()
		{
		}

		protected override void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public void SetRemindText()
		{
		}

		private void GetRewardAll()
		{
		}

		private void RemoveAll()
		{
		}

		private string CheckExsitGetReward()
		{
			return null;
		}

		private string CheckExsitRemove()
		{
			return null;
		}

		public void FreshGrid()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		private int sComparison<T>(T x, T y)
		{
			return 0;
		}

		public void LeanCloud()
		{
		}

		public void ReSetContent()
		{
		}
	}
}
