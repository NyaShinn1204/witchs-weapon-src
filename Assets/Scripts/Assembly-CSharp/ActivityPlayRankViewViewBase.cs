using UnityEngine;

public class ActivityPlayRankViewViewBase : ActivityPlaySystemManagerViewBase
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
