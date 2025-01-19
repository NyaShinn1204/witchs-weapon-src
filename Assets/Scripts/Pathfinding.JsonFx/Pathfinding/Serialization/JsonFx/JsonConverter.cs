using System;
using System.Collections.Generic;

namespace Pathfinding.Serialization.JsonFx
{
	public abstract class JsonConverter
	{
		public abstract bool CanConvert(Type t);

		public void Write(JsonWriter writer, Type type, object value)
		{
		}

		public object Read(JsonReader reader, Type type, Dictionary<string, object> value)
		{
			return null;
		}

		public float CastFloat(object o)
		{
			return 0f;
		}

		public abstract Dictionary<string, object> WriteJson(Type type, object value);

		public abstract object ReadJson(Type type, Dictionary<string, object> value);
	}
}
