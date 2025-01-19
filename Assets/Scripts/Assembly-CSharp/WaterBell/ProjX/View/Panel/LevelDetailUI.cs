using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class LevelDetailUI : UIPanelSingle
	{
		[Space]
		private UILabel levelName;

		private UILabel levelDescription;

		private UILabel ballteCount;

		private UILabel stamia;

		public GameObject enemys;

		public GameObject loots;

		public CommonTipsBox tipsBox;

		public static int MONSTER_BOSS_TYPE;

		private bool isFromSelectLevel;

		public UIImageNGUI uiImage;

		[HideInInspector]
		public bool isFromSelectLevelTemp;

		public UIButton buy;

		public UIButton clear;

		public UIButton clear3;

		protected override void Start()
		{
		}

		public void OpenPanel(LevelDetail levelDetail, string chapterID, bool isFromSelectLevel = true)
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		public void ClickFight()
		{
		}

		private void SetLoots(LevelDetail levelDetail)
		{
		}

		private void SetEnemys(LevelDetail levelDetail)
		{
		}

		public void ShowTips(string tipsContent)
		{
		}
	}
}
