using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using WaterBell.ProjX.Level.Event;
using unit;

public class HeroEntity : Entity
{
	public class LoadBuildNext
	{
		public ServantVO vo;

		public int type;

		public LoadBuildNext(ServantVO svVO, int stype)
		{
		}
	}

	public class ICompareEntity : IComparer<Entity>
	{
		private static float _r1;

		private static float _r2;

		private static float _angleMul;

		public int Compare(Entity x, Entity y)
		{
			return 0;
		}

		public static bool isInRound(Entity sEnemy)
		{
			return false;
		}
	}

	private class ExecJumpPointData
	{
		public Vector3 targetPosition;

		public Vector3 startPosition;

		public float time;

		public float timeTotal;

		public Function finishedHD;

		public GMathBezier.BezierData bezierData;
	}

	public static HeroEntity instance;

	public const float NORMAL_SEARCH_DIST = 6f;

	public const float MAX_SEARCH_DIST = 40f;

	public const float MAX_SEARCH_TIME = 2f;

	public const int NO_WEAPON = -1;

	[HideInInspector]
	public HeroActionMngr actMngr;

	[HideInInspector]
	public HeroVO heroVO;

	public Builder currentBuild;

	public bool isOfflineTest;

	public GameObject ZoneHint;

	public static int ANIM_STATE_NULL;

	public static int ANIM_STATE_LOCK;

	public static int ANIM_STATE_UNLOCK;

	[HideInInspector]
	public int anim_state;

	[HideInInspector]
	public long currWpServantCardID;

	public long svCardID;

	[HideInInspector]
	public Vector3 nextPos;

	[HideInInspector]
	public Entity nextTarget;

	private WeaponType _currWeaponType;

	private bool _isEnableAIProxy;

	private float _searchAndAttackTime;

	private bool _isEnableAutoMixedAIProxy;

	private bool _isTargetLocked;

	private EnergyRegenStateMachine energyRegenState;

	public EventDelegates.WeaponDelegate weaponDelegate;

	private LoadBuildNext _loadBulidNext;

	private IBuildPowerAndSharp powerAndSharp;

	private bool isGirlBattleModel;

	private ExecJumpPointData _ExecJumpPointData;

	private Dictionary<long, float> _weaponSharpLockTimeSteamp;

	private Dictionary<long, float> _weaponSharpLockTimeTotal;

	private bool isEnableAIProxy
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool isTargetLocked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool isEnergyRegenActived
	{
		get
		{
			return false;
		}
	}

	private bool isCanDash
	{
		get
		{
			return false;
		}
	}

	public bool IsHasNormalAtk
	{
		get
		{
			return false;
		}
	}

	public bool IsJump2Point
	{
		get
		{
			return false;
		}
	}

	public WeaponType GetCurrentWeaponType()
	{
		return default(WeaponType);
	}

	public override long GetID()
	{
		return 0L;
	}

	public override void InitTriggers()
	{
	}

	public override PropertiesVO GetProperty()
	{
		return null;
	}

	public override void Awake()
	{
	}

	protected override void BindActionMngr()
	{
	}

	private void OnPersished(UnitPerishedEvent e)
	{
	}

	public override List<long> GetSummonBuffIdList()
	{
		return null;
	}

	public override List<int> GetSummonBuffLayerList()
	{
		return null;
	}

	public override void Start()
	{
	}

	private void StatInfo()
	{
	}

	private void createUI()
	{
	}

	private void AddHeroSpawnBuffs()
	{
	}

	protected override void UpdateTargetSelection()
	{
	}

	protected override void UpdateUnitSkillDecision()
	{
	}

	public override float GetDashAbsDist()
	{
		return 0f;
	}

	public override void ExecDashEnd()
	{
	}

	private void CallEndCurrentSkill()
	{
	}

	private void CallInteruptCurrentSkill()
	{
	}

	private float GetCurrWpMeleeAtkRadius()
	{
		return 0f;
	}

	private float GetCurrWpMeleeAtkBestReleaseRange()
	{
		return 0f;
	}

	public float GetCurrDashAtkBestReleaseRange()
	{
		return 0f;
	}

	public float GetCurrWpMeleeAtkMaxDmgRange()
	{
		return 0f;
	}

	protected void MakeUniAtkDecision(bool isAtkSameTarget = false)
	{
	}

	public void OnTapUnit(MonsterEntity unit)
	{
	}

	public void OnSlidingFinish()
	{
	}

	public void OnSlidingStart(Vector3 mvDir)
	{
	}

	private void StatCommonAtkInfo()
	{
	}

	public override void onEvent(string evtName, GameObject go)
	{
	}

	public void CallHitCheckInAtkAniamation(bool isAnimationEnd = false)
	{
	}

	private void InteruptCommonSkill()
	{
	}

	public override void SafeExecStunEnd()
	{
	}

	public override void ExecModifyPostEnd()
	{
	}

	public void AdvExecStartMoveAndAtkUnit(Entity monster)
	{
	}

	public void AdvExecShowWinPose()
	{
	}

	[DebuggerHidden]
	private IEnumerator TryAdvExecShowWinPose()
	{
		return null;
	}

	public void AdvExecShowFailedPose()
	{
	}

	public void AdvExecRun2Dir(Vector3 mvDir)
	{
	}

	private void AdvExecFinishMove()
	{
	}

	public void AdvExecPressAtkBtn()
	{
	}

	private bool AdvExecAtkAuto()
	{
		return false;
	}

	public bool AdvExecTryCachedPreCMD()
	{
		return false;
	}

	private void MedExecStartMoveAndAttackUnit(Entity targetUnit)
	{
	}

	public override void Update()
	{
	}

	protected void MedExecActionEnd()
	{
	}

	protected override void ExecStandStill()
	{
	}

	private void ExecStandWhenQuestFailed()
	{
	}

	private void ExecStandWhenQuestWin()
	{
	}

	private void MedExecProxyAIAfterOneHit(bool isAnimationEnd = false)
	{
	}

	private void ExecWeaponAttack()
	{
	}

	private long GetRandomAttack()
	{
		return 0L;
	}

	private void SendBattleStateEnterEvent()
	{
	}

	private void SendBattleAreaEnterEvent(PlayerEnterZoneEvent e)
	{
	}

	private void SendBattleAreaOutEvent(MonsterInZoneClearEvent e)
	{
	}

	private void ExecDashAttackStart()
	{
	}

	public override void ExecAdjustPosAndDir()
	{
	}

	private void ExecRun2Dir(Vector3 mvDir, bool isChange2Run = false)
	{
	}

	private void ClearPreCMD()
	{
	}

	private void SavePreCMD_SelectedUnit(Entity monster)
	{
	}

	public override bool ExecDeath()
	{
		return false;
	}

	public void OnLoadIn()
	{
	}

	public void OnRestart()
	{
	}

	private void Reset()
	{
	}

	public void Init_OnEnterInitalArea()
	{
	}

	public void SetCurrHP(float targetHP)
	{
	}

	public float GetMaxHP()
	{
		return 0f;
	}

	private void ResetDefaultState4Player()
	{
	}

	public override void InitDelegates()
	{
	}

	public void SendChangeWeaponEvent(long weaponID, int type)
	{
	}

	public void PreloadBuildAndAnimations(ServantVO svVO)
	{
	}

	public GameObject LoadBuild(ServantVO svVO, int type)
	{
		return null;
	}

	public Entity Search(float maxSearchDist = 6f, bool ignoreDecoration = true)
	{
		return null;
	}

	public bool SearchAndStartAttack()
	{
		return false;
	}

	public override void CallAttackedCV()
	{
	}

	public override void CallActionEnd()
	{
	}

	public void ResetToPos(Vector4 pr)
	{
	}

	public void ShowAtBirthPoint(int areaIdx = 0, int zoneIdx = 0)
	{
	}

	public override void ClearTarget()
	{
	}

	public bool IsAllowSwapWeapon()
	{
		return false;
	}

	private bool IsInWeaponAtkRange(Entity unit = null)
	{
		return false;
	}

	public override int GetLevel()
	{
		return 0;
	}

	public override void ExecHatredChange(Entity sEntity, int sHarted)
	{
	}

	private void ExecFlashWhiteWeapon(GameObject sWeapon)
	{
	}

	public bool IsInCommonSkill()
	{
		return false;
	}

	public override void RunOnHitCallback(DamageEvent evt)
	{
	}

	public IBuildPowerAndSharp GetBuildPowerAndSharp()
	{
		return null;
	}

	public void ChangeBody(string newResPath)
	{
	}

	public static void CreateBodyByFightFashion(string controllerName = "")
	{
	}

	public void SetIsGirlModel(bool val)
	{
	}

	public bool GetIsGirlModel()
	{
		return false;
	}

	public static void CreateBodyHero(string newResPath, bool isGirl, string controllerName)
	{
	}

	private string GetPoolName()
	{
		return null;
	}

	private string GetPath()
	{
		return null;
	}

	private SimpleObjectPool GetPool(string name, string path)
	{
		return null;
	}

	public GameObject CreateBuildEff(out string poolname)
	{
		poolname = null;
		return null;
	}

	public void ChangeEffParent(string poolname)
	{
	}

	private void SetAutoSucide(Transform trans, string name)
	{
	}

	private bool childAllLightOff(Transform trans)
	{
		return false;
	}

	public void AddListener()
	{
	}

	private void UpdateExecJumpPoint()
	{
	}

	private void ExecJump2PointEnd()
	{
	}

	public void ExecJump2Point(Vector3 sTargetPosition, Function sFinishedHD, float sTime = 0.8f)
	{
	}

	private void LogInfo()
	{
	}

	public void ChangeNormalSpeed(float rate)
	{
	}

	public void ExecWeaponSharpLock(long sWeaponID, float sTime)
	{
	}

	public void ExecWeaponSharpUnLock(long sWeaponID)
	{
	}

	public float getWeaponSharpLockTime(long sWeaponID, float sDealy = 0f)
	{
		return 0f;
	}

	public float getWeaponSharpLockTimeTotal(long sWeaponID)
	{
		return 0f;
	}
}
