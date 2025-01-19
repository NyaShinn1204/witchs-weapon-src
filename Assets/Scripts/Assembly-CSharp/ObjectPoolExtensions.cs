using UnityEngine;

public static class ObjectPoolExtensions
{
	public static void CreatePool<T>(this T prefab) where T : Component
	{
	}

	public static T Spawn<T>(this T prefab, Vector3 position, Quaternion rotation) where T : Component
	{
		return null;
	}

	public static T Spawn<T>(this T prefab, Vector3 position) where T : Component
	{
		return null;
	}

	public static T Spawn<T>(this T prefab) where T : Component
	{
		return null;
	}

	public static void Recycle<T>(this T obj) where T : Component
	{
	}

	public static int Count<T>(T prefab) where T : Component
	{
		return 0;
	}
}
