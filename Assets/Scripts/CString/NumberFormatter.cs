using System;
using System.Globalization;
using System.Text;
using System.Threading;

internal class NumberFormatter
{
	private class CustomInfo
	{
		public bool UseGroup;

		public int DecimalDigits;

		public int DecimalPointPos;

		public int DecimalTailSharpDigits;

		public int IntegerDigits;

		public int IntegerHeadSharpDigits;

		public int IntegerHeadPos;

		public bool UseExponent;

		public int ExponentDigits;

		public int ExponentTailSharpDigits;

		public bool ExponentNegativeSignOnly;

		public int DividePlaces;

		public int Percents;

		public int Permilles;

		public static void GetActiveSection(string format, ref bool positive, bool zero, ref int offset, ref int length)
		{
		}

		public static CustomInfo Parse(string format, int offset, int length, NumberFormatInfo nfi)
		{
			return null;
		}

		public StringBuilder Format(string format, int offset, int length, NumberFormatInfo nfi, bool positive, StringBuilder sb_int, StringBuilder sb_dec, StringBuilder sb_exp)
		{
			return null;
		}
	}

	private static readonly int[] DecHexDigits;

	private static readonly char[] DigitLowerTable;

	private static readonly char[] DigitUpperTable;

	private static readonly long[] TenPowersList;

	private static readonly ulong[] MantissaBitsTable;

	private static readonly int[] TensExponentTable;

	private Thread _thread;

	private static NumberFormatInfo _nfi;

	private int _ind;

	private bool _NaN;

	private bool _infinity;

	private bool _isCustomFormat;

	private bool _specifierIsUpper;

	private bool _positive;

	private char _specifier;

	private int _precision;

	private int _defPrecision;

	private int _digitsLen;

	private int _offset;

	private int _decPointPos;

	private uint _val1;

	private uint _val2;

	private uint _val3;

	private uint _val4;

	[ThreadStatic]
	private static NumberFormatter threadNumberFormatter;

	private bool IsFloatingSource
	{
		get
		{
			return false;
		}
	}

	public CultureInfo CurrentCulture
	{
		set
		{
		}
	}

	private int IntegerDigits
	{
		get
		{
			return 0;
		}
	}

	private int DecimalDigits
	{
		get
		{
			return 0;
		}
	}

	private bool IsZero
	{
		get
		{
			return false;
		}
	}

	private bool IsZeroInteger
	{
		get
		{
			return false;
		}
	}

	private static long GetTenPowerOf(int i)
	{
		return 0L;
	}

	static NumberFormatter()
	{
	}

	private void InitDecHexDigits(uint value)
	{
	}

	private static int FastDecHexLen(int val)
	{
		return 0;
	}

	private static int DecHexLen(uint val)
	{
		return 0;
	}

	private int DecHexLen()
	{
		return 0;
	}

	private static int ScaleOrder(long hi)
	{
		return 0;
	}

	private static int ParsePrecision(string format)
	{
		return 0;
	}

	public NumberFormatter(Thread current)
	{
	}

	private void InitHex(ulong value)
	{
	}

	private void Init(string format)
	{
	}

	private void Init(string format, int value, int defPrecision)
	{
	}

	private unsafe void Append(char* buf, char c)
	{
	}

	private unsafe void Append(char* buf, char c, int cnt)
	{
	}

	private unsafe void Append(char* dest, string s)
	{
	}

	private void RoundPos(int pos)
	{
	}

	private bool RoundDecimal(int decimals)
	{
		return false;
	}

	private bool RoundBits(int shift)
	{
		return false;
	}

	private void RemoveTrailingZeros()
	{
	}

	private void AddOneToDecHex()
	{
	}

	private static uint AddOneToDecHex(uint val)
	{
		return 0u;
	}

	private int CountTrailingZeros()
	{
		return 0;
	}

	private static int CountTrailingZeros(uint val)
	{
		return 0;
	}

	private static NumberFormatter GetInstance()
	{
		return null;
	}

	private void Release()
	{
	}

	private NumberFormatInfo GetNumberFormatInstance(IFormatProvider fp)
	{
		return null;
	}

	private static uint FastToDecHex(int val)
	{
		return 0u;
	}

	private static uint ToDecHex(int val)
	{
		return 0u;
	}

	public unsafe static int NumberToString(char* p, string format, int value, IFormatProvider fp)
	{
		return 0;
	}

	public unsafe static int NumberToString(char* buf, int value, IFormatProvider fp)
	{
		return 0;
	}

	private unsafe static int CharCopy(char* buf, string str)
	{
		return 0;
	}

	public unsafe int FastIntToCString(char* p, int value, IFormatProvider fp)
	{
		return 0;
	}

	private unsafe int IntegerToString(char* buf, string format, IFormatProvider fp)
	{
		return 0;
	}

	public unsafe int FormatCurrency(char* buf, int precision, NumberFormatInfo nfi)
	{
		return 0;
	}

	private unsafe int FormatDecimal(char* buf, int precision, NumberFormatInfo nfi)
	{
		return 0;
	}

	private unsafe int FormatHexadecimal(char* buf, int precision)
	{
		return 0;
	}

	public unsafe int FormatFixedPoint(char* buf, int precision, NumberFormatInfo nfi)
	{
		return 0;
	}

	private unsafe int FormatGeneral(char* buf, int precision, NumberFormatInfo nfi)
	{
		return 0;
	}

	public unsafe int FormatPercent(char* buf, int precision, NumberFormatInfo nfi)
	{
		return 0;
	}

	public unsafe int FormatNumber(char* buf, int precision, NumberFormatInfo nfi)
	{
		return 0;
	}

	public unsafe int FormatExponential(char* buf, int precision, NumberFormatInfo nfi)
	{
		return 0;
	}

	private unsafe int FormatExponential(char* buf, int precision, NumberFormatInfo nfi, int expDigits)
	{
		return 0;
	}

	public unsafe int FormatCustom(char* buf, string format, NumberFormatInfo nfi)
	{
		return 0;
	}

	private static void ZeroTrimEnd(StringBuilder sb, bool canEmpty)
	{
	}

	private static bool IsZeroOnly(StringBuilder sb)
	{
		return false;
	}

	private static void AppendNonNegativeNumber(StringBuilder sb, int v)
	{
	}

	private void AppendIntegerString(int minLength, StringBuilder sb)
	{
	}

	private unsafe void AppendIntegerString(char* buf, int minLength)
	{
	}

	private unsafe void AppendIntegerStringWithGroupSeparator(char* buf, int[] groups, string groupSeparator)
	{
	}

	private void AppendDecimalString(int precision, StringBuilder sb)
	{
	}

	private unsafe void AppendDecimalString(char* buf, int precision)
	{
	}

	private unsafe void AppendExponent(char* buf, NumberFormatInfo nfi, int exponent, int minDigits)
	{
	}

	private unsafe void AppendOneDigit(char* buf, int start)
	{
	}

	private unsafe void FastAppendDigits(char* buf, int val, bool force)
	{
	}

	private unsafe void AppendDigits(char* buf, int start, int end)
	{
	}

	private void AppendDigits(int start, int end, StringBuilder sb)
	{
	}

	private void Multiply10(int count)
	{
	}

	private void Divide10(int count)
	{
	}
}
