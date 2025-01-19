using System.Collections.Generic;
using UnityEngine;

public interface ISerializerStream
{
	IGameContainer DependencyContainer { get; set; }

	Dictionary<string, IUFSerializable> ReferenceObjects { get; set; }

	ITypeResolver TypeResolver { get; set; }

	bool DeepSerialize { get; set; }

	void SerializeArray<T>(string name, IEnumerable<T> items);

	void SerializeObjectArray(string name, IEnumerable<object> items);

	void SerializeObject(string name, object value);

	void SerializeInt(string name, int value);

	void SerializeBool(string name, bool value);

	void SerializeString(string name, string value);

	void SerializeVector2(string name, Vector2 value);

	void SerializeVector3(string name, Vector3 value);

	void SerializeQuaternion(string name, Quaternion value);

	void SerializeDouble(string name, double value);

	void SerializeFloat(string name, float value);

	void SerializeBytes(string name, byte[] bytes);

	IEnumerable<T> DeserializeObjectArray<T>(string name);

	T DeserializeObject<T>(string name);

	object DeserializeObject(string name);

	int DeserializeInt(string name);

	bool DeserializeBool(string name);

	string DeserializeString(string name);

	Vector2 DeserializeVector2(string name);

	Vector3 DeserializeVector3(string name);

	Quaternion DeserializeQuaternion(string name);

	double DeserializeDouble(string name);

	float DeserializeFloat(string name);

	byte[] DeserializeBytes(string name);

	void Load(byte[] readAllBytes);

	byte[] Save();
}
