using System.Collections.Generic;
using UnityEngine;

public sealed class ObjectPool : MonoBehaviour
{
	private static ObjectPool _instance;

	private Dictionary<Component, List<Component>> objectLookup;

	private Dictionary<Component, Component> prefabLookup;

	public static ObjectPool instance
	{
		get
		{
			return null;
		}
	}

	public static void Clear()
	{
	}

	public static void CreatePool<T>(T prefab) where T : Component
	{
	}

	public static T Spawn<T>(T prefab, Vector3 position, Quaternion rotation) where T : Component
	{
		return null;
	}

	public static T Spawn<T>(T prefab, Vector3 position) where T : Component
	{
		return null;
	}

	public static T Spawn<T>(T prefab) where T : Component
	{
		return null;
	}

	public static void Recycle<T>(T obj) where T : Component
	{
	}

	public static int Count<T>(T prefab) where T : Component
	{
		return 0;
	}
}
