public class MotionProjectile : MotionGroupParallel
{
	private MotionLine h_motion;

	private MotionLine v_motion;

	private bool init;

	private MetaValue speedH;

	private MetaValue speedV;

	public MotionProjectile(MetaValue speedH, MetaValue speedV, float acc, float accReduceRate)
	{
	}

	public override int Move()
	{
		return 0;
	}

	private float GetMetaValue(MetaValue value)
	{
		return 0f;
	}

	public float GetMetaFuncValue(string content)
	{
		return 0f;
	}

	private float GetMetaVarValue(string valueString)
	{
		return 0f;
	}
}
