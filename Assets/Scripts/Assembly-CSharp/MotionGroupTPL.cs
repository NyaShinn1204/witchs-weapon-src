using System.Xml;

public class MotionGroupTPL : MotionTPL
{
	public const int TYPE_PARALLEL = 1;

	public const int TYPE_SEQUENCE = 2;

	public int type;

	public int loops;

	private XmlElement node;

	private bool isAddedChild;

	public MotionGroupTPL(XmlElement node, string name)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
