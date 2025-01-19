using Pathfinding;
using UnityEngine;

public class LocalSpaceRichAI : RichAI
{
	public LocalSpaceGraph graph;

	public override void UpdatePath()
	{
	}

	protected override Vector3 UpdateTarget(RichFunnel fn)
	{
		return default(Vector3);
	}
}
