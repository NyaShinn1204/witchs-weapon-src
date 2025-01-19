using System.Text.RegularExpressions;

public class Expression
{
	public const int MAX_NAG_COUNT = 10;

	private static char[] splitChar;

	private static char[] splitCharMulti;

	public static Regex regAdd;

	public static Regex regMulti;

	public static float[] arr;

	public static int pointer;

	public static void ResetNagNums()
	{
	}

	public static float GetValue(string exp, NameSpace field = null)
	{
		return 0f;
	}

	public static float GetValueEx(string exp, NameSpace field = null)
	{
		return 0f;
	}

	private static float GetSingleValue(string exp, NameSpace field = null)
	{
		return 0f;
	}

	public static string TakeOffBracketsAndCalu(string exp, NameSpace field = null)
	{
		return null;
	}

	private static int FindEndIndex(string exp)
	{
		return 0;
	}

	public static float CaluOnlyMultiAndDiv(string exp, NameSpace field = null)
	{
		return 0f;
	}

	public static string FindSymbal(string exp, Regex reg)
	{
		return null;
	}
}
