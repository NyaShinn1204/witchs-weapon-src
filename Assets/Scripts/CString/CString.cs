using System;
using System.Collections.Generic;
using System.Globalization;

[Serializable]
public class CString : IDisposable
{
	internal class CStringBlock : IStringBlock, IDisposable
	{
		private List<CString> list;

		private bool beDisposed;

		public void Init()
		{
		}

		public void Push(CString str)
		{
		}

		public void Dispose()
		{
		}
	}

	private static ArrayPool<char> pool;

	private static Queue<CString> queue;

	private static Queue<CStringBlock> blocks;

	private static Stack<CStringBlock> stack;

	private static CStringBlock currentBlock;

	private static string NewLine;

	[NonSerialized]
	private char[] _buffer;

	[NonSerialized]
	private int length;

	private bool beDisposed;

	private static readonly char[] WhiteChars;

	private static List<CString> splitList;

	private static char[] numbuffer;

	public char Item
	{
		get
		{
			return '\0';
		}
	}

	public int Length
	{
		get
		{
			return 0;
		}
	}

	public CString(int count)
	{
	}

	public int EnsureCapacity(int capacity)
	{
		return 0;
	}

	private CString()
	{
	}

	public static CString Alloc(int size)
	{
		return null;
	}

	public void Dispose()
	{
	}

	public static IStringBlock Block()
	{
		return null;
	}

	private void ClearBuffer(char[] buffer)
	{
	}

	public void Clear()
	{
	}

	public static bool Equals(CString a, CString b)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	internal CString SubstringUnchecked(int startIndex, int len)
	{
		return null;
	}

	internal int IndexOfUnchecked(char value, int startIndex, int count)
	{
		return 0;
	}

	internal int IndexOfOrdinalUnchecked(string value, int startIndex, int count)
	{
		return 0;
	}

	public CString Replace(char oldChar, char newChar)
	{
		return null;
	}

	public CString Replace(char oldChar, char newChar, int startIndex, int count)
	{
		return null;
	}

	public CString Replace(string oldValue, string newValue)
	{
		return null;
	}

	private CString ReplaceUnchecked(string oldValue, string newValue)
	{
		return null;
	}

	private CString ReplaceFallback(string oldValue, string newValue, int testedCount)
	{
		return null;
	}

	public CString ToLower()
	{
		return null;
	}

	public CString ToLower(CultureInfo culture)
	{
		return null;
	}

	internal CString ToLowerInvariant()
	{
		return null;
	}

	internal CString ToLower(TextInfo text)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public string CopyToString(string str)
	{
		return null;
	}

	public CString Append(CString right)
	{
		return null;
	}

	public CString Append(char value)
	{
		return null;
	}

	public CString Append(int value)
	{
		return null;
	}

	public CString Append(string value)
	{
		return null;
	}

	public CString Append(string value, int startIndex, int count)
	{
		return null;
	}

	internal unsafe static void memset(byte* dest, int val, int len)
	{
	}

	private unsafe static void memcpy4(byte* dest, byte* src, int size)
	{
	}

	private unsafe static void memcpy2(byte* dest, byte* src, int size)
	{
	}

	internal unsafe static void CharCopy(char* dest, char* src, int count)
	{
	}

	internal static void CharCopy(char[] target, char[] source, int count)
	{
	}
}
