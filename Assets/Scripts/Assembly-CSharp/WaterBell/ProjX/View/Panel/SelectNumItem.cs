using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class SelectNumItem : UIPanelSingle
	{
		public ButtonEx prevButton;

		public ButtonEx nextButton;

		public UIWidget centerArea;

		public Action<GameObject> OnSelectChangeEvent;

		private int currentIndex;

		private GameObject m_SelectItem;

		private UIWrapContent uiWrapContent;

		public GameObject SelectItem
		{
			get
			{
				return null;
			}
		}

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		private void OnInitializeItem(GameObject go, int wrapIndex, int realIndex)
		{
		}

		public void RebuildItem(int start, int end)
		{
		}

		private void Prev()
		{
		}

		private void Next()
		{
		}

		public void Select(int index)
		{
		}

		private int GetCenter()
		{
			return 0;
		}
	}
}
