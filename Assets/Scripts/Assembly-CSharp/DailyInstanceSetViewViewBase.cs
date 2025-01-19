using UnityEngine;

public class DailyInstanceSetViewViewBase : DailyInstanceSetViewBase
{
	[HideInInspector]
	public bool _BindEnterCounts;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void EnterCountsChanged(int value)
	{
	}

	public override void Bind()
	{
	}
}
