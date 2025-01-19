using UnityEngine;

public class HireMercenaryViewViewBase : GuildMercenaryManagerViewBase
{
	[HideInInspector]
	public bool _BindFinishFreshCanHireList;

	[HideInInspector]
	public bool _BindFinishSelectBattleGroup;

	[HideInInspector]
	public bool _BindFinishHireMercenary;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void FinishFreshCanHireListExecuted()
	{
	}

	public virtual void FinishSelectBattleGroupExecuted()
	{
	}

	public virtual void FinishHireMercenaryExecuted()
	{
	}

	public override void Bind()
	{
	}
}
