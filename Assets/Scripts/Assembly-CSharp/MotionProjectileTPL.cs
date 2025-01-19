using System.Xml;

public class MotionProjectileTPL : MotionTPL
{
	public const int DIRECTION_TYPE_TO_TARGET = 1;

	public const int DIRECTION_TYPE_TO_MOTION = 2;

	public float acc;

	public float accReduceRate;

	public MetaValue speedH;

	public MetaValue speedV;

	public int direciton;

	public MotionProjectileTPL(XmlElement node, string name)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
