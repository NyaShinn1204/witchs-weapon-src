using System.Collections.Generic;
using UnityEngine;

public class SelectorUtil
{
	public const int TYPE_RANGE_SINGLE = 1;

	public const int TYPE_RANGE_ALL = 2;

	public const int TYPE_RANGE_CIRCLE = 3;

	public const int TYPE_RANGE_SECTOR = 4;

	public const int TYPE_RANGE_RECT = 5;

	public const int TYPE_RANGE_RING = 6;

	public const int TYPE_RANGE_EXCEPT = 7;

	public const int TYPE_RANGE_SELF = 99;

	public const int TYPE_TARGET_CURRENT = 1;

	public const int TYPE_TARGET_SELF = 2;

	public const int TYPE_TARGET_MASTER = 3;

	public const int TYPE_TARGET_MASTER_TARGET = 4;

	public const int TYPE_TARGET_EVENT_TARGET = 5;

	public const int TYPE_TARGET_SUMMON = 6;

	public const int TYPE_TARGET_HERO = 7;

	public const int TYPE_TARGET_FOLLOW = 8;

	public const int TYPE_TARGET_EVENT_TARGET_MASTER = 9;

	public const int TYPE_TARGET_RANGE_NEAREST_SELF_TARGET = 10;

	public const int TYPE_TARGET_RANGE_NEAREST_TARGET_TARGET = 11;

	public const int TYPE_TARGET_RANGE_RANDOM_SELF_TARGET = 12;

	public const int TYPE_TARGET_RANGE_RANDOM_CURRENT_TARGET = 13;

	public const int TYPE_TARGET_RANGE_SELF_HEALTH_LEAST = 14;

	public const int TYPE_TARGET_RANGE_SELF_NOBUFF = 15;

	public const int TYPE_TARGET_POINT_CURRENT = 100;

	public const int TYPE_TARGET_POINT_SELF = 101;

	public const int TYPE_TARGET_POINT_RANGE_RANDOM_SELF = 102;

	public const int TYPE_TARGET_POINT_RANGE_RANDOM_CURRENT = 103;

	public const int TYPE_TARGET_POINT_SELF_DIRECTION = 104;

	public const int TYPE_TARGET_POINT_SELF_BTWEEN_SERVANT = 105;

	public const int TYPE_RANGE_SECOND_FILTER_ALL = 1;

	public const int TYPE_RANGE_SECOND_FILTER_RANDOM = 2;

	public const int TYPE_RANGE_SECOND_FILTER_TARGET = 3;

	public const int TYPE_TARGET_SELECT_RELEASE_TARGET_YES = 1;

	public const int TYPE_TARGET_SELECT_RELEASE_TARGET_NO = 2;

	private static bool CanNotBeSelected(Entity entity)
	{
		return false;
	}

	public static Target DoSelectReleaseTarget(Entity self, ReleaseTargetParam param, Target eventTarget = null, List<Entity> exception = null)
	{
		return null;
	}

	private static Vector3 CreateRandomPointInCircle(Vector3 center, float range)
	{
		return default(Vector3);
	}

	private static Vector3 CreateDistensPointInCircle(Vector3 center, float range)
	{
		return default(Vector3);
	}

	public static Target DoSelectRangeEntity(Skill skill, int type, int arg1, int arg2, int arg3, int arg4)
	{
		return null;
	}

	public static Entity GetExceptOne(List<Entity> list)
	{
		return null;
	}

	private static List<Entity> SelectInCircle(float radius, Target releaseTarget, List<Entity> allList)
	{
		return null;
	}

	public static Target DoSelectRangeTargetsSecondery(Entity self, Target releaseTarget, Target effectTarget, int type, int arg1, int arg2, int arg3, int arg4, int arg5)
	{
		return null;
	}

	private static Entity SelectNearestTarget(float range, int camp, Vector3 center, Entity en)
	{
		return null;
	}

	private static Entity SelectLeastHealthTarget(int type, int opp, float range, int camp, Vector3 center, List<Entity> exception = null)
	{
		return null;
	}

	private static List<Entity> SelectRangeAndCampRandomTargets(float range, int camp, Vector3 center, int count, bool isCanRepeat, List<Entity> exception = null)
	{
		return null;
	}

	private static List<Entity> SelectRandomTargets(List<Entity> list, int count, bool isCanRepeat, int singleLimit = 0, Target releaseTarget = null)
	{
		return null;
	}

	private static void GetSingleTargets(List<Entity> list, int limit, List<Entity> targetList, int allCount)
	{
	}

	public static Target ConvertReleaseTargets(Target releaseTarget, int targetType)
	{
		return null;
	}
}
