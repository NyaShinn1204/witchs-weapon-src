using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using WaterBell.ProjX.View.Panel;

namespace WaterBell.ProjX.View.UIFrame
{
	public class UISceneManager
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		private delegate void GotoAction(Dictionary<int, object> arg);

		public enum Daily
		{
			TRIAL = 0,
			TASK = 1,
			Game = 2
		}

		public static long SaveSVid;

		private static UISceneManager instance;

		private Dictionary<int, UIScene> dic;

		private Dictionary<int, CommonScenePanel> commonSceneDic;

		public int SceneBeforeDetail;

		public static Daily DailyType;

		public BetterList<int> needTransitionSceneList;

		private UISceneState currentUISceneState;

		private static Stack<UISceneState> uiSceneStacks;

		private static List<int> conflictScenes;

		public static string backLua;

		public void DisposeAll()
		{
		}

		public void Dispose()
		{
		}

		public static UISceneManager getInstance()
		{
			return null;
		}

		private void SaveTransitionSceneList()
		{
		}

		private void Init()
		{
		}

		public void Hide(int id)
		{
		}

		public bool CheckSceneIsShow(int id)
		{
			return false;
		}

		public void DelayGoToMain()
		{
		}

		[DebuggerHidden]
		private IEnumerator DelayActions4GotoMain()
		{
			return null;
		}

		public void BackFromBattle()
		{
		}

		private void BackFromBattleToLevel()
		{
		}

		public float HideALL(int current = -1)
		{
			return 0f;
		}

		public UIScene GetUIScene(int ID)
		{
			return null;
		}

		public void Show(int ID, UIDataBase uIDataBase = null)
		{
		}

		private void InitScene(UIScene UIscene)
		{
		}

		public void AddCommonScenePanel(int name, CommonScenePanel panel)
		{
		}

		public CommonScenePanel getCommonScene(int name)
		{
			return null;
		}

		public int GetUiSceneStacksCount()
		{
			return 0;
		}

		private static void InitConflictScenes()
		{
		}

		public void PushUiSceneStacks(UISceneState currentState)
		{
		}

		public void PopUiSceneStacks()
		{
		}

		public void GotoBackLua(UISceneState currentState, UISceneState nextState, string sLua = "")
		{
		}

		public void Goto(UISceneState currentState, UISceneState nextState)
		{
		}

		public void GotoDirect(UISceneState myState)
		{
		}

		private void ShowPopUp(UISceneState myState)
		{
		}

		[DebuggerHidden]
		private IEnumerator GotoDirectDelayed(UISceneState myState, float delay)
		{
			return null;
		}

		private void GoAction(UISceneState state)
		{
		}

		private void ShowTopBar(UIScene uiscene)
		{
		}

		private void ShowPhone(UIScene uiscene)
		{
		}

		private void PlayBGM(UIScene uiscene)
		{
		}

		public void BackPreScene()
		{
		}

		public void GoBackMainScene()
		{
		}

		private void TryGotoWithMask(UISceneState nextState)
		{
		}

		public UISceneState GetCurrentUISceneState()
		{
			return null;
		}

		public void OpenPhone()
		{
		}

		public void ClosePhone()
		{
		}

		public void GoToInQuestPanel(long id)
		{
		}

		public void PackageGoto(int _type)
		{
		}

		private void GoToExpedition()
		{
		}

		private void GoToDaily()
		{
		}

		private void GoGuild()
		{
		}

		private void GoToLottery()
		{
		}

		private void GoShop()
		{
		}

		private void GoToWeaponDaily()
		{
		}
	}
}
