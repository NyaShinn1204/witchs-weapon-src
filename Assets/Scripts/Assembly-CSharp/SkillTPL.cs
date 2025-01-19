using System.Collections.Generic;

public class SkillTPL
{
	public long ID;

	public SkillProperty property;

	public Dictionary<Entity, float> CDCollection;

	public SkillEffectTPL effectTPL;

	public SkillTPL(SkillProperty property)
	{
	}

	public void SetCDTime(Entity entity, float time)
	{
	}

	public Skill CreateSkillInstance(Entity unit, Entity eventEntity = null, EventValueParam valueParam = null, ISkillEndCallBack callback = null, BuffSourcePropDTO buffSourceVO = null)
	{
		return null;
	}

	private bool CheckSkillReleaseValid(Entity entity)
	{
		return false;
	}

	public bool CheckStateValid(Entity entity)
	{
		return false;
	}

	public bool CheckCDValid(Entity entity)
	{
		return false;
	}
}
