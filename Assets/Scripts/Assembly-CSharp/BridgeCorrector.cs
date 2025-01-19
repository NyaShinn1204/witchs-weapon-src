using UnityEngine;

public class BridgeCorrector : ICorrector
{
	protected ICorrectable correctableObj;

	public void SetCorrectable(ICorrectable obj)
	{
	}

	public virtual Vector3 Restrict(Vector3 vector)
	{
		return default(Vector3);
	}

	public override string ToString()
	{
		return null;
	}
}
