using System.Xml;

public class MotionRestrictTraceTPL : MotionTraceTPL
{
	public int angleLimit;

	public MotionRestrictTraceTPL(XmlElement node, string name)
		: base(null, null)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
