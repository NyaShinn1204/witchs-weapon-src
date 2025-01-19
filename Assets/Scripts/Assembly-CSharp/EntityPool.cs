using System.Collections.Generic;
using UnityEngine;
using unit;

public class EntityPool
{
	public const int CAMP_0 = 0;

	public const int CAMP_1 = 1;

	public const int CAMP_2 = 2;

	public const int CAMP_RELATIONSHIP_FRIENDLY = 0;

	public const int CAMP_RELATIONSHIP_ENEMY = 1;

	public const int RELATIONSHIP_JUDGEMENT_ALL = 1;

	public const int RELATIONSHIP_JUDGEMENT_ENEMY = 2;

	public const int RELATIONSHIP_JUDGEMENT_FRIENDLY = 3;

	public const int TOTAL_CAMP_COUNT = 3;

	private static EntityPool _instance;

	public List<Entity> sourceList;

	public int[,] campTable;

	private readonly int maxLim;

	private EntityPool()
	{
	}

	public void CreateTable()
	{
	}

	public static bool IsEnemy(Entity entity)
	{
		return false;
	}

	public static EntityPool GetInstance()
	{
		return null;
	}

	public Entity AddEntity(Entity entity)
	{
		return null;
	}

	public void RemoveEntity(Entity entity)
	{
	}

	public void RemoveAllEntities()
	{
	}

	public void RemoveAllEntitiesByDestory()
	{
	}

	public List<Entity> GetAllEnemies()
	{
		return null;
	}

	public List<Entity> GetAllMonsterEntity()
	{
		return null;
	}

	public List<T> GetItemAll<T>() where T : Entity
	{
		return null;
	}

	public List<T> GetItemAll<T>(int sCamp) where T : Entity
	{
		return null;
	}

	public List<Entity> GetItemSummon(Entity sMaster)
	{
		return null;
	}

	public List<Entity> GetItemSummonByID(Entity sMaster, long id)
	{
		return null;
	}

	public Entity GetEntity(long id)
	{
		return null;
	}

	public Entity GetEntityByCamp(int camp)
	{
		return null;
	}

	public List<Entity> GetAllEntities(List<Entity> list = null)
	{
		return null;
	}

	public List<Entity> GetFriendlyEntities(Entity entity, List<Entity> list = null)
	{
		return null;
	}

	public List<Entity> GetAgainstEntities(Entity entity, List<Entity> list = null)
	{
		return null;
	}

	private bool IsCanSelected(Entity en)
	{
		return false;
	}

	public List<Entity> GetEnemyEntities(Entity entity)
	{
		return null;
	}

	public bool isFriendly(Entity self, Entity other)
	{
		return false;
	}

	public List<Entity> GetSelectedAll(int camp = 3)
	{
		return null;
	}

	public int GetMonsterCount(long id)
	{
		return 0;
	}

	public MonsterEntity GetMinLifeTimeMonster(long id, int camp)
	{
		return null;
	}

	private MonsterEntity GetMinLifeTimeMonster(MonsterEntity one, MonsterEntity other)
	{
		return null;
	}

	public bool isNoMonsterInFight()
	{
		return false;
	}

	public int GetMonsterNumInFight()
	{
		return 0;
	}

	public bool isAllow2AddNewMonster()
	{
		return false;
	}

	public void PauseAllEntityAllBuffs()
	{
	}

	public void StopAllEntityAIs()
	{
	}

	public void setLayer(GameObject sMaster, GameObject sView, int sLayer = 0)
	{
	}
}
