using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class ReallySimpleParticleSpawner : MonoBehaviour
{
	public string poolName;

	public ParticleSystem prefab;

	public float spawnInterval;

	private void Start()
	{
	}

	[DebuggerHidden]
	private IEnumerator ParticleSpawner()
	{
		return null;
	}
}
