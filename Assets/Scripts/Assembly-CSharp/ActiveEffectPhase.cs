using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class ActiveEffectPhase : SkillPhase
{
	private int targetType;

	private string effectName;

	private int activeType;

	private string subEffectName;

	private int maxNum;

	private int startNum;

	private long prefab;

	public static int ACTIVE_TYPE_LOOP;

	public static int ACTIVE_TYPE_DIRECT;

	public ActiveEffectPhase(NameSpace field)
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
}
