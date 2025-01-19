using System.Collections.Generic;
using UnityEngine;

public class Utils
{
	public static Vector3 GetDirByDirs(Vector3 from, Vector3 to, float absAngle)
	{
		return default(Vector3);
	}

	public static bool IsOnLeft(Vector3 from, Vector3 to)
	{
		return false;
	}

	public static void MoveToFaraway(GameObject obj, bool isLocal = false)
	{
	}

	public static void MoveToCurrent(GameObject obj, bool isLocal = false)
	{
	}

	public static GameObject GetCallSkillServant(string prefab)
	{
		return null;
	}

	public static void CreateGolds(Transform transform)
	{
	}

	public static int GetColorByRank(int rank)
	{
		return 0;
	}

	public static int GetRankStripNum(int rank)
	{
		return 0;
	}

	public static bool inRange(float range, Vector3 pos1, Vector3 pos2)
	{
		return false;
	}

	public static Vector3 PolarCoordinateConvert(Vector3 origin, Vector3 direction, float radius, float angle)
	{
		return default(Vector3);
	}

	public static Vector3 RotateVectorByY(Vector3 vector, float angle)
	{
		return default(Vector3);
	}

	public static void LookAtPosition(Transform trans, Vector3 position)
	{
	}

	public static void LookAtDirection(Transform trans, Vector3 direction, bool reverse = true)
	{
	}

	public static void Write(string path, string text, string fileName, string tail = ".log")
	{
	}

	public static bool IsVectorEmpty(Vector3 vector)
	{
		return false;
	}

	public static bool IsHitBlock(Vector3 from, Vector3 to)
	{
		return false;
	}

	public static Vector3 HitBlockPoint(Vector3 from, Vector3 to)
	{
		return default(Vector3);
	}

	public static Vector3 CompareNestPoint(Vector3 soursepoint, Vector3 point1, Vector3 point2)
	{
		return default(Vector3);
	}

	public static Vector3 HitEntityPoint(Vector3 from, Vector3 to, string name)
	{
		return default(Vector3);
	}

	public static Vector3 HitBlockPointRot(Vector3 from, Vector3 to, Vector3 center)
	{
		return default(Vector3);
	}

	public static Vector3 GetEmptyPlaceByLinear(Vector3 sourcePlaces, Vector3 direction, float length, int angle, float radius)
	{
		return default(Vector3);
	}

	public static Vector3 GetEmptyPlaceByRound(Vector3 sourcePlaces, Vector3 direction, float length, int angle, float radius)
	{
		return default(Vector3);
	}

	public static List<string> ReadAll(string path)
	{
		return null;
	}

	public static List<string> ConvertAll(List<string> list)
	{
		return null;
	}

	public static void WriteAll(string fileName, List<string> all)
	{
	}

	public static string CombinList(List<string> list)
	{
		return null;
	}
}
