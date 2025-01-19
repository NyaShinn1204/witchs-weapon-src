using UnityEngine;

public class PackageItemViewViewBase : PackageItemViewBase
{
	[HideInInspector]
	public bool _BindNum;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void NumChanged(long value)
	{
	}

	public override void Bind()
	{
	}
}
