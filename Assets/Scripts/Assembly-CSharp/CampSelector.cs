using System.Collections.Generic;

public class CampSelector
{
	public const int CAMP_HERO = 1;

	public const int CAMP_MONSTER = 2;

	public const int CAMP_ALL = 3;

	public const int CAMP_FRIENDLY = 0;

	public const int CAMP_ENEMY = 1;

	public const int RELATIONSHIP_JUDGEMENT_ALL = 1;

	public const int RELATIONSHIP_JUDGEMENT_ENEMY = 2;

	public const int RELATIONSHIP_JUDGEMENT_FRIENDLY = 3;

	public static List<Entity> SelectCampEntities(int campType)
	{
		return null;
	}

	public static List<Entity> SelectCampEntities(List<Entity> list, int campType, Entity entity)
	{
		return null;
	}

	public static int GetCampTypeByRelation(Entity entity, int relationShip)
	{
		return 0;
	}

	public static List<Entity> GetFriendlyEntities(Entity entity, List<Entity> list = null)
	{
		return null;
	}

	public static List<Entity> GetAgainstEntities(Entity entity, List<Entity> list = null)
	{
		return null;
	}

	private static bool IsCanSelected(Entity en)
	{
		return false;
	}

	public static bool isFriendly(Entity self, Entity other)
	{
		return false;
	}
}
