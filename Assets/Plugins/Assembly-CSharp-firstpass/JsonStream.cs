using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class JsonStream : ISerializerStream
{
	private Stack<JSONNode> _nodeStack;

	private ITypeResolver _typeResolver;

	private Dictionary<string, IUFSerializable> _referenceObjects;

	public JSONNode RootNode { get; set; }

	public Dictionary<string, IUFSerializable> ReferenceObjects
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ITypeResolver TypeResolver
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool DeepSerialize { get; set; }

	public Stack<JSONNode> NodeStack
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public JSONNode CurrentNode
	{
		get
		{
			return null;
		}
	}

	public IGameContainer DependencyContainer { get; set; }

	public bool UseReferences { get; set; }

	public JsonStream(JSONNode node)
	{
	}

	public JsonStream()
	{
	}

	public JsonStream(string json)
	{
	}

	public JsonStream(ITypeResolver typeResolver)
	{
	}

	public JsonStream(ITypeResolver typeResolver, string json)
	{
	}

	public void Push(string name, JSONNode node)
	{
	}

	public void Pop()
	{
	}

	public void Serialize(string name, object obj)
	{
	}

	public void SerializeArray<T>(string name, IEnumerable<T> items)
	{
	}

	public void SerializeObjectArray(string name, IEnumerable<object> items)
	{
	}

	public void SerializeObject(string name, object value)
	{
	}

	public void SerializeInt(string name, int value)
	{
	}

	public void SerializeBool(string name, bool value)
	{
	}

	public void SerializeString(string name, string value)
	{
	}

	public void SerializeVector2(string name, Vector2 value)
	{
	}

	public void SerializeVector3(string name, Vector3 value)
	{
	}

	public void SerializeQuaternion(string name, Quaternion value)
	{
	}

	public void SerializeDouble(string name, double value)
	{
	}

	public void SerializeFloat(string name, float value)
	{
	}

	public void SerializeBytes(string name, byte[] bytes)
	{
	}

	[DebuggerHidden]
	public IEnumerable<T> DeserializeObjectArray<T>(string name)
	{
		return null;
	}

	public T DeserializeObject<T>(string name)
	{
		return default(T);
	}

	public object DeserializeObject(string name)
	{
		return null;
	}

	private object DeserializeObjectFromCurrent()
	{
		return null;
	}

	public int DeserializeInt(string name)
	{
		return 0;
	}

	public bool DeserializeBool(string name)
	{
		return false;
	}

	public string DeserializeString(string name)
	{
		return null;
	}

	public Vector2 DeserializeVector2(string name)
	{
		return default(Vector2);
	}

	public Vector3 DeserializeVector3(string name)
	{
		return default(Vector3);
	}

	public Quaternion DeserializeQuaternion(string name)
	{
		return default(Quaternion);
	}

	public double DeserializeDouble(string name)
	{
		return 0.0;
	}

	public float DeserializeFloat(string name)
	{
		return 0f;
	}

	public byte[] DeserializeBytes(string name)
	{
		return null;
	}

	public void Load(byte[] readAllBytes)
	{
	}

	public byte[] Save()
	{
		return null;
	}
}
