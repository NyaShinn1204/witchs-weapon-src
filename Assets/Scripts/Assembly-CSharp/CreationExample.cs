using System.Collections;
using System.Diagnostics;
using PathologicalGames;
using UnityEngine;

public class CreationExample : MonoBehaviour
{
	public Transform testPrefab;

	public string poolName;

	public int spawnAmount;

	public float spawnInterval;

	private SpawnPool pool;

	private void Start()
	{
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
