using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Pathfinding;
using UnityEngine;

public class ProceduralWorld : MonoBehaviour
{
	[Serializable]
	public class ProceduralPrefab
	{
		public GameObject prefab;

		public float density;

		public float perlin;

		public float perlinPower;

		public Vector2 perlinOffset;

		public float perlinScale;

		public float random;

		public bool singleFixed;
	}

	private class ProceduralTile
	{
		private int x;

		private int z;

		private System.Random rnd;

		private ProceduralWorld world;

		private Transform root;

		private IEnumerator ie;

		public ProceduralTile(ProceduralWorld world, int x, int z)
		{
		}

		[DebuggerHidden]
		public IEnumerator Generate()
		{
			return null;
		}

		public void ForceFinish()
		{
		}

		private Vector3 RandomInside()
		{
			return default(Vector3);
		}

		private Vector3 RandomInside(float px, float pz)
		{
			return default(Vector3);
		}

		private Quaternion RandomYRot()
		{
			return default(Quaternion);
		}

		[DebuggerHidden]
		private IEnumerator InternalGenerate()
		{
			return null;
		}

		public void Destroy()
		{
		}
	}

	public Transform target;

	public ProceduralPrefab[] prefabs;

	public int range;

	public float tileSize;

	public int subTiles;

	private Dictionary<Int2, ProceduralTile> tiles;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
