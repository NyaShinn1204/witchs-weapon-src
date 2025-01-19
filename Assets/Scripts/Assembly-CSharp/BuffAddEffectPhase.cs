using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class BuffAddEffectPhase : BuffPhase
{
	private const int MODE_ENTITY = 1;

	private const int MODE_POINT = 2;

	public const int TARGET_TYPE_SOURCE = 1;

	public const int TARGET_TYPE_TARGET = 2;

	public const int TARGET_TYPE_EVENT_TARGET = 3;

	public const int TARGET_TYPE_SUMMON = 4;

	public const int TARGET_TYPE_COLLECTION = 99;

	private const int CENTER_TYPE_RELEASER = 1;

	private const int CENTER_TYPE_RELEASE_CENTER = 2;

	private const int CENTER_TYPE_EFFECT_CENTER = 3;

	private long _name;

	private string effectName;

	private int addMode;

	private int sourceType;

	private int targetType;

	private int centerType;

	private bool unLinkToCaller;

	private float radius;

	private int directionType;

	private int angle;

	public BuffAddEffectPhase(NameSpace field)
	{
	}

	public override void OnInit(XmlElement node)
	{
	}

	public override void invoke(NameSpace field)
	{
	}

	private void AddEffectPoints(Entity target)
	{
	}

	private void AddEffectToPointsList(List<Vector3> list)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
