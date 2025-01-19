public class BuffReduceAbsorbShield : BuffEntity
{
	public const int TYPE_PHYSIC = 1;

	public const int TYPE_MAGIC = 2;

	public const int TYPE_CONFIRM = 3;

	public int type;

	public float rate;

	public float absorbValue;

	public float reduceValue;

	private bool isStarted;

	public int ansorbAttributeType1;

	public float ansorbAttributeRate1;

	private float ansorbAttributeTarget1;

	public int ansorbAttributeType2;

	public float ansorbAttributeRate2;

	private float ansorbAttributeTarget2;

	public override void OnStart()
	{
	}

	public override void ResetAndOverlay()
	{
	}

	public override void Update()
	{
	}

	public override void OnDestory()
	{
	}
}
