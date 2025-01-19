using System.Xml;

public class MotionRoundTPL : MotionTPL
{
	public new int angle;

	public int radius;

	public int speed;

	public int speedLimit;

	public float acc;

	public bool smoothly;

	public MotionRoundTPL(XmlElement node, string name)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
