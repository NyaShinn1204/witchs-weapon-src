using System.Xml;

public class CompleteListenerTPL : BaseTPL
{
	public const string TRIGGER_EVENT_SKILL = "SKILL";

	public float destroyDelay;

	public bool destroyBlur;

	public int life;

	public int maxCount;

	public int trigger;

	public string triggerEvent;

	public CompleteListenerTPL(XmlElement node)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
