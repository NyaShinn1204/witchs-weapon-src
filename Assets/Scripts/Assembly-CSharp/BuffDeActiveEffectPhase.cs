using System.Collections.Generic;
using System.Xml;

public class BuffDeActiveEffectPhase : BuffPhase
{
	private const int TARGET_TYPE_SOURCE = 1;

	private const int TARGET_TYPE_TARGET = 2;

	private const int TARGET_TYPE_EVENT_TARGET = 3;

	private int targetType;

	private string effectName;

	private int activeType;

	public BuffDeActiveEffectPhase(NameSpace field)
	{
	}

	public override void OnInit(XmlElement node)
	{
	}

	public override void invoke(NameSpace field)
	{
	}

	private BuffEntity GetBuff()
	{
		return null;
	}

	public void SetActive(List<Entity> list)
	{
	}
}
