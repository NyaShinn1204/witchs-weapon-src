using UnityEngine;

namespace WaterBell.ProjX.Playmode
{
	public class PlayModeMngr : MonoBehaviour
	{
		private static PlayModeMngr _instance;

		private IPlayMode currPlayMode;

		private DebugNormalMode debugNormalMode;

		private DebugExpeditionMode debugExpeditionMode;

		private DebugLocalMode debugLocalMode;

		private StoryLineMode storylineMode;

		private ChallengeMode challengeMode;

		private ActivityChallengeMode activityChallengeMode;

		private DailyMode dailyMode;

		private ActivityProgressLineMode activityProgressLineMode;

		private ActivityAcceleratePlayMode activityAcceleratePlayMode;

		private ExpeditionMode expeditionMode;

		private WeaponDailyMode weaponDailyMode;

		private GuideStoryMode guideStoryMode;

		private Transform rootNode;

		private MngrCollection mc;

		private Rule1ActivityPlayMode activityRule1Mode;

		private Rule2ActivityPlayMode activityRule2Mode;

		private Rule3ActivityPlayMode activityRule3Mode;

		private Rule4ActivityPlayMode activityRule4Mode;

		private Rule5ActivityPlayMode activityRule5Mode;

		public static PlayModeMngr GetInstance()
		{
			return null;
		}

		public static PlayModeMngr GetExistedInstance()
		{
			return null;
		}

		public static PlayModeMngr TryGetExistedInstance()
		{
			return null;
		}

		public static bool IsInCombat()
		{
			return false;
		}

		private void Awake()
		{
		}

		private void Init()
		{
		}

		public void Reinit()
		{
		}

		private void Update()
		{
		}

		private void ReadKeyInput()
		{
		}

		public IPlayMode GetCurrPlayMode()
		{
			return null;
		}

		public bool IsInCoreCombat()
		{
			return false;
		}

		public IPlayMode TryGetCurrPlayMode()
		{
			return null;
		}

		public ExpeditionMode GetNewExpedition()
		{
			return null;
		}

		public WeaponDailyMode GetNewWeaponDaily(long instID)
		{
			return null;
		}

		public DailyMode GetNewDaily(long instID)
		{
			return null;
		}

		public ActivityProgressLineMode GetNewActivityProgressLine(long instID)
		{
			return null;
		}

		public ActivityAcceleratePlayMode GetNewActivityAcceleratePlayMode(long instID)
		{
			return null;
		}

		public GuideStoryMode GetNewGuideStory(long instID)
		{
			return null;
		}

		public StoryLineMode GetNewStoryLine(long instID)
		{
			return null;
		}

		public ChallengeMode GetNewChallenge(long instID, long sid)
		{
			return null;
		}

		public ActivityChallengeMode GetNewActivityChallenge(long instID, long baseID, int Serial, int BattleCount, int BattleMaxCount, int mode, string extraargu)
		{
			return null;
		}

		public DebugNormalMode GetNewDebugNormal()
		{
			return null;
		}

		public DebugExpeditionMode GetNewDebugExpedition()
		{
			return null;
		}

		public DebugLocalMode GetNewDebugLocal()
		{
			return null;
		}

		public BasicActivityPlayMode GetNewActivityPlayMode()
		{
			return null;
		}

		public void Dispose()
		{
		}

		public static bool IsPlayModeInCoreCombat()
		{
			return false;
		}

		public ActivityIDInfo GetCurrInstanceActivityIDInfo()
		{
			return null;
		}
	}
}
