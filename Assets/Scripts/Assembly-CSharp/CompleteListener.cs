public class CompleteListener
{
	public const int LIFE_BY_NULL = 0;

	public const int LIFE_BY_MOTION_END = 1;

	public const int LIFE_BY_TIME = 2;

	public const int LIFE_BY_HIT_COUNT = 3;

	public int trigger;

	public int MaxCount;

	public int lifeTime;

	public Bullet bullet;

	public float destroyDelay;

	private float destroyDelayCurrent;

	private bool isComplete;

	private bool isDestroy;

	private float currentlife;

	private int currentCount;

	private float frameTime;

	public string triggerEvent;

	public void Update()
	{
	}

	public float GetRemaindLife()
	{
		return 0f;
	}

	public void SetAliveTime(int lifeRemaind)
	{
	}

	public void CheckComplete()
	{
	}

	private void CheckDestroy()
	{
	}

	public void Reset()
	{
	}

	private void Destroy()
	{
	}
}
