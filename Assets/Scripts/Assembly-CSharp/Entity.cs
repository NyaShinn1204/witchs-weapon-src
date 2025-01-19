using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.Battle.Unit;

public class Entity : CharacterBase
{
	public enum MonsterEntityHPUIType
	{
		COMMON = 1,
		ELITE = 2,
		BOSS = 3,
		BOSS_S = 4
	}

	private class AITreeData
	{
		public Entity source;

		public AITreePool.AITreeType type;

		public Entity target;

		private Vector3 _position;

		private float _distance;

		private int _pointType;

		public float doneTime;

		public List<Vector3> positionPath;

		private int _positionPathIndex;

		public Vector3 position
		{
			get
			{
				return default(Vector3);
			}
		}

		public bool isDoneOver
		{
			get
			{
				return false;
			}
		}

		public AITreeData(Entity sSource, AITreePool.AITreeType sType, Vector3 sPosition)
		{
		}

		public AITreeData(Entity sSource, AITreePool.AITreeType sType, Entity sTarget, int sPointType, float sDistance)
		{
		}
	}

	public static bool forUnitTest;

	public const int FACTOR_DEATH_IMMUE = 1;

	public const int FACTOR_WEAPON_VALUE = 2;

	public const int FACTOR_114_BUFF = 3;

	public const int FACTOR_SAVE_WEAPON = 4;

	public const int FACTOR_ATTACT_TIME = 5;

	public int groupId;

	public EventDelegates.SkillDelegate skillDelegate;

	public EventDelegates.BuffDelegate buffDelegate;

	public EventDelegates.BattleStateDelegate battleStateDelegate;

	public EventDelegates.BattleAreaDelegate battleAreaDelegate;

	public EventDelegates.PowerDelegate powerDelegate;

	public EventDelegates.AnegyDelegate anegyDelegate;

	public EventDelegates.AttackDelegate attackDelegate;

	public EventDelegates.HitDelegate hitDelegate;

	public EventDelegates.DamageDelegate damageDelegate;

	public EventDelegates.Damage2Delegate damage2Delegate;

	public EventDelegates.HealthDelegate healthDelegate;

	public EventDelegates.WeaponSharpDelegate weaponSharpDelegate;

	public EventDelegates.WeaponSharChangepDelegate weaponSharChangepDelegate;

	public int[] factorArr;

	protected Entity _master;

	private AITreeData _AITreeData;

	private Dictionary<BuffEntity, float> shieldDic;

	public int camp
	{
		get
		{
			return 0;
		}
	}

	public virtual bool isNative
	{
		get
		{
			return false;
		}
	}

	public Entity Master
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual int entityPowerRank
	{
		get
		{
			return 0;
		}
	}

	public virtual MonsterEntityHPUIType entityTypeHPUI
	{
		get
		{
			return default(MonsterEntityHPUIType);
		}
	}

	public override void Awake()
	{
	}

	public override void Start()
	{
	}

	public virtual List<long> GetSummonBuffIdList()
	{
		return null;
	}

	public virtual List<int> GetSummonBuffLayerList()
	{
		return null;
	}

	protected override void CallSpawn()
	{
	}

	protected override void CallSpawnEnd()
	{
	}

	protected virtual void AddSpawnEvent()
	{
	}

	protected override void CallCast()
	{
	}

	public override void CallActionEnd()
	{
	}

	public virtual void InitTriggers()
	{
	}

	public virtual void InitDelegates()
	{
	}

	public override void Update()
	{
	}

	public bool ContainsBuff(long buffid)
	{
		return false;
	}

	public Entity GetBuffSoure(long buffid)
	{
		return null;
	}

	public virtual void LateUpdate()
	{
	}

	public void RemoveSkill(Skill skill)
	{
	}

	protected virtual void UpdateAITree()
	{
	}

	public virtual Skill ReleaseSkill(long skillID, CLState state = CLState.CastingSkill, Entity eventEntity = null, EventValueParam valueParam = null, ISkillEndCallBack callback = null, BuffSourcePropDTO buffSourceVO = null)
	{
		return null;
	}

	public int _GetReleaseSkillLevel(SkillProperty property)
	{
		return 0;
	}

	protected virtual void RunDelegate(BaseEvent evt)
	{
	}

	public virtual void RunOnHitCallback(DamageEvent evt)
	{
	}

	public virtual void SetHP(long value, bool showHit = true)
	{
	}

	public void PlayBeaten()
	{
	}

	public virtual PropertiesVO GetProperty()
	{
		return null;
	}

	public virtual void AddSpawnBuffs()
	{
	}

	public virtual long GetID()
	{
		return 0L;
	}

	public bool IsEquals(Entity other)
	{
		return false;
	}

	public StateVO GetState()
	{
		return null;
	}

	public float GetHPRate()
	{
		return 0f;
	}

	public virtual int GetLevel()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	public void AppendVector3(Vector3 vector)
	{
	}

	private Vector3 rayModfiny(Vector3 sBegin, Vector3 sVector, out bool isModfiny)
	{
		isModfiny = default(bool);
		return default(Vector3);
	}

	private Vector3 rayModfinyH(Vector3 sBegin, Vector3 sVector, Vector3 sVector2, out bool sIsModfiny)
	{
		sIsModfiny = default(bool);
		return default(Vector3);
	}

	public virtual string GetRotateBone()
	{
		return null;
	}

	public override bool ExecDeath()
	{
		return false;
	}

	public void ClearActiveSkill()
	{
	}

	public override void Pause()
	{
	}

	public override void Resume()
	{
	}

	protected override void ExecBreakSkill()
	{
	}

	public override void ExecDashAttack()
	{
	}

	public bool IsTeammate(Entity other)
	{
		return false;
	}

	public virtual void ExecSummonBlockChange()
	{
	}

	public override void Remove()
	{
	}

	protected override void BindActionMngr()
	{
	}

	protected virtual void HideView()
	{
	}

	public void execAITree(AITreePool.AITreeType sType, Entity sTarget, int sPointType = 4, float sDistance = 0.5f)
	{
	}

	public void execAITree(AITreePool.AITreeType sType, Vector3 sPosition)
	{
	}

	public void execAITreePath(List<Vector3> sPath)
	{
	}

	public void execAITree(AITreePool.AITreeType sType)
	{
	}

	public void execAITreeBreak(bool sIsSendOver = false)
	{
	}

	public bool isAITree(AITreePool.AITreeType sType)
	{
		return false;
	}

	public TriggerManager GetTriggerManager()
	{
		return null;
	}

	protected bool isRayDash()
	{
		return false;
	}

	public Dictionary<BuffEntity, float> GetShieldBuffDic()
	{
		return null;
	}

	public void PushOrModifyShieldBuff(BuffEntity buff, float val)
	{
	}

	public void PopShieldBuff(BuffEntity buff)
	{
	}

	public virtual int GetSkillReleaseLevel()
	{
		return 0;
	}

	public virtual Entity GetFollowTarget()
	{
		return null;
	}

	protected override void CallDeadEnd()
	{
	}

	private void CheckBloodThresholdBuffs(Entity entity)
	{
	}
}
