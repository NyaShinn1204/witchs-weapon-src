using System.Collections.Generic;
using UnityEngine;

public class MeshYYManager : MonoBehaviour
{
	private Dictionary<GameObject, MeshRenderer> parent2yy;

	private GameObject yy_prefab_res;

	private MeshRenderer yy_prefab;

	private static MeshYYManager _instance;

	public static MeshYYManager GetInstance()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void ResetPool()
	{
	}

	public void AddYY(GameObject yyparent)
	{
	}

	public void RemoveYY(GameObject yyparent)
	{
	}

	private void SetLayerRecursively(GameObject obj, int newLayer)
	{
	}
}
