using System.Collections.Generic;

public class SkillEffectTimeLine
{
	protected int repeatCount;

	protected int curTimeFrame;

	protected List<int> delayListFrame;

	protected List<SkillFuncPhase> phaseList;

	protected Skill skill;

	protected int skipTimeFrame;

	protected int skipTimeFrameSecondary;

	protected bool removeSeg;

	public void SetSkill(Skill skill)
	{
	}

	public virtual void Start(Dictionary<string, SkillFuncPhase> dic, string pointType)
	{
	}

	public virtual void FillToDic(int repeatCount, SkillFuncPhase phase)
	{
	}

	public virtual void Update()
	{
	}

	public bool isEnd()
	{
		return false;
	}

	public virtual int RemoveTimeSegment(int targetPointIndex, int currentPointIndex)
	{
		return 0;
	}

	public virtual void RemoveTimeSegmentSecondary(int timeFrame)
	{
	}
}
