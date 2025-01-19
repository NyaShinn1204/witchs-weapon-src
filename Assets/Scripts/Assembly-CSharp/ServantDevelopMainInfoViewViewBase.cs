using UnityEngine;

public class ServantDevelopMainInfoViewViewBase : SingleServantViewBase
{
	[HideInInspector]
	public bool _BindServantMainInfoComputedProperty;

	[HideInInspector]
	public bool _BindServantPropertyComputedProperty;

	[HideInInspector]
	public bool _BindShowCanRankup;

	[HideInInspector]
	public bool _BindShowCanStarUp;

	[HideInInspector]
	public bool _BindChangeImage;

	[HideInInspector]
	public bool _BindFavQuestStatus;

	[HideInInspector]
	public bool _BindShowFavRedStar;

	[HideInInspector]
	public bool _BindShowNewImage;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void ServantMainInfoComputedPropertyChanged(ServantMainInfo value)
	{
	}

	public virtual void ServantPropertyComputedPropertyChanged(ServantPropertyInfo value)
	{
	}

	public virtual void ShowCanRankupChanged(bool value)
	{
	}

	public virtual void ShowCanStarUpChanged(bool value)
	{
	}

	public virtual void ChangeImageExecuted()
	{
	}

	public virtual void FavQuestStatusChanged(int value)
	{
	}

	public virtual void ShowFavRedStarChanged(bool value)
	{
	}

	public virtual void ShowNewImageChanged(bool value)
	{
	}

	public override void Bind()
	{
	}
}
