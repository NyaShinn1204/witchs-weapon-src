using System.Xml;
using UnityEngine;

public class CreateShiftPackPhase : SkillPhase
{
	private const int DIRECTION_TYPE_TARGET = 1;

	private const int DIRECTION_TYPE_LINE_SOURCE_TO_TARGET = 2;

	private const int DIRECTION_TYPE_LINE_RELEASE_TARGET_TO_TARGET = 3;

	private const int DIRECTION_TYPE_LINE_RELEASE_TARGET = 4;

	private const int DIRECTION_TYPE_LINE_RELEASE = 5;

	private float speed;

	private float time;

	private int faceTo;

	private float angle;

	private int stackType;

	private bool removeCollder;

	public CreateShiftPackPhase(NameSpace field)
	{
	}

	public override void OnInit(XmlElement node)
	{
	}

	public override void invoke(NameSpace field)
	{
	}

	private Vector3 GetDirectionByType(int type, Entity target)
	{
		return default(Vector3);
	}

	public override string ToString()
	{
		return null;
	}
}
