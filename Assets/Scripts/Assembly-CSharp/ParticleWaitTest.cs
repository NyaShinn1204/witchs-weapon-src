using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class ParticleWaitTest : MonoBehaviour
{
	public float spawnInterval;

	public string particlesPoolName;

	public ParticleSystem particleSystemPrefab;

	[DebuggerHidden]
	private IEnumerator Start()
	{
		return null;
	}
}
