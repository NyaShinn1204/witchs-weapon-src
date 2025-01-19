using UnityEngine;

public class DrawSystemHaveFreeDrawViewViewBase : DrawSystemManagerViewBase
{
	[HideInInspector]
	public bool _BindHaveFreeDraw;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void HaveFreeDrawChanged(bool value)
	{
	}

	public override void Bind()
	{
	}
}
