using System;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class ActivityRule5Panel : UIPanelSingle
	{
		public static AP5TowerType? prevOpenType;

		private static AP5TowerType? prevNormalopenType;

		private static AP5TowerType? prevHardOpenType;

		public AP5_UpperTowerPanel upperTower;

		public AP5_LowerTowerPanel lowerTower;

		public GameObject entrancePanel;

		public ButtonEx normalModeButton;

		public ButtonEx hardModeButton;

		public GameObject diffSelect;

		public GameObject hardLock;

		public UILabel activity5Difficulty1Title;

		public UILabel activity5Difficulty1Desc;

		public UILabel activity5Difficulty2Title;

		public UILabel activity5Difficulty2Desc;

		public UILabel activity5DifficultyRule;

		public ButtonEx confirmButton;

		public ButtonEx helpButton;

		private ButtonEx selectButton;

		protected override void Awake()
		{
		}

		private void SelectMode(ButtonEx button)
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		public void ShowEntrance(AP5TowerDifficulty difficulty)
		{
		}

		public void SwitchDifficulty(AP5TowerDifficulty difficulty)
		{
		}

		public void ShowTowerPanel(AP5TowerType towerType)
		{
		}
	}
}
