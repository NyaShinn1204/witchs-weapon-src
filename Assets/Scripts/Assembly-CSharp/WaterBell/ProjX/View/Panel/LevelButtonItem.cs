using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class LevelButtonItem : UIPanelSingle
	{
		public enum SourceKind
		{
			None = 0,
			MainLine = 1,
			Daily = 2,
			Store = 3
		}

		private static readonly Color normalColor;

		private static readonly Color hardColor;

		private static readonly Color shopColor;

		private static readonly Color dailyColor;

		private static readonly Color sweepInfoColor;

		public UISprite icon;

		public UILabel levelName;

		public UISprite lockIcon;

		public UISprite bg;

		public bool isChapterUnlock;

		public bool isLevelUnlock;

		public bool isNormal;

		public TypeCsvInstance levelTableData;

		public TypeCsvInstanceSet chapterTableData;

		public SourceKind sourceKind;

		public ButtonEx sweepButton;

		public ButtonEx multSweepButton;

		public ButtonEx gotoButton;

		public LevelButtonItemData lData;

		public Action<LevelButtonItem> OnGotoWay;

		public Action<SweepArgu> OnSweep;

		protected override void Awake()
		{
		}

		private void Sweep(int count)
		{
		}

		public override void UpdatePanel()
		{
		}
	}
}
