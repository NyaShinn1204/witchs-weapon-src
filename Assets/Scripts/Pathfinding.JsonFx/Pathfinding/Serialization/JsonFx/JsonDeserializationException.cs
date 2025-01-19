using System;

namespace Pathfinding.Serialization.JsonFx
{
	public class JsonDeserializationException : JsonSerializationException
	{
		private int index;

		public JsonDeserializationException(string message, int index)
			: base(null)
		{
		}

		public JsonDeserializationException(string message, Exception innerException, int index)
			: base(null)
		{
		}
	}
}
