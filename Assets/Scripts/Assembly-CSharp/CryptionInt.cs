using System;

[Serializable]
public class CryptionInt
{
	public static int[] Keys;

	public const int MagicNumber = 2127342417;

	public const int keyCount = 10;

	protected int value;

	protected int id;

	protected int count;

	public CryptionInt(int v)
	{
	}

	public static void ResetKeys()
	{
	}

	public void Reset()
	{
	}

	public int GetCaculatedKey()
	{
		return 0;
	}

	public void SetValue(int num)
	{
	}

	public int GetValue()
	{
		return 0;
	}

	public static CryptionInt operator +(CryptionInt a, CryptionInt b)
	{
		return null;
	}

	public static CryptionInt operator -(CryptionInt a, CryptionInt b)
	{
		return null;
	}
}
