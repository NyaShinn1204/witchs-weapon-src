using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class JSONNode
{
	public virtual IEnumerable<JSONNode> Childs
	{
		get
		{
			return null;
		}
	}

	public virtual int Count
	{
		get
		{
			return 0;
		}
	}

	public IEnumerable<JSONNode> DeepChilds
	{
		get
		{
			return null;
		}
	}

	public virtual string Value
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual JSONNode Item
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual JSONNode Item
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual JSONArray AsArray
	{
		get
		{
			return null;
		}
	}

	public virtual bool AsBool
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual double AsDouble
	{
		get
		{
			return 0.0;
		}
		set
		{
		}
	}

	public virtual float AsFloat
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public virtual int AsInt
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual JSONClass AsObject
	{
		get
		{
			return null;
		}
	}

	public virtual Quaternion AsQuaternion
	{
		get
		{
			return default(Quaternion);
		}
		set
		{
		}
	}

	public virtual Vector2 AsVector2
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public virtual Vector3 AsVector3
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public virtual Vector4 AsVector4
	{
		get
		{
			return default(Vector4);
		}
		set
		{
		}
	}

	public virtual void Add(string aKey, JSONNode aItem)
	{
	}

	public virtual void Add(JSONNode aItem)
	{
	}

	public virtual JSONNode Remove(string aKey)
	{
		return null;
	}

	public virtual JSONNode Remove(int aIndex)
	{
		return null;
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public virtual string ToString(string aPrefix)
	{
		return null;
	}

	public static implicit operator JSONNode(string s)
	{
		return null;
	}

	public static implicit operator string(JSONNode d)
	{
		return null;
	}

	public static bool operator !=(JSONNode a, object b)
	{
		return false;
	}

	public static bool operator ==(JSONNode a, object b)
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

	public static JSONNode Deserialize(BinaryReader aReader)
	{
		return null;
	}

	public static JSONNode LoadFromBase64(string aBase64)
	{
		return null;
	}

	public static JSONNode LoadFromCompressedBase64(string aBase64)
	{
		return null;
	}

	public static JSONNode LoadFromCompressedFile(string aFileName)
	{
		return null;
	}

	public static JSONNode LoadFromCompressedStream(Stream aData)
	{
		return null;
	}

	public static JSONNode LoadFromFile(string aFileName)
	{
		return null;
	}

	public static JSONNode LoadFromStream(Stream aData)
	{
		return null;
	}

	public static JSONNode Parse(string aJSON)
	{
		return null;
	}

	public string SaveToBase64()
	{
		return null;
	}

	public string SaveToCompressedBase64()
	{
		return null;
	}

	public void SaveToCompressedFile(string aFileName)
	{
	}

	public void SaveToCompressedStream(Stream aData)
	{
	}

	public void SaveToStream(Stream aData)
	{
	}

	public virtual void Serialize(BinaryWriter aWriter)
	{
	}

	internal static string Escape(string aText)
	{
		return null;
	}
}
