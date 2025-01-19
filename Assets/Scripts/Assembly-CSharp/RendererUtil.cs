using System.Collections.Generic;
using UnityEngine;

public static class RendererUtil
{
	public static string RESOURCE_RECT;

	public static string RESOURCE_CIRCLE;

	public static WarningAreaCircle CreateCircleRenderer(CharacterBase master, bool breakable, float radius, float duration, Vector3 position = default(Vector3))
	{
		return null;
	}

	public static WarningAreaCircle CreateSectorRenderer(CharacterBase master, bool breakable, float halfSideAngles, float radius, float duration, Vector3 position = default(Vector3))
	{
		return null;
	}

	public static WarningAreaSqr CreateRectRenderer(CharacterBase master, bool breakable, float width, float height, float duration)
	{
		return null;
	}

	private static BaseRenderer SetProperties(BaseRenderer ci, CharacterBase master, bool breakable, float duration, Vector3 position = default(Vector3))
	{
		return null;
	}

	public static List<BaseRenderer> DisplayWarningRenderer(Skill skill)
	{
		return null;
	}
}
