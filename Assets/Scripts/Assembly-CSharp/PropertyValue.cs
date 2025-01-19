using System;
using System.Collections.Generic;

[Serializable]
public class PropertyValue
{
	public CryptionFloat basicValue;

	protected Dictionary<int, CryptionFloat> valueAdditionDic;

	protected Dictionary<int, int> conditionAdditionDic;

	protected int additionCount;

	public PropertyValue(float basic = 0f)
	{
	}

	public PropertyValue(float basic, bool isBasicRateVal)
	{
	}

	public void SetBasicValue(float value)
	{
	}

	public void SetValue(float value, int condition)
	{
	}

	private int AddAdditionValue(int condition, float value)
	{
		return 0;
	}

	private void RemoveAdditionValue(int index)
	{
	}

	public float GetValue(int condition = 0)
	{
		return 0f;
	}

	public float InternalGetValue(int condition)
	{
		return 0f;
	}
}
