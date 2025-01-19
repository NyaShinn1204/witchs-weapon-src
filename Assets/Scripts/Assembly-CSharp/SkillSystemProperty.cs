using System.Collections.Generic;

public class SkillSystemProperty : ISYSProperty
{
	private Skill skill;

	public int effectPointIndex;

	public int effectPointLoopIndex;

	public int performancePointIndex;

	public int performancePointLoopIndex;

	public float selfTargetDistance;

	public float releaseTargetDistance;

	public float eventTargetDistance;

	public Dictionary<int, int[]> dic;

	public int hitCount;

	public int dodgeCount;

	public int critCount;

	public int lastHitCount;

	public int lastDodgeCount;

	public int lastCritCount;

	public int currentHitCount;

	public int currentDodgeCount;

	public int currentPhysicCritCount;

	public int currentMagicCritCount;

	public SkillSystemProperty(Skill skill)
	{
	}

	public void AddStatistics(int index, bool isHit, bool isMiss, bool isCrit)
	{
	}

	public object GetVariableValue(string val)
	{
		return null;
	}

	public void Calulate()
	{
	}

	public void CopyNewToOld()
	{
	}

	public static void CalulatePackEffect(BasePack pack, SkillSystemProperty prop)
	{
	}

	public override string ToString()
	{
		return null;
	}

	public void InvokeGetCurrentDistance()
	{
	}

	public void InvokeGetEventTargetDistance()
	{
	}
}
