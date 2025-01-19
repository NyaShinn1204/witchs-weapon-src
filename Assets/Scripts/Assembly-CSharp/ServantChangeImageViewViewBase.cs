using UnityEngine;

public class ServantChangeImageViewViewBase : SingleServantViewBase
{
	[HideInInspector]
	public bool _BindChangeImage;

	[HideInInspector]
	public bool _BindReceiveImageFav;

	[HideInInspector]
	public bool _BindFinishFavQuest;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void ChangeImageExecuted()
	{
	}

	public virtual void ReceiveImageFavExecuted()
	{
	}

	public virtual void FinishFavQuestExecuted()
	{
	}

	public override void Bind()
	{
	}
}
