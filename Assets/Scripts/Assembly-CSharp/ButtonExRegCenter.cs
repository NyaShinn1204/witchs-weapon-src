using System.Collections.Generic;
using UnityEngine;

public class ButtonExRegCenter
{
	private static ButtonExRegCenter _instance;

	public static char TypeKeyJoinChar;

	public static char TypeKeySplitChar;

	public static string ContainerNameEndStr;

	private Dictionary<string, GameObject> id2objMap;

	public static ButtonExRegCenter GetInstance()
	{
		return null;
	}

	public void Reg(UIBtnType btnType, string typeKey, GameObject obj)
	{
	}

	public void UnReg(UIBtnType btnType, string typeKey)
	{
	}

	public GameObject GetBtnObj(string key, bool isAllowNull = false)
	{
		return null;
	}
}
