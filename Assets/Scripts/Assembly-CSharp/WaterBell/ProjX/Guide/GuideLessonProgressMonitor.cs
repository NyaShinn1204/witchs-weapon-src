using UnityEngine;
using WaterBell.Framework.Event;
using WaterBell.ProjX.Guide.Event;

namespace WaterBell.ProjX.Guide
{
	public class GuideLessonProgressMonitor : MonoBehaviour
	{
		private static GuideLessonProgressMonitor _instance;

		public static bool isSkipAllGuide;

		private EventEngine UIEvt;

		private GuideLessonExecutor lessonExec;

		private GuideLessonProgressRecorder recorder;

		private GuideLessonLocalManager localManager;

		public UIInput subfixInput;

		public static GuideLessonProgressMonitor GetInstance()
		{
			return null;
		}

		private void Awake()
		{
		}

		public void OnSubfixInputCancel()
		{
		}

		public void OnSubfixInputSubmit()
		{
		}

		private void Init()
		{
		}

		private void AddListener_UIGuide()
		{
		}

		private void GuideUIEventHandler(GuideUIEvent uiEvt)
		{
		}

		private void GuideUIEvent4AdjustHandler(GuideUIEvent uiEvt)
		{
		}

		private void BtnClickHandlder(BtnClickUIEvent btnEvt)
		{
		}

		private void BtnDragFinishHandler(BtnDragFinishUIEvent btnEvt)
		{
		}

		private void BtnPressedHandler(BtnPrseedUIEvent btnEvt)
		{
		}

		private void CombatUnitEvtHandelr(CombatUnitCallEvent unitEvt)
		{
		}

		private void CombatWinHandler(CombatWinEvent winEvt)
		{
		}

		private void CombatFinishHandler(CombatFinishEvent finishEvt)
		{
		}

		private void CombatBeginHandler(CombatBeginEvent beginEvt)
		{
		}

		private void EnterCombatWaveHandler(EnterCombatWaveEvent fieldEvt)
		{
		}

		private void LeaveCombatZoneHandler(LeaveCombatZoneEvent fieldEvt)
		{
		}

		private void GuideDrawFinishEvtHandelr(GuideDrawFinishEvent drawEvt)
		{
		}
	}
}
