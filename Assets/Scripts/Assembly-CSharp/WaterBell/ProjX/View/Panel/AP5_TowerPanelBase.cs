using System.Collections.Generic;
using WaterBell.ProjX.Data.Entity;
using WaterBell.ProjX.Playmode;

namespace WaterBell.ProjX.View.Panel
{
	public abstract class AP5_TowerPanelBase : UIPanelSingle
	{
		protected static readonly Dictionary<AP5TowerType, AP5CacheInfo> cacheInfoDict;

		private static long currentConfirmBuff;

		public ButtonEx resetButton;

		public ButtonEx switchModeButton;

		public UIPanelSingleContainer keys;

		public UITexture bgTex;

		public UILabel levelDescLabel;

		public UIContainerWithSlider levelIcons;

		public UIPanelSingleContainer levelStateIcons;

		public UITexture towerTypeTex;

		public UITexture cacheTowerTypeTex;

		public UIPanelSingleContainer towerKind;

		public UILabel towerKindNameLabel;

		public UILabel towerDescLabel;

		public UILabel resetBonusPrompt3;

		public UILabel selectBuffDescLabel;

		public UIPanelSingleContainer selectBuffContainer;

		public ButtonEx buffButton;

		public LoadUIPanelSingle buffDetailLoader;

		public UILabel intelligenceNameLabel;

		public UILabel intelligenceValueLabel;

		public UIPanelSingleContainer clearLevelAward;

		public LoadUIPanelSingle awardLoader;

		public UILabel Activity5Buff3;

		public UILabel resetValueLabel;

		public UILabel resetConsumeLabel;

		public UILabel resetLabel;

		public LoadUIPanelSingle resetConfirmLoader;

		public UILabel switchButtonLabel;

		public ButtonEx closeButton;

		public ButtonEx exchangeButton;

		public LoadUIPanelSingle exchangePanelLoader;

		public UILabel Activity5Buff2;

		public UILabel keyLabel;

		public UISprite keyIcon;

		public int selectAwardBuffIndex;

		public AP5TowerType towerType;

		public AP5TowerDifficulty towerDifficulty;

		public AP5TowerLayerKind towerLayerKind;

		public int currentTowerType;

		public float currentTowerAwardRate;

		public int currentLayer;

		public int maxLayer;

		public bool upperUnlock;

		public int minLayer;

		public int needVitWhenReset;

		public int lootModulus;

		public int extraLootLayer;

		public int extraLootType;

		public int serial;

		public int resetNeedActVit;

		public int layerProgress;

		public List<LotteryLootData> buffDataList;

		public float buffValue;

		public List<AP5_KeyData> keyDataList;

		public List<AP5_LevelIconData> levelIconDataList;

		public List<AP5_LevelStateIconData> levelStateIconDataList;

		public List<AP5_SelectAwardBuffData> selectAwardBuffDataList;

		public bool isDebug;

		protected Rule5ActivityPlayMode playMode;

		protected ApRule5View apRule5View;

		protected R5Data r5Data;

		protected R5BaseData r5BaseData;

		public static AP5_TowerPanelBase Instacnce;

		static AP5_TowerPanelBase()
		{
		}

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void Update()
		{
		}

		public void OnResetFinish()
		{
		}

		private void OpenBuffPanel()
		{
		}

		protected virtual void SwitchMode()
		{
		}

		protected virtual void ResetLayer()
		{
		}

		public void CheckOpenConfirm()
		{
		}

		private void OpenConfirmPanel(int mode)
		{
		}

		protected virtual void SetAward()
		{
		}

		private void SelectBuff(AP5_SelectAwardBuff buff)
		{
		}

		protected abstract void SetSelectAwardBuffData();

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		private void GotoNewLevel()
		{
		}

		public override void UpdatePanel()
		{
		}

		private void OnFightingClick(AGMF_LevelIcon levelIcon)
		{
		}

		public void GetReward()
		{
		}

		public static List<AP5_KeyData> GetKeyDataList()
		{
			return null;
		}

		protected virtual void GetRewardPanelClose()
		{
		}
	}
}
