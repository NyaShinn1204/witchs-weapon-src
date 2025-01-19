using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class SimpleSpawner : MonoBehaviour
{
	public string poolName;

	public Transform testPrefab;

	public int spawnAmount;

	public float spawnInterval;

	public string particlesPoolName;

	public ParticleSystem particleSystemPrefab;

	private void Start()
	{
	}

	[DebuggerHidden]
	private IEnumerator ParticleSpawner()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator Spawner()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator Despawner()
	{
		return null;
	}
}
