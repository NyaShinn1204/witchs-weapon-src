using unit;

public class EnemyHp : ProjectionEffect, IPausedComponent
{
	public PauseType _pauseType;

	public UILabel nameLabel;

	public HalfColorUISprite bar;

	public HalfColorUISprite bar_bg;

	public MonsterEntity father;

	public const float display_time = 2.5f;

	public float lastHp;

	private float _alpha;

	private const float alphaMax = 8f;

	private const float alphaMin = 0f;

	private const float alphaMinusSpd = 2f;

	private const float alphaMinusSpdDeath = 4f;

	private const float heightOffset = 0.7f;

	public float alpha
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static EnemyHp ApplyEnemyHpTo(MonsterEntity target)
	{
		return null;
	}

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	protected override void Update()
	{
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	private void OnDestroy()
	{
	}

	public void destory()
	{
	}
}
