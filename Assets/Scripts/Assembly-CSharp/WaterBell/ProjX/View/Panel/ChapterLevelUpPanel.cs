using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class ChapterLevelUpPanel : UIPanelSingle
	{
		private static ChapterLevelUpPanel current;

		public Transform currentContainer;

		public Transform prevContainer;

		public UILabel vitLabel;

		public UILabel vitPrevLabel;

		public UILabel vitLimitLabel;

		public UILabel vitLimitPrevLabel;

		public UILabel unlockPlayModeLabel;

		public GameObject unlockPlayMode;

		public ButtonEx closeButton;

		public GameObject effSource;

		private GameObject eff;

		private Action<ChapterLevelUpPanel> ClickEvent;

		[SerializeField]
		private int level;

		[SerializeField]
		private int prevLevel;

		[SerializeField]
		private int vit;

		[SerializeField]
		private int prevVit;

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		public static ChapterLevelUpPanel GetInstance()
		{
			return null;
		}

		private void OnButtonClick(GameObject go)
		{
		}

		public void OpenPanel(int prevLevel, int level, int prevVit, int vit, Action<ChapterLevelUpPanel> ClickEvent = null)
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		private void GetText()
		{
		}

		public void PlayUnlokSound()
		{
		}
	}
}
