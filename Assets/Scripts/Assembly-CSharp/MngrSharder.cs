using System.Collections.Generic;
using UnityEngine;

public class MngrSharder : MonoBehaviour
{
	private static Dictionary<int, Dictionary<int, Material[]>> _saveMaterial;

	public static readonly int MATERIAL_TINTCOLOR;

	public static void saveData(GameObject sObj)
	{
	}

	public static void resetData(GameObject sObj)
	{
	}

	public static void playDeath(GameObject sObj, FunctionUnArgs sEvent)
	{
	}

	public static void playFlashWhite(GameObject sObj, float sTime)
	{
	}

	public static void playFlashRed(GameObject sObj, float sTime)
	{
	}

	public static void playFlashLoop(GameObject sObj, float sDelat)
	{
	}

	public static void stopFlashLoop(GameObject sObj)
	{
	}

	public static void playFlash(GameObject sObj, Color fromColor, Color toColor, float sTime, bool sIsFromNormal = false)
	{
	}

	public static void playFlash(GameObject sObj, Color fromColor, Color midColor, Color toColor, float sTime, bool sIsFromNormal = true)
	{
	}
}
