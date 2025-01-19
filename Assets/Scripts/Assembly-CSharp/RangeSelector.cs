using System.Collections.Generic;
using UnityEngine;

public class RangeSelector
{
	public static List<Entity> SelectInCircle(List<Entity> list, Vector3 origin, float radius)
	{
		return null;
	}

	public static List<Entity> SelectInCircle(List<Entity> list, Vector3 origin, float radius, Entity except)
	{
		return null;
	}

	public static bool IsInCircle(Vector3 target, Vector3 center, float radius)
	{
		return false;
	}

	public static bool IsTwoCircleCross(Vector3 center1, float radius1, Vector3 center2, float radius2)
	{
		return false;
	}

	public static bool isOneCircleInOtherCirlce(Vector3 center1, float radius1, Vector3 center2, float radius2)
	{
		return false;
	}

	public static List<Entity> SelectInRing(List<Entity> list, Vector3 origin, float innerRadius, float outerRadius)
	{
		return null;
	}

	public static List<Entity> SelectInRect(List<Entity> list, Vector3 origin, Vector3 focus, float width, float height)
	{
		return null;
	}

	public static List<Entity> SelecteInSector(List<Entity> list, Vector3 originPosition, Vector3 focus, float angle, float radius)
	{
		return null;
	}

	public static List<Entity> CombinSelection(List<Entity> list, List<Entity> list2)
	{
		return null;
	}

	public static Entity SelectMinDistanceEntity(List<Entity> list, Vector3 center)
	{
		return null;
	}

	public static Entity SelectLeastHealthEntity(List<Entity> list, int type, int opp)
	{
		return null;
	}

	public static Entity SelectMinDistanceEntityBetweenTwo(Entity entity1, Entity entity2, Vector3 center)
	{
		return null;
	}

	public static Entity SelectLeastHealthEntityBetweenTwo(Entity entity1, Entity entity2, int type, int opp)
	{
		return null;
	}
}
