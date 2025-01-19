using unit;

public class MonsterActionMngr : ActionMngr
{
	public MonsterEntity mon;

	public static void BindMonster(MonsterActionMngr maMngr, MonsterEntity monUnit)
	{
	}

	public override float GetDashAutoSlowDownRange()
	{
		return 0f;
	}

	public override float GetDashAutoStopRange()
	{
		return 0f;
	}
}
