using System.Collections.Generic;
using UnityEngine;

public class AgentEntity : Entity, IMasteredEntity, ISkillEndCallBack, IBulletLogicDelegate
{
	private int _hitCOunt;

	public static Dictionary<long, List<AgentEntity>> dic;

	public AgentVO agentVO;

	public int level;

	public Skill sourceSkill;

	public float lifeTime;

	private IMotion _motion;

	public Vector3 motionDirection;

	public Skill skill;

	public bool shouldDestroy;

	public bool isSkillCasting;

	private PropertiesVO property;

	private Emit emit;

	private Bullet hitBullet;

	private bool isStay3;

	private Dictionary<string, string> hitGroupIds;

	private bool _isHideView;

	public override Vector3 feetPosition
	{
		get
		{
			return default(Vector3);
		}
	}

	public override Vector3 centerPosition
	{
		get
		{
			return default(Vector3);
		}
	}

	protected override string deathAnim
	{
		get
		{
			return null;
		}
	}

	public override bool isSpawn
	{
		get
		{
			return false;
		}
	}

	public override int entityPowerRank
	{
		get
		{
			return 0;
		}
	}

	public override bool isNative
	{
		get
		{
			return false;
		}
	}

	public override void Start()
	{
	}

	public void SetProperty(PropertiesVO property)
	{
	}

	public override void Update()
	{
	}

	private void CheckDeath()
	{
	}

	public void OnHit(Bullet bullet)
	{
	}

	private void AppendHitGroup(string groupid)
	{
	}

	private bool IsSameGroupBulletHit(Bullet bullet)
	{
		return false;
	}

	public void OnComplete()
	{
	}

	private void CreateMotion()
	{
	}

	public override void AddSpawnBuffs()
	{
	}

	private bool IsHerosAgent(Entity m)
	{
		return false;
	}

	private void Spwan()
	{
	}

	protected override void CallSpawnEnd()
	{
	}

	private void SpwanEnd()
	{
	}

	public override long GetID()
	{
		return 0L;
	}

	public void CallBack(Entity entity)
	{
	}

	public void RequestTarget(Entity entity)
	{
	}

	public void OnHitTarget()
	{
	}

	public void OnHitBlock()
	{
	}

	private bool IsHitComplete()
	{
		return false;
	}

	protected override void HideView()
	{
	}

	public override int GetLevel()
	{
		return 0;
	}

	public override PropertiesVO GetProperty()
	{
		return null;
	}

	private bool IsServant()
	{
		return false;
	}

	private Vector3 GetUnBlockedPosition(Vector3 pos)
	{
		return default(Vector3);
	}

	public Vector3 PositionAt(int[] setpos)
	{
		return default(Vector3);
	}

	private Vector3 restrictPoint(Vector3 targetPoint)
	{
		return default(Vector3);
	}

	public void RotateTo(Vector3 position, int[] faceto)
	{
	}

	public Vector3 FindEmptyPlace(Transform origin, float range, Vector3 initDirection, float favAngle = 0f)
	{
		return default(Vector3);
	}

	private bool ScanIsEmpty(Vector3 centerPos, Vector3 direction, float radius)
	{
		return false;
	}

	private Vector3 GetDirection(Skill skill, int type)
	{
		return default(Vector3);
	}

	private Vector3 GetPosByType(int type, Skill skill)
	{
		return default(Vector3);
	}

	private Entity GetEntityByType(int type, Skill skill)
	{
		return null;
	}

	public override string GetRotateBone()
	{
		return null;
	}

	private Vector3 GetFeetPosByType(int type, Skill skill)
	{
		return default(Vector3);
	}

	public override void SafeExecBreakSkill()
	{
	}

	protected override void ExecBreakSkill()
	{
	}

	public override bool ExecDeath()
	{
		return false;
	}
}
