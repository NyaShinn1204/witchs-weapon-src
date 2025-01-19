using System.Collections.Generic;
using UnityEngine;

public class UtilStringDFA : MonoBehaviour
{
	private class UtilStringDFAData
	{
		public bool isEnd;

		public Dictionary<string, UtilStringDFAData> next;
	}

	private static UtilStringDFA _current;

	private static Dictionary<string, UtilStringDFAData> _data;

	public static void Init()
	{
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public static void AddFuck(string sData)
	{
	}

	public static bool IsHasFuck(string sData)
	{
		return false;
	}

	public static string RepaceFuck(string sData, string sReapce = "*")
	{
		return null;
	}
}
