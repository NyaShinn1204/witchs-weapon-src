using UnityEngine;

public class MotionAngleCorrector : BridgeCorrector
{
	private IMotionEx baseMotion;

	private IMotionEx secondaryMotion;

	private float maxAngle;

	public MotionAngleCorrector(IMotionEx baseMotion, IMotionEx secondaryMotion, int maxAngle)
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
