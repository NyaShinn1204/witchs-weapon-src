using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class RankUpEquip : UIPanelSingle
	{
		[Space]
		public UIPanelSingleContainer current;

		public UIPanelSingleContainer next;

		private UIPanelSingleContainer[] uIPanelSingleContainers;

		private RankUpEquipData rData;

		public UIGrid uiGrid;

		public UIScrollView scrollView;

		public static RankUpEquip instace;

		public Transform EquipDetailPos;

		public ButtonEx CloseBtn;

		public Transform selectTrs;

		[NonSerialized]
		public Transform selectTrsItem;

		private int selectItemIndex;

		private Vector3 origScrollViewPos;

		private Vector2 origScrollViewClipOffset;

		public int SelectItemIndex
		{
			get
			{
				return 0;
			}
		}

		protected override void Awake()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		private void Update()
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		private void ClosePanel()
		{
		}

		private void UpdateEquipDatas(UIPanelSingleContainer container, RankUpEquipData data)
		{
		}
	}
}
