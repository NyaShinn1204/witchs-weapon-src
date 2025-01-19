using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

public class JSONArray : JSONNode, IEnumerable
{
	private List<JSONNode> m_List;

	public override IEnumerable<JSONNode> Childs
	{
		get
		{
			return null;
		}
	}

	public override int Count
	{
		get
		{
			return 0;
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

	public override void Add(string aKey, JSONNode aItem)
	{
	}

	[DebuggerHidden]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	public override JSONNode Remove(int aIndex)
	{
		return null;
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		return null;
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
