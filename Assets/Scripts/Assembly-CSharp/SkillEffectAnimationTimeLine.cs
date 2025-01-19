using System.Collections.Generic;

public class SkillEffectAnimationTimeLine
{
	protected int repeatCount;

	protected List<SkillFuncPhase> phaseList;

	protected Skill skill;

	public virtual void Start(Dictionary<string, SkillFuncPhase> dic, string pointType)
	{
	}

	public virtual void FillToDic(int repeatCount, SkillFuncPhase phase)
	{
	}

	public void SetSkill(Skill skill)
	{
	}

	public virtual string GetPhaseGroupName(int count)
	{
		return null;
	}
}
