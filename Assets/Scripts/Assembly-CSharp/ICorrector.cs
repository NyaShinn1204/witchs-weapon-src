using UnityEngine;

public interface ICorrector
{
	void SetCorrectable(ICorrectable obj);

	Vector3 Restrict(Vector3 vector);
}
