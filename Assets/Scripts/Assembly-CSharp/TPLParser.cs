using System.Xml;

public static class TPLParser
{
	public static XmlDocument doc;

	public static XmlReaderSettings set;

	public static BulletTPL ParseBulletTPL(XmlElement node)
	{
		return null;
	}

	public static MotionTPL ParseMotionTPL(XmlNode node, MotionTPL parent = null)
	{
		return null;
	}

	public static MotionTPL ParseSingleMotionTPL(XmlElement ele)
	{
		return null;
	}

	public static HitListenerTPL CreateHitListenerTPL(XmlElement ele)
	{
		return null;
	}

	public static CompleteListenerTPL CreateCompleteListenerTPL(XmlElement ele)
	{
		return null;
	}

	public static XmlElement GetBulletNode(string emitID, int bulletIndex = 0, string path = "Config/xmlConf/motion_test.xml")
	{
		return null;
	}
}
