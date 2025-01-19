using UnityEngine;

public class MotionHeightCorrector : BridgeCorrector
{
	public float minHeight;

	public float maxHeight;

	public MotionHeightCorrector(float minHeight, float maxHeight)
	{
	}

	public override Vector3 Restrict(Vector3 vector)
	{
		return default(Vector3);
	}

	public override string ToString()
	{
		return null;
	}
}
