using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class AddEffectPhase : SkillPhase
{
	private const int MODE_ENTITY = 1;

	private const int MODE_POINT = 2;

	private const int TARGET_TYPE_RELEASER = 1;

	private const int TARGET_TYPE_RELEASE_TARGET = 2;

	private const int TARGET_TYPE_EFFECT_TARGET = 3;

	private const int CENTER_TYPE_RELEASER = 1;

	private const int CENTER_TYPE_RELEASE_CENTER = 2;

	private const int CENTER_TYPE_EFFECT_CENTER = 3;

	private long _name;

	private string effectName;

	private int addMode;

	private int sourceType;

	private int targetType;

	private int centerType;

	private float radius;

	private int directionType;

	private int angle;

	private int effDirectionType;

	private int effAngle;

	private int unlinkToCaller;

	public AddEffectPhase(NameSpace field)
	{
	}

	public override void OnInit(XmlElement node)
	{
	}

	public override void invoke(NameSpace field)
	{
	}

	private EffectBase AddEffectAtTargetPosition(string url, Vector3 targetPosition)
	{
		return null;
	}

	private void AddEffectPoints(Target target, int effDirection, int effAngle)
	{
	}

	private bool IsEmptyPosition(Vector3 vector)
	{
		return false;
	}

	private void Rotate(int direction, int angle, Transform transform, Skill skill)
	{
	}

	private void AddEffectToList(List<Entity> list)
	{
	}

	private void AddEffectToPointsList(List<Vector3> list)
	{
	}

	private void AddEffectFromSourceToTarget(string url, Entity source, Entity target)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
