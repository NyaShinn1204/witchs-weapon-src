using UnityEngine;

public class ExpeditionRankViewViewBase : ExpeditionManagerViewBase
{
	[HideInInspector]
	public bool _BindFinishGetRank;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void FinishGetRankExecuted()
	{
	}

	public override void Bind()
	{
	}
}
