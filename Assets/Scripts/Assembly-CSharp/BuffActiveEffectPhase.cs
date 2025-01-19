using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class BuffActiveEffectPhase : BuffPhase
{
	private const int TARGET_TYPE_SOURCE = 1;

	private const int TARGET_TYPE_TARGET = 2;

	private const int TARGET_TYPE_EVENT_TARGET = 3;

	private int targetType;

	private string effectName;

	private string subEffectName;

	private int maxNum;

	private int startNum;

	public BuffActiveEffectPhase(NameSpace field)
	{
	}

	public override void OnInit(XmlElement node)
	{
	}

	public override void invoke(NameSpace field)
	{
	}

	public void SetActive(List<Entity> list, int count, int max)
	{
	}

	public Transform GetFirstNotActiveTransform(Transform trans, int count, int max)
	{
		return null;
	}

	private BuffEntity GetBuff()
	{
		return null;
	}
}
