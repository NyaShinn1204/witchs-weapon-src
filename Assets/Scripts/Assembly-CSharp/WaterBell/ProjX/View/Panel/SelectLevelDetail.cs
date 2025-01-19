using System;
using UnityEngine;
using WaterBell.ProjX.Playmode;

namespace WaterBell.ProjX.View.Panel
{
	public class SelectLevelDetail : UIAnimationPanelBase
	{
		public static SelectLevelDetail current;

		private static readonly string generalBg;

		private static readonly string activityMode3Bg;

		public UITexture bgTex;

		public UILabel indexLabel;

		public UILabel chapterNameLabel;

		public UILabel chapterNameENLabel;

		public UILabel EnchapterName;

		public UILabel taskName;

		public UISprite typeIcon;

		public UIPanelSingleContainer lootContainer;

		public GameObject enemy;

		public UIPanelSingleContainer enemyContainer;

		public UISprite bossWideIcon;

		public UILabel powerLabel;

		public GameObject allies;

		public UIPanelSingleContainer alliesContainer;

		public UIWidget vitIcon;

		public UILabel needVitLabel;

		public UILabel residueDegreeLabel;

		public UILabel timeLabel;

		public UILabel taskDescLabel;

		public GameObject sweepConditionsGo;

		public UILabel sweepConditionsLabel;

		public GameObject sweepConditionsIcon;

		public UISprite environmentIcon;

		public UILabel environmentDescLabel;

		public UITable taskTable;

		public LoadUIPanelSingle leaderboardLoader;

		public ButtonEx activitySweepButton_1;

		public ButtonEx activitySweepButton_2;

		public ButtonEx sweepButton_1;

		public ButtonEx sweepButton_10;

		public ButtonEx nextStepButton;

		public ButtonEx resetButton;

		public ButtonEx leaderboardButton;

		public ButtonEx enemyButton;

		public ButtonEx alliesButton;

		public GameObject sweepButtons;

		public GameObject activitySweepButtons;

		private TypeCsvInstance levelData;

		private TypeCsvInstanceMobList mobData;

		private TypeCsvVictoryFailureConditions victoryFailureConditionsTableData;

		private TypeCsvInstanceSet chapterTableData;

		private ProgressSystemForLevelDetailView progressSystemForLevelDetailView;

		private CurrentLevelDetailView currentLevelDetailView;

		private ExpeditionSelectLevelView expeditionSelectLevelView;

		private ProgressSystemSweepView progressSystemSweepView;

		private ApLevelDetailView apLevelDetailView;

		private IPlayMode currmode;

		private ModeType modeType;

		private long instanceId;

		private long chapterId;

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		protected override void OnDestroy()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		private void ShowEnemy()
		{
		}

		private void ShowAllies()
		{
		}

		public override void UpdatePanel()
		{
		}

		public void GotoNextStep()
		{
		}

		private void CheckResource()
		{
		}

		private void FinishResourceCheck()
		{
		}

		private void SetLevelInfo()
		{
		}

		public void SetStateInfo()
		{
		}

		private void SetEnemyAndAllies()
		{
		}

		private void SetLootInfo()
		{
		}

		public void SetSweep()
		{
		}

		public static int GetMobLevel(int playerLevel, int coreLevelIndex)
		{
			return 0;
		}

		public void Sweep(int count)
		{
		}

		private void ActivitySweep(int count)
		{
		}

		public void ActivitySweepSuccful()
		{
		}

		public void SweepSuccessful()
		{
		}

		private void ResetBattleCount()
		{
		}

		private void ConfirmResetBattleCount()
		{
		}

		private bool IsModeSettingCorrect()
		{
			return false;
		}

		public override void ClosePanel(Action action = null)
		{
		}
	}
}
