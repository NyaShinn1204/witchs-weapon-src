using System.Xml;

public class MotionLineTPL : MotionTPL
{
	public const int DIR_TARGET = 1;

	public const int DIR_GROUND = 2;

	public const int DIR_SKY = 3;

	public const int DIR_DIRECTION = 4;

	public const int DIR_FRONT = 5;

	public const int DIR_TARGET_DIR = 6;

	public float speed;

	public int dir;

	public int lifeTime;

	public float acc;

	public float accMin;

	public float accMax;

	public float accReduceRate;

	public MotionLineTPL(XmlElement node, string name)
	{
	}

	private float GetSysProp(XmlElement node, string name)
	{
		return 0f;
	}

	public override string ToString()
	{
		return null;
	}
}
