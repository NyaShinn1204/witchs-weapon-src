using System.IO;
using UnityEngine;

public class JSONData : JSONNode
{
	private string m_Data;

	public override string Value
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public JSONData(Vector3 value)
	{
	}

	public JSONData(Vector2 value)
	{
	}

	public JSONData(Quaternion value)
	{
	}

	public JSONData(string aData)
	{
	}

	public JSONData(float aData)
	{
	}

	public JSONData(double aData)
	{
	}

	public JSONData(bool aData)
	{
	}

	public JSONData(int aData)
	{
	}

	public override void Serialize(BinaryWriter aWriter)
	{
	}

	public override string ToString()
	{
		return null;
	}

	public override string ToString(string aPrefix)
	{
		return null;
	}
}
