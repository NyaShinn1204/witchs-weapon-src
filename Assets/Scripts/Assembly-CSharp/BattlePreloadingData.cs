public class BattlePreloadingData : IPreLoadingData
{
	private float netMsgWeight;

	private float levelResWeight;

	private float atlasResWeight;

	private float playerSvResWeight;

	private float playerResWeight;

	private float mobResWeight;

	private float _netMsgRatio;

	private float _levelResRatio;

	private float _atlasResRatio;

	private float _playerSvResRatio;

	private float _playerResRatio;

	private float _mobResRatio;

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

	public float atlasResRatio
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float playerSvResRatio
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float playerResRatio
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float mobResRatio
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
