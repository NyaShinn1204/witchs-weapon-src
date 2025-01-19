public class JSONLazyCreator : JSONNode
{
	private string m_Key;

	private JSONNode m_Node;

	public override JSONArray AsArray
	{
		get
		{
			return null;
		}
	}

	public override bool AsBool
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override double AsDouble
	{
		get
		{
			return 0.0;
		}
		set
		{
		}
	}

	public override float AsFloat
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public override int AsInt
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public override JSONClass AsObject
	{
		get
		{
			return null;
		}
	}

	public override JSONNode Item
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override JSONNode Item
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public JSONLazyCreator(JSONNode aNode)
	{
	}

	public JSONLazyCreator(JSONNode aNode, string aKey)
	{
	}

	public static bool operator !=(JSONLazyCreator a, object b)
	{
		return false;
	}

	public static bool operator ==(JSONLazyCreator a, object b)
	{
		return false;
	}

	public override void Add(JSONNode aItem)
	{
	}

	public override void Add(string aKey, JSONNode aItem)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	public override string ToString(string aPrefix)
	{
		return null;
	}

	private void Set(JSONNode aVal)
	{
	}
}
