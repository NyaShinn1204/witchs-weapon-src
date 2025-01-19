using System.Xml;

public class MotionBezierTPL : MotionTPL
{
	public const int TYPE_DIRECTION_SOURCE = 1;

	public const int TYPE_DIRECTION_TARGET = 2;

	public const int TYPE_SOURCE_POSITION = 1;

	public const int TYPE_TARGET_POSITION = 2;

	public int startPositionType;

	public int endPositionType;

	public float controllPointRate;

	public int speed;

	public int direction;

	public MotionBezierTPL(XmlElement node, string name)
	{
	}

	private int GetPositionType(string value)
	{
		return 0;
	}

	private int GetDirectionType(string value)
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}
}
