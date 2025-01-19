using System.Collections;
using System.Diagnostics;
using PathologicalGames;
using UnityEngine;

public class ReallySimpleAudioSpawner : MonoBehaviour
{
	public AudioSource prefab;

	public AudioSource musicPrefab;

	public float spawnInterval;

	private SpawnPool pool;

	private void Start()
	{
	}

	[DebuggerHidden]
	private IEnumerator MusicSpawner()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator Spawner()
	{
		return null;
	}
}
