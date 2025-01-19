using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.Battle.Unit;

public class CharacterBase : MonoBehaviour, IPausedComponent
{
	private class ModfiyMove
	{
		private float _time;

		public ModfiyMove(float sTime)
		{
		}

		public bool eventModfiy(Entity sSource, Entity sTarget)
		{
			return false;
		}

		private Vector3 getModfiyPosition(Entity sTarget)
		{
			return default(Vector3);
		}
	}

	private class ModfiyRotation
	{
		private float _time;

		public ModfiyRotation(float sTime)
		{
		}

		public bool eventModfiy(Entity sSource, Entity sTarget)
		{
			return false;
		}
	}

	private ModfiyMove _modfiyMove;

	private ModfiyRotation _modfiyRotation;

	public PauseType _PauseType;

	private const float SPACING_BC = 0f;

	public const float HEART_HEIGHT = 0.5f;

	private const float UPPER_BODY_CENTER_HEIGHT = 0.66f;

	public Delegates.SouceDelegate OnBreak;

	public Delegates.SouceDelegate OnDead;

	[HideInInspector]
	public AnimatorController animatorController;

	[HideInInspector]
	public EffectsBander effectsBander;

	[HideInInspector]
	public CharacterStateManager stateMngr;

	[HideInInspector]
	public ActionMngr actionMngr;

	[HideInInspector]
	public Entity currentTarget;

	[HideInInspector]
	public Entity dashTarget;

	[HideInInspector]
	public Vector3 dashTargetPos;

	protected int _hatred;

	protected Entity _hatredTarget;

	[HideInInspector]
	public bool canSkipSpawn;

	[HideInInspector]
	public bool isGhost;

	[HideInInspector]
	public bool breakable;

	public bool isDecoration;

	[HideInInspector]
	public bool castYY;

	[HideInInspector]
	public float height;

	[HideInInspector]
	public float radius;

	[HideInInspector]
	public string prefabName;

	[HideInInspector]
	public string prefabURL;

	[HideInInspector]
	public float currSkillReleaseRange;

	protected float _skillChargeTime;

	private int _nextAnimation;

	private bool _cannotDie;

	protected bool _cannotChoose;

	public bool isPushHelper;

	public float dashDisWeaponStop;

	protected bool _followerAble;

	protected float _followerDistance;

	public EffectMaster effectMaster;

	protected bool _isSpawnEnd;

	public List<string> controllerStack;

	public PackCombiner packCombiner;

	public BuffGroup buffGroup;

	public List<BuffEntity> buffs;

	public List<BuffEntity> buffCache;

	public BuffShaderHistory buffShaderHistory;

	protected TriggerManager triggerManager;

	protected StateVO state;

	public Skill activeSkill;

	public List<Skill> skills;

	public List<Skill> skillCache;

	private float _safeZoneAbsDist;

	protected bool _isRemoveCalled;

	private string _KEY_FRAME_FLASH;

	private List<string> _statePush;

	private bool _pauseColliderEnable;

	private bool _pauseRigidbody;

	private bool _isSavePauseCollider;

	public bool isSpawnEnd
	{
		get
		{
			return false;
		}
	}

	public bool isDead
	{
		get
		{
			return false;
		}
	}

	public bool isDeathImmue
	{
		get
		{
			return false;
		}
	}

	public bool isTargetValid
	{
		get
		{
			return false;
		}
	}

	public float safeZoneAbsDist
	{
		get
		{
			return 0f;
		}
	}

	public virtual bool needReverse
	{
		get
		{
			return false;
		}
	}

	public virtual bool isSpawn
	{
		get
		{
			return false;
		}
	}

	public virtual bool isFree
	{
		get
		{
			return false;
		}
	}

	public bool cannotChoose
	{
		get
		{
			return false;
		}
	}

	public virtual Vector3 feetPosition
	{
		get
		{
			return default(Vector3);
		}
	}

	public virtual Vector3 centerPosition
	{
		get
		{
			return default(Vector3);
		}
	}

	public virtual Vector3 upperBodyCenterPosition
	{
		get
		{
			return default(Vector3);
		}
	}

	public virtual Vector3 upperBodyCenterOffeset
	{
		get
		{
			return default(Vector3);
		}
	}

	public virtual Vector3 headTopPosition
	{
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 fixedForward
	{
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 fixedRight
	{
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 fixedLeft
	{
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 fixedEulerAngles
	{
		get
		{
			return default(Vector3);
		}
	}

	protected virtual string deathAnim
	{
		get
		{
			return null;
		}
	}

	public virtual float GetDashAbsDist()
	{
		return 0f;
	}

	protected virtual void ResetVolume()
	{
	}

	public virtual void ClearTarget()
	{
	}

	public virtual void Awake()
	{
	}

	protected virtual void BindActionMngr()
	{
	}

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	protected void eventModfinyY()
	{
	}

	protected void InsertCoreUpdate()
	{
	}

	protected void UnitCoreUpdate()
	{
	}

	protected virtual void UpdateTargetSelection()
	{
	}

	protected void UpdateTargetPositionInfo()
	{
	}

	protected virtual void UpdateUnitSkillDecision()
	{
	}

	public bool SwitchLogicState(CLState newState)
	{
		return false;
	}

	public virtual void onEvent(string evtName, GameObject go)
	{
	}

	private void CallFlash(string evtName)
	{
	}

	public void CallFreePlay()
	{
	}

	private void CallAutodestruct(GameObject sObj)
	{
	}

	protected virtual void CallDeadEnd()
	{
	}

	protected virtual void CallCast()
	{
	}

	protected virtual void CallSpawn()
	{
	}

	protected virtual void CallSpawnEnd()
	{
	}

	protected virtual void CallSpawnImmuEnd(float extraTime)
	{
	}

	public virtual void CallDashMovingStart(string dashStr = null)
	{
	}

	public virtual void CallAndExecDashEnd()
	{
	}

	private void CallRelife()
	{
	}

	public void ExecDeadOnGround()
	{
	}

	public void ResetCapsuleCollider()
	{
	}

	public void ExecMoveEnd()
	{
	}

	public void ExecKillMe()
	{
	}

	public virtual bool ExecDeath()
	{
		return false;
	}

	private void ExecRelifeWait()
	{
	}

	public void ExecRelife()
	{
	}

	public virtual void SafeCallAndExecFallOnGround()
	{
	}

	public void ChargeLoopAnimation(int animation, int nextAnim, float duration)
	{
	}

	public void UpdateChargeAction()
	{
	}

	protected void ExecSpawn()
	{
	}

	private static void playAudio(GUtilListenerEvent sEvent)
	{
	}

	public virtual void ExecAdjustPosAndDir()
	{
	}

	protected void ExecRun2Target()
	{
	}

	public virtual void ExecFightOver()
	{
	}

	public virtual void ExecKnockIntoAir(Vector3 flySpeed)
	{
	}

	public virtual void ExecKnockIntoAir(Vector3 flySpeed, float time)
	{
	}

	private float mathGSpeedByT(float sFeetPost, float sT)
	{
		return 0f;
	}

	public virtual void ExecStandByAndGuard()
	{
	}

	protected virtual void ExecStandStill()
	{
	}

	public virtual void ExecDashAttack()
	{
	}

	protected virtual void ExecRushForward(float dTime = -1f, float dDist = -1f)
	{
	}

	protected void ExecAttackedWhenStand()
	{
	}

	public virtual void ExecStuned()
	{
	}

	public virtual void SafeExecStunEnd()
	{
	}

	public virtual void ExecTempt()
	{
	}

	public virtual void SafeTemptEnd()
	{
	}

	public virtual void ExecStopTime()
	{
	}

	public virtual void ExecStopTimeEnd()
	{
	}

	public virtual void ExecModifyPost()
	{
	}

	public void ExecJustAnimState(string sStateAnim)
	{
	}

	public void ExecJustAnimStateEnd(string sStateAnim)
	{
	}

	public void ExecJustAnimState()
	{
	}

	private void SelfExecJustAnim(string sStateAnim)
	{
	}

	public virtual void ExecModifyPostEnd()
	{
	}

	public virtual void ExecBeCatchBegin(Transform sCatchPoint)
	{
	}

	public virtual void ExecBeCatchEnd()
	{
	}

	public virtual void ExecColliderRemove()
	{
	}

	public virtual void ExecColliderRemoveEnd()
	{
	}

	public virtual void SafeCallImprisoned()
	{
	}

	public virtual void ExecDashEnd()
	{
	}

	public virtual void CallActionEnd()
	{
	}

	public virtual void CallAttackedCV()
	{
	}

	private void AddPauseKey()
	{
	}

	private void RemovePauseKey()
	{
	}

	public virtual void Pause()
	{
	}

	public virtual void Resume()
	{
	}

	protected void InitEvents()
	{
	}

	protected virtual void ExecBreakSkill()
	{
	}

	public virtual void SafeExecBreakSkill()
	{
	}

	public virtual void Remove()
	{
	}

	public void SetCanNotDieFlag(bool sCanNotDie)
	{
	}

	public virtual void ExecHatredChange(Entity sEntity, int sHatred = 50)
	{
	}

	public void ExecFlashLoop()
	{
	}

	public void ExecFlashLoopEnd()
	{
	}

	public void ExecFlashWhite()
	{
	}

	protected void ExecAbleFollower(bool sFollowerAble, float sDistance)
	{
	}

	protected void ExecAbleSelect(bool isCanSelect)
	{
	}

	public void ExecSelect(bool isCanSelect)
	{
	}

	private void OnDestroy()
	{
	}
}
