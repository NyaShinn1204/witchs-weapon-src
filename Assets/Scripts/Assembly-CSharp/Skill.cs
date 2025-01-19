using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.Battle.Unit;

public class Skill : EffectMaster, IPausedComponent
{
	public const string EVENT_INTERUTPT_NAME = "skill_interrupt";

	public const int DISTANCE_CHECK_NULL = 1;

	public const int DISTANCE_CHECK_POINT_TO_FACE = 2;

	public const int DISTANCE_CHECK_POINT_TO_POINT = 3;

	public const int DISTANCE_CHECK_FACE_TO_FACE = 4;

	public const string FUNC_ON_START = "OnStartPoint";

	public const string FUNC_ON_RELEASE = "OnReleasePoint";

	public const string FUNC_ON_EFFECT = "OnEffectPoint";

	public const string FUNC_ON_PERFORMANCE = "OnPerformancePoint";

	public const string FUNC_ON_PERFORMANCE2 = "OnPerformancePoint2";

	public const string FUNC_ON_INTERUPUT = "OnInterruptPoint";

	public const string FUNC_ON_END = "OnEndPoint";

	private string skill_eff;

	public const int STAGE_MOVE = 0;

	public const int STAGE_CHARGE = 1;

	public const int STAGE_CHANNEL = 2;

	public const float CHANNEL_END_TIME = 0.5f;

	public const int CHANNEL_END_TIME_FRAME = 15;

	private bool isChannelEndInvoked;

	public CLState state;

	public long UUID;

	public int stage;

	public SkillProperty property;

	public Entity entity;

	public SkillTPL skillTemplate;

	private bool isPaused;

	public bool hasAnimation;

	private SkillTurnLightAnimGroup animGroup;

	private int targetChargeTimeFrame;

	public int targetChannelTimeFrame;

	public int curChannelTimeFrame;

	public int curChargeTimeFrame;

	public int skipFrameCount;

	public Target releaseTarget;

	public Target effectTarget;

	public Target eventTarget;

	public Entity currentEffectTarget;

	public Vector3 currentEffectTargetPoint;

	public PauseType _PauseType;

	public InvokeTimeLine timeLine;

	public bool isStarted;

	public string skillName;

	public SkillSystemProperty systemProperty;

	public int triggeredBuffLayer;

	private bool isRedAlert;

	public NameSpace fileds;

	private bool shouldInterupt;

	public ISkillEndCallBack callback;

	public bool _isDestroy;

	private List<BaseRenderer> warningList;

	public EventValueParam valueParam;

	private EffectBase skillLoadingEff;

	private int targetLoadingTimeFrame;

	private int beginLoadingTimeFrame;

	public BuffSourcePropDTO buffSourceVO;

	public string weaponEffectPoolName;

	public bool isTimeCDStart;

	public float attackCD;

	public SkillTurnLightAnimGroup AnimGroup
	{
		get
		{
			return null;
		}
	}

	public void Start()
	{
	}

	public void Initialize(Entity unit, SkillProperty property, SkillTPL tpl, Entity eventEntity = null, EventValueParam valueParam = null, ISkillEndCallBack callback = null, BuffSourcePropDTO buffSourceVO = null)
	{
	}

	private void AppendEventTarget(Skill skill, Entity targetEntity)
	{
	}

	public void Update()
	{
	}

	private void CheckLoadingTimeEnd()
	{
	}

	private void SetAngle(float value)
	{
	}

	private void CheckEffectPoint()
	{
	}

	private void CheckInterupt(int interuptTargets, int interuptSelf)
	{
	}

	private void CheckSelfInterupt(int interuptSelf)
	{
	}

	private void CheckOtherInterupt(int interuptTargets)
	{
	}

	public void TriggerInterupt()
	{
	}

	private void CheckChargeEnd()
	{
	}

	private void CheckChannelEnd()
	{
	}

	public void OnDecisionPoint()
	{
	}

	private Target DoSelectReleaseTarget(Entity entity, ReleaseTargetParam pm, Target eventtarget)
	{
		return null;
	}

	private bool CheckReadyToStartPoint()
	{
		return false;
	}

	private void StatInfo()
	{
	}

	public void OnStartPoint()
	{
	}

	private void FaceToTarget(bool flag, bool fast = false)
	{
	}

	private void ResetFaceTo()
	{
	}

	public void OnReleasePoint()
	{
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	public void OnPerformancePoint(string groupName = null)
	{
	}

	public void OnPerformancePoint2(string groupName = null)
	{
	}

	public void OnEffectPoint(string groupName = null)
	{
	}

	public void OnInteruptPoint(string action = "")
	{
	}

	private void LightOffAnim()
	{
	}

	public static void NotifyBehaviorTree(string evtName, Entity entity)
	{
	}

	private void ShutdownWarning()
	{
	}

	public void OnEndPoint()
	{
	}

	public void DestroyControl()
	{
	}

	private void SendSkillEvent(long skillId, int type, Entity entity)
	{
	}

	public override string ToString()
	{
		return null;
	}

	public static void RemoveSkills(Entity en)
	{
	}
}
