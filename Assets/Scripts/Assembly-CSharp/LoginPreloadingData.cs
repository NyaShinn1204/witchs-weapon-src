public class LoginPreloadingData : IPreLoadingData
{
	private float netMsgWeight;

	private float levelResWeight;

	private float _netMsgRatio;

	private float _levelResRatio;

	public float netMsgRatio
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float levelResRatio
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float GetProgress()
	{
		return 0f;
	}
}
