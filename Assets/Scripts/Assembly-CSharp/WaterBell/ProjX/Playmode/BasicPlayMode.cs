using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Levelmod;
using UnityEngine;
using WaterBell.ProjX.Data.Entity;
using WaterBell.ProjX.Data.NetIO;
using WaterBell.ProjX.Level.Event;

namespace WaterBell.ProjX.Playmode
{
	public class BasicPlayMode : IPlayMode
	{
		internal PlayModeState state;

		internal MngrCollection mc;

		private long startTime;

		protected ModeType modeType;

		protected bool isCheckPreState;

		public bool isQuickWin;

		protected int questRemainningTime;

		protected int questElapsedTime;

		public bool needRestartBattle;

		protected TypeCsvInstance instTableData;

		protected ObservableSingleLevel instProgress;

		protected int multiSweepMaxNum;

		protected int svCardNumLim;

		protected long[] selectedSvCardIDArr;

		protected long[] selectedSvBelongToRoleArr;

		protected long[] selectedSvWeaponIDArr;

		protected SvCardSelectFilter svCardSelectFilter;

		protected bool isSelectedSvNeedLock;

		protected bool[] lockedSlotArr;

		protected BattlePreloadingData preloadingData;

		protected UserInfoSimple userInfoSimple;

		private AsyncOperation asyncLoader;

		private AsyncOperation asyncLoader2;

		private AsyncOperation asyncLoader3;

		private const float preloadingProgressDoneMagicNumber = 0.9f;

		private bool isHandleLoadInNetMsgResult;

		public BasicPlayMode()
		{
		}

		public BasicPlayMode(long instID, MngrCollection mngrCollection)
		{
		}

		protected virtual void Init()
		{
		}

		public virtual void Renew(long instID)
		{
		}

		protected void CacheLoad()
		{
		}

		protected void CacheSave()
		{
		}

		public int GetQuestRemainningTime()
		{
			return 0;
		}

		public int GetQuestElapsedTime()
		{
			return 0;
		}

		public ModeType GetModeType()
		{
			return default(ModeType);
		}

		public PlayModeState GetState()
		{
			return default(PlayModeState);
		}

		public long GetInstanceID()
		{
			return 0L;
		}

		public void SetStartBattleTime(long time)
		{
		}

		public long GetStartBattleTime()
		{
			return 0L;
		}

		public long GetChapterID()
		{
			return 0L;
		}

		public long[] GetSelectedSvCardIDArr()
		{
			return null;
		}

		public long GetRestrictID()
		{
			return 0L;
		}

		public bool IsSelectCardRestricted()
		{
			return false;
		}

		public void RestrictCard()
		{
		}

		public bool IsSameDay()
		{
			return false;
		}

		public long[] GetSelectedSvBelongToRoleArr()
		{
			return null;
		}

		public void GenerateUserInfoSimpleWhenQuit()
		{
		}

		public long[] GetSelectedWpCardIDArr()
		{
			return null;
		}

		public string GetSelectedSvCardIDArrCompactStr()
		{
			return null;
		}

		public UserInfoSimple GetUserInfoSimple()
		{
			return null;
		}

		public BattleResult GetBattleResult()
		{
			return null;
		}

		public virtual void SetQuickWin(bool isQuickWin)
		{
		}

		public virtual ActionResult IsAllow2Fight()
		{
			return default(ActionResult);
		}

		public virtual ActionResult IsAllowShowSweepGameOnce()
		{
			return default(ActionResult);
		}

		public virtual ActionResult IsAllowShowSweepGameMultiTime()
		{
			return default(ActionResult);
		}

		public virtual ActionResult IsAble2SweepGameOnce()
		{
			return default(ActionResult);
		}

		public virtual ActionResult IsAble2SweepGameMultiTime()
		{
			return default(ActionResult);
		}

		public virtual ActionResult IsAble2SelectCard()
		{
			return default(ActionResult);
		}

		public virtual ActionResult IsAble2BeginGame()
		{
			return default(ActionResult);
		}

		public void DeselectCard(int slotIdx)
		{
		}

		public virtual long[] SelectCards(long[] svCardIDArr, long[] roleID)
		{
			return null;
		}

		protected virtual void SelectWeaponByCache(int slotIdx, long svCardID, long rid)
		{
		}

		public virtual void SwitchWeapon(int slotIdx, long svWeaponID)
		{
		}

		public virtual void ParseInstanceSettingData(string jsonStr)
		{
		}

		public virtual List<NetMsgBase> BuildInitialNetMsgList()
		{
			return null;
		}

		public virtual void ParseBattleResult(Levelmod.BattleResult result)
		{
		}

		public void OnShowDetailBegin()
		{
		}

		public void OnShowDetailReturn()
		{
		}

		public virtual void OnSelectCardBegin()
		{
		}

		public virtual void OnSelectCardReturn()
		{
		}

		public virtual void OnTryStartBegin()
		{
		}

		public void OnLoadInBegin()
		{
		}

		public virtual void OnLoadOutBegin()
		{
		}

		public virtual void OnCombatExit()
		{
		}

		public virtual void OnCombatRestart()
		{
		}

		public virtual void OnPreCombatBegin()
		{
		}

		public virtual void OnCoreCombatBegin()
		{
		}

		public virtual void OnLoadOutEnd()
		{
		}

		public virtual void UpdateLoop4CoreCombat()
		{
		}

		[DebuggerHidden]
		private IEnumerator LoadInProcess()
		{
			return null;
		}

		protected void RestartFailed(string failStr)
		{
		}

		protected void RestartProcess()
		{
		}

		[DebuggerHidden]
		private IEnumerator LoadOutProcess(bool sIsLoadingScene = true)
		{
			return null;
		}

		private void AddListener()
		{
		}

		protected virtual void OnPlayerEnterInitialArea(PlayerEnterInitialAreaEvent e)
		{
		}

		private void OnUnitPerished(UnitPerishedEvent e)
		{
		}

		private void OnCombatWin(QuestAccomplishedEvent e)
		{
		}

		private void OnCombatWinKillMoster()
		{
		}

		private void OnQuickWin()
		{
		}

		private void OnCombatLose(QuestFailedEvent e)
		{
		}

		private void OnPause(PauseEvent e)
		{
		}

		[DebuggerHidden]
		private IEnumerator WaitAndShowCombatWinAnimation()
		{
			return null;
		}

		[DebuggerHidden]
		private IEnumerator QuickWinFlow()
		{
			return null;
		}

		[DebuggerHidden]
		private IEnumerator WaitAndShowCombatLoseAnimation()
		{
			return null;
		}

		[DebuggerHidden]
		private IEnumerator WaitAndBack()
		{
			return null;
		}

		protected virtual void HandleLoadHero()
		{
		}

		[DebuggerHidden]
		protected virtual IEnumerator PreLoadingCompGetInstance()
		{
			return null;
		}

		[DebuggerHidden]
		protected virtual IEnumerator HandleLoadInNetMsg()
		{
			return null;
		}

		protected virtual void HandleLoadInCustomPart()
		{
		}

		protected virtual void HandleFillServantsData()
		{
		}

		protected virtual void HandleRestartCustomPart()
		{
		}

		protected virtual void HandleFetchBattleResult(bool isWin, int winStarNum = 0)
		{
		}

		[DebuggerHidden]
		protected virtual IEnumerator HandlePreCombatAnimation()
		{
			return null;
		}

		protected virtual void HandleSettlementAnimation()
		{
		}

		protected void TryEndLessonOnBattleInterrupted()
		{
		}

		protected virtual void OnBattleResultBack()
		{
		}

		public Vector4 GetHeroEntryPR(int areaIdx, int zoneIdx)
		{
			return default(Vector4);
		}

		public Vector3 GetNavPoint(int areaIdx, int zoneIdx)
		{
			return default(Vector3);
		}

		protected void DisableLevelEditorLayer()
		{
		}

		protected void ClearScreenCache()
		{
		}

		private void ClearRootNode()
		{
		}

		private string GetLoadOutSceneName()
		{
			return null;
		}

		private UserInfoSimple generateUserInfoSimple()
		{
			return null;
		}

		public void generateUserInfoWhenQuit()
		{
		}

		private void HandleUnlockChapter()
		{
		}

		private void HandleOpenCondition(int lvB4Battle, int lvA4Battle)
		{
		}

		private void HandleExtraInfo()
		{
		}

		private void finishiNotifyUpdateExpedition()
		{
		}

		public long GetSelectedWeaponIdByServantCardId(long svCardID)
		{
			return 0L;
		}

		public int GetGlobalBuffType()
		{
			return 0;
		}

		public virtual void Dispose()
		{
		}
	}
}
